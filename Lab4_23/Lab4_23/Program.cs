using Lab4_23.Data;
using Lab4_23.Helpers.Extensions;
using Lab4_23.Helpers.Seeders;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
	options.AddPolicy(name: MyAllowSpecificOrigins,
		policy =>
		{
			policy.WithOrigins("http://localhost:4200", "https://localhost:4200")
				.AllowAnyHeader()
				.AllowAnyMethod()
				.AllowCredentials();
		});
});

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<Lab4Context>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// create by me
// builder.Services.AddTransient<IPostRepository, PostRepository>();
builder.Services.AddRepositories();
builder.Services.AddServices();

// automapper 
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();
// SeedData(app);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();

/*void SeedData(IHost app)
{
	var scopedFactory = app.Services.GetService<IServiceScopeFactory>();
	using (var scope = scopedFactory.CreateScope())
	{
		var service = scope.ServiceProvider.GetService<PostsSeeder>();
		service.SeedInitialPosts();
	}
}*/