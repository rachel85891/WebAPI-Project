<<<<<<< HEAD
﻿using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories;
=======
﻿using Repositories;
>>>>>>> a2a7b1af37d7aed8d93ab01dfe8282c82897ce94
using Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<ILoginRepository, LoginRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
<<<<<<< HEAD
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepositoty, CategoryRepositoty>();
builder.Services.AddScoped<IOrdersRepository, OrdersRepository>();
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IPasswordService, PasswordService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddDbContext<webApiShop_216339176Context>(options=>options.UseSqlServer("Data Source=srv2\\pupils;Initial Catalog=webApiShop_216339176;Integrated Security=True;Pooling=False;Trust Server Certificate=True"));
=======

>>>>>>> a2a7b1af37d7aed8d93ab01dfe8282c82897ce94
builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IPasswordService, PasswordService>();
builder.Services.AddScoped<IUserServices, UserServices>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/openapi/v1.json", "My API V1");
});
}



// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
