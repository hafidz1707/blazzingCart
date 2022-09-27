using System;
using System.Collections.Immutable;
using shopping_cart_blazor.Models;

namespace shopping_cart_blazor.Services
{
    public class ProductProviderService:IProductProviderService
    {
        private readonly HttpClient httpClient;

        public ProductProviderService(HttpClient _httpClient)
        {
            this.httpClient = _httpClient;
        }

        public async Task<List<Product>> GetProducts()
        {
            //GetFromJsonAsync can be used if the method on the API is GET
            return await httpClient.GetFromJsonAsync<List<Product>>("/posts");
        }

        public async Task<Product> GetProductDetail(int id) 
        {
            return await httpClient.GetFromJsonAsync<Product>($"/posts/" + id ); 
        }

        //public static readonly ImmutableList<Product> Products = ImmutableList.CreateRange(new List<Product>()
        //{
        //    new()
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "All roads lead to Blazor Server",
        //        Description = "A tutorial book for Blazor Server technology",
        //        Price = 70
        //    },
        //    new()
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "All roads lead to Blazor WASM",
        //        Description = "A tutorial book for Blazor WASM technology.",
        //        Price = 70
        //    },
        //    new()
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "gRPC for Blazor WASM",
        //        Description = "A tutorial book for developing a backend for Blazor WASM technology.",
        //        Price = 100
        //    }
        //});
    }
}

