using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
//builder.Services.AddSingleton<Service>();

builder.Services.AddControllers().AddJsonOptions(op =>
{
    op.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
}); 


builder.Services.AddDbContext<LiaqatiDBContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("SqlMohammed")));

builder.Services.AddScoped<GenericRepository<Order>>();
builder.Services.AddScoped<GenericRepository<User>>();
builder.Services.AddScoped<GenericRepository<SportsProgram>>();

builder.Services.AddScoped<UnitOfWork>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
///
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());



app.MapControllers();


///


app.UseAuthorization();

app.MapRazorPages();
//SeedData.SeedAsync(app);  
app.Run();
