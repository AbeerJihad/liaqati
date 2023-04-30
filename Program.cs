using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add Services to the container.
//builder.Services.AddSingleton<Service>();
EmailSettings emailSetting = builder.Configuration.GetSection(nameof(EmailSettings)).Get<EmailSettings>();
builder.Services.AddSingleton(emailSetting);
builder.Services.AddScoped<MyEmailService>();

builder.Services.AddControllers().AddJsonOptions(op =>
{
    op.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

//builder.Services.AddDbContext<LiaqatiDBContext>(options => options.UseLazyLoadingProxies().UseInMemoryDatabase("LiaqatiDB"));
var connectionString = builder.Configuration.GetConnectionString("DefaultConntection");
builder.Services.AddDbContext<LiaqatiDBContext>(options =>
    options.UseLazyLoadingProxies().UseSqlServer(connectionString));
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


builder.Services.AddSwaggerGen();

builder.Services.AddEndpointsApiExplorer();

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
    app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"); c.RoutePrefix = ""; });
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

app.MapRazorPages();

app.MapControllers();

await SeedData.SeedAsync(app);
app.Run();
