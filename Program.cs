using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using shopping_cart_blazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<ProductProviderService>();
builder.Services.AddHttpClient<IProductProviderService, ProductProviderService>(client =>
{
    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
});


//register services/cartService
builder.Services.AddScoped<CartService>();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

