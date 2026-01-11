using SmoothCareers.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SmoothCareers.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using SmoothCareers.Components.Account;
using SmoothCareers.Domain;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextFactory<SmoothCareersContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SmoothCareersContext")
    ?? throw new InvalidOperationException("Connection string 'SmoothCareersContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();

builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = IdentityConstants.ApplicationScheme;
    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
})
.AddIdentityCookies();

builder.Services.AddIdentityCore<SmoothCareersUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<SmoothCareersContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<SmoothCareersUser>, IdentityNoOpEmailSender>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapAdditionalIdentityEndpoints();

// --- SEED JOBSEEKER AND APPLICATION ---
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<SmoothCareersContext>();

    // Make sure DB is up to date
    context.Database.Migrate();

    // Create JobSeeker if not exists
    if (!context.JobSeeker.Any(js => js.Email == "jobseeker@smoothcareers.com"))
    {
        var jobSeeker = new JobSeeker
        {
            FullName = "John Doe",
            Email = "jobseeker@smoothcareers.com",
        };
        context.JobSeeker.Add(jobSeeker);
        context.SaveChanges();
    }

    // Get a job post created by employer@smoothcareers.com
    var jobPost = context.JobPost.FirstOrDefault(jp => jp.CreatedBy == "employer@smoothcareers.com");

    if (jobPost != null)
    {
        var jobSeeker = context.JobSeeker.First(js => js.Email == "jobseeker@smoothcareers.com");

        // Add one application if it doesn't exist
        if (!context.Application.Any(a => a.JobPostId == jobPost.Id && a.JobSeekerId == jobSeeker.Id))
        {
            var application = new Application
            {
                JobPostId = jobPost.Id,
                JobSeekerId = jobSeeker.Id,
                Status = "Pending",
                DateApplied = DateTime.UtcNow
            };
            context.Application.Add(application);
            context.SaveChanges();
        }
    }
}

app.Run();
