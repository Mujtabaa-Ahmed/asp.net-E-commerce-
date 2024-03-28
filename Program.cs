using Microsoft.EntityFrameworkCore;
using OnlineStore.DB;

namespace OnlineStore
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			builder.Services.AddDbContext<Db_Class>(options => {
				//options.UseSqlServer(builder.Configuration.GetConnectionString("MyDBConnection") ?? throw new InvalidOperationException("Connection string 'RazorPagesMovieContext' not found.")));
				options.UseSqlServer("Server=DESKTOP-713LM2T;Database=db_onlinemart;MultipleActiveResultSets=true;Trusted_Connection=True;TrustServerCertificate=True");
			});
			builder.Services.AddDatabaseDeveloperPageExceptionFilter();

			builder.Services.AddDistributedMemoryCache();

			builder.Services.AddSession(options =>
			{
				options.IdleTimeout = TimeSpan.FromSeconds(1800);
				options.Cookie.HttpOnly = true;
				options.Cookie.IsEssential = true;
			});


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
			app.UseSession();
			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}