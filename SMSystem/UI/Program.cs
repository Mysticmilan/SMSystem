using AutoMapper;
using BLL;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Domin.Data;
using Domin.Profiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDBContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("SMSystemDatabase")));

builder.Services.AddScoped<StudentRepo>();
builder.Services.AddScoped<CourseRepo>();
builder.Services.AddScoped<ClassesRepo>();

builder.Services.AddScoped<StudentLogic>();
builder.Services.AddScoped<CourseLogic>();
builder.Services.AddScoped<ClassesLogic>();

//var mapperConfiguration = new MapperConfiguration(cgf =>
//{
//    cgf.AddProfile<ClassesProfile>();
//    cgf.AddProfile<CoursesProfile>();
//    cgf.AddProfile<TestProfile>();
//});

//var mapper = mapperConfiguration.CreateMapper();
//builder.Services.AddSingleton(mapper);


builder.Services.AddAutoMapper(typeof(Profile));


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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
