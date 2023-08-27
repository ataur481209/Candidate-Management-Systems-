using Microsoft.EntityFrameworkCore;
using work_01.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<R53_CandidateDbContext>(opt=>opt.UseSqlServer(builder.Configuration.GetConnectionString("appCon")));
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
