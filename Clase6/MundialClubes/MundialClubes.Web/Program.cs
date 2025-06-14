using MundialClubes.Entidades.EF;
using MundialClubes.Logica;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<MundialClubesContext>();
builder.Services.AddScoped<IJugadorEstrellaLogica, JugadorEstrellaLogica>();
builder.Services.AddScoped<IClubLogica, ClubLogica>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=JugadorEstrella}/{action=Lista}/{id?}");

app.Run();
