using liaqati_master.Services.Repositories;
using Microsoft.AspNetCore.Identity;
using SportProductsWeb.Services;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add Services to the container.
//builder.Services.AddSingleton<Service>();
EmailSetting emailSetting = builder.Configuration.GetSection("EmailSetting").Get<EmailSetting>();
builder.Services.AddSingleton(emailSetting);
builder.Services.AddScoped<AppEmailService>();

builder.Services.AddControllers().AddJsonOptions(op => { op.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; });
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

//builder.Services.AddDbContext<LiaqatiDBContext>(options => options.UseLazyLoadingProxies().UseInMemoryDatabase("LiaqatiDB"));

builder.Services.AddDbContext<LiaqatiDBContext>(options =>
    options.UseLazyLoadingProxies()
    .UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConntection")
        )
    );

builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<LiaqatiDBContext>().AddDefaultTokenProviders();
builder.Services.Configure<IdentityOptions>((options =>
{
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;
    options.Password.RequireDigit = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 6;
    options.Password.RequireUppercase = false;
    options.SignIn.RequireConfirmedAccount = false;
    options.SignIn.RequireConfirmedEmail = false;
    options.User.AllowedUserNameCharacters = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890@.ضصثقفغعهخحجدشسيبلاتنمكطئء ؤرلاىةوزظإآ";
}));


builder.Services.AddScoped<UnitOfWork>();
builder.Services.AddScoped<IRepoProgram, ProgramMang>();
builder.Services.AddScoped<IRepoProgramExercies, ProgramExerciesMang>();
builder.Services.AddScoped<IFormFileMang, RepoFile>();
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

    app.UseSwagger();
    app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"); c.RoutePrefix = ""; });

}
else
{
    app.UseSwagger();
    app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"); c.RoutePrefix = ""; });
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseCors(builder =>
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
