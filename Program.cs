using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add Services to the container.
//builder.Services.AddSingleton<Service>();


var connectionString = builder.Configuration.GetConnectionString("DefaultConntection");
builder.Services.AddDbContext<LiaqatiDBContext>(options =>
    options.UseLazyLoadingProxies().UseSqlServer(connectionString));
EmailSettings emailSetting = builder.Configuration.GetSection(nameof(EmailSettings)).Get<EmailSettings>();
builder.Services.AddSingleton(emailSetting);
builder.Services.AddScoped<MyEmailService>();

builder.Services.AddControllers().AddJsonOptions(op =>
{
    op.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

//builder.Services.AddDbContext<LiaqatiDBContext>(options => options.UseLazyLoadingProxies().UseInMemoryDatabase("LiaqatiDB"));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<LiaqatiDBContext>().AddDefaultTokenProviders();
builder.Services.Configure<IdentityOptions>((options =>
{

    //lockout options
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;
    //Password options
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
    //singIn options
    options.SignIn.RequireConfirmedAccount = false;
    options.SignIn.RequireConfirmedEmail = false;
    // Default User settings.
    //options.User.AllowedUserNameCharacters = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890@.ضصثقفغعهخحجدشسيبلاتنمكطئء ؤرلاىةوزظإآ";
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = true;

}));

builder.Services.ConfigureApplicationCookie(options =>
{
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.Cookie.Name = "YourAppCookieName";
    options.Cookie.HttpOnly = false;
    options.ExpireTimeSpan = TimeSpan.FromDays(1);
    options.LoginPath = "/Identity/Account/Login";
    options.SlidingExpiration = true;
});


/*Task.Factory.StartNew(() =>
{
    System.Threading.Thread.Sleep(Interval);
    TheMethod();
})*/

//            context.User.HasClaim(ClaimTypes.Name, "Omar@gtc.edu.ps") ||


builder.Services.AddRazorPages(options =>
{
    options.Conventions.AuthorizeAreaFolder("Admin", "/Users", Database.AdminPolicy);
    //options.Conventions.AuthorizeAreaFolder("Admin", "/SportPrograms", Database.AdminPolicy);
    //options.Conventions.AuthorizeFolder("/Products", "EditorPolicy");
    //options.Conventions.AuthorizeFolder("/Products", "PerventDisabled");
    //options.Conventions.AuthorizeFolder("/Categories", "EditorPolicy");
    //options.Conventions.AuthorizeFolder("/Categories", "PerventDisabled");
    //options.Conventions.AllowAnonymousToPage("/Products/Index");
    //options.Conventions.AllowAnonymousToAreaFolder("Identity", "/Account");
    options.Conventions.AllowAnonymousToFolder("/Articles");
    options.Conventions.AllowAnonymousToFolder("/ContactUs");
    options.Conventions.AllowAnonymousToFolder("/Exercises");
    options.Conventions.AllowAnonymousToFolder("/Experts");
    options.Conventions.AllowAnonymousToFolder("/HealthyRecipes");
    options.Conventions.AllowAnonymousToFolder("/Home");
    options.Conventions.AllowAnonymousToFolder("/MealPlan");
    options.Conventions.AllowAnonymousToFolder("/Products");
    options.Conventions.AllowAnonymousToFolder("/SportProgram");
    options.Conventions.AuthorizeAreaFolder("identity", "/Account/Manage/profile");

}
);
builder.Services.AddAuthorization(options =>
{

    options.AddPolicy(Database.AdminPolicy,
        policy => policy.RequireAssertion(
            context => context.User.HasClaim(Database.Admin, "true")));
    options.AddPolicy(Database.ExpertPolicy,
            policy => policy.RequireAssertion(
                context =>
                context.User.HasClaim(Database.Expert, "true") ||
                context.User.HasClaim(c => (c.Type == "admin" && c.Value == "true") || (c.Type == "manager" && c.Value == "true")) ||
                context.User.HasClaim(Database.Expert, "true")));
    options.AddPolicy(Database.PerventDisabledPolicy,
           policy => policy.RequireAssertion(
               context =>
               !context.User.HasClaim("isdisabled", "true")));
    options.AddPolicy(Database.LoggedInPolicy,
       policy => policy.RequireAuthenticatedUser());
}
);

builder.Services.AddScoped<UnitOfWork>();
builder.Services.AddScoped<IRepoProgramExercies>();
builder.Services.AddScoped<IRepoProgram>();
builder.Services.AddScoped<IFormFileMang, RepoFile>();
builder.Services.AddScoped<IRepoMeal_Healthy>();
builder.Services.AddScoped<IRepoMealPlans>();
builder.Services.AddScoped<IRepoFiles>();
builder.Services.AddScoped<IRepoArticles>();
builder.Services.AddScoped<IRepoExercise>();
builder.Services.AddScoped<IRepoProducts>();
builder.Services.AddScoped<IRepoFavorite>();
builder.Services.AddScoped<IRepoFavorite_Servies>();
builder.Services.AddScoped<IRepoCoupon_redemption>();
builder.Services.AddScoped<IRepoCoupon>();
builder.Services.AddScoped<IRepoChat>();
builder.Services.AddScoped<IRepoChatUser>();
builder.Services.AddScoped<IRepoComments>();
builder.Services.AddScoped<IRepoComment_Servies>();
builder.Services.AddScoped<IRepoContactUs>();
builder.Services.AddScoped<IRepoCategory>();
builder.Services.AddScoped<IRepoAchievement>();
builder.Services.AddScoped<IRepoHealthyRecipe>();
builder.Services.AddScoped<IRepoOrder>();
builder.Services.AddScoped<IRepoOrder_Details>();
builder.Services.AddScoped<IRepoRate>();
builder.Services.AddScoped<IRepoService>();
builder.Services.AddScoped<IRepoUser>();
builder.Services.AddScoped<IRepoConsultation>();
builder.Services.AddScoped<IRepoCart>();
builder.Services.AddScoped<IRepoTraking>();
builder.Services.AddScoped<IRepoNotification>();

builder.Services.AddSwaggerGen();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddNotyf(config =>
{
    config.DurationInSeconds = 7;
    config.IsDismissable = true;
    config.Position = NotyfPosition.TopCenter;
    config.HasRippleEffect = true;

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();

}
else
{
    app.UseSwagger();
    app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"); c.RoutePrefix = "api"; });
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseCors(
    builder =>
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
);

app.UseAuthentication();
app.UseAuthorization();
app.UseNotyf();

app.MapRazorPages().RequireAuthorization(new string[]
{
    Database.LoggedInPolicy, Database.PerventDisabledPolicy
});

app.MapControllers();

await SeedData.SeedAsync(app);
app.Run();
