using eMovieApp.Repository;
using eMovieApp.Repository.Interfaces;
using eMovieApp.Repository.Repositories;
using eMovieApp.Service;
using eMovieApp.Service.Interfaces;
using eMovieApp.Service.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<eMovieAppContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("eMovieAppdb")));

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));

//Dependency injection -- Services
builder.Services.AddTransient<IActorService, ActorService>();
builder.Services.AddTransient<IActorRoleService, ActorRoleService>();
builder.Services.AddTransient<IDirectorService, DirectorService>();
builder.Services.AddTransient<ILanguageService, LanguageService>();
builder.Services.AddTransient<IMovieService, MovieService>();
builder.Services.AddTransient<IMovieRequestService, MovieRequestService>();
builder.Services.AddTransient<IUserRoleService, UserRoleService>();

//Dependency injection -- Repositories
builder.Services.AddTransient<IActorRepository, ActorRepository>();
builder.Services.AddTransient<IActorRoleRepository, ActorRoleRepository>();
builder.Services.AddTransient<IDirectorRepository, DirectorRepository>();
builder.Services.AddTransient<ILanguageRepository, LanguageRepository>();
builder.Services.AddTransient<IMovieRepository, MovieRepository>();
builder.Services.AddTransient<IMovieRequestRepository, MovieRequestRepository>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserRoleRepository, UserRoleRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
