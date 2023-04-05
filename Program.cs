using liaqati_master.Services.Repositories;
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add Services to the container.
//builder.Services.AddSingleton<Service>();

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

builder.Services.AddScoped<GenericRepository<Order>>();
builder.Services.AddScoped<GenericRepository<User>>();
builder.Services.AddScoped<IRepository<Article>, RepoArticles>();
builder.Services.AddScoped<GenericRepository<SportsProgram>>();
builder.Services.AddScoped<UnitOfWork>();
builder.Services.AddScoped<IRepoProgram, ProgramMang>();
builder.Services.AddScoped<IFormFileMang, RepoFile>();

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
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseCors(builder =>
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
);

app.UseAuthorization();

app.MapRazorPages();

app.MapControllers();

await SeedData.SeedAsync(app);
app.Run();
