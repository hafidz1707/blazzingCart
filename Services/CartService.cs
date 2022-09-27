using System;
namespace shopping_cart_blazor.Services
{
    public class CartService
    {
        //store the product which are selected by user
        public List<Models.Product> SelectedItems { get; set; } = new();

        //add method to add a product to the cart
        //this method will be invoked when the user pressed buy button
        //public void AddProductToCart(int productId)
        //{
        //    var product = ProductProviderService.Products.First(idProduct => idProduct.Id == productId);

        //    if (SelectedItems.Contains(product) is false)
        //    {
        //        SelectedItems.Add(product);
        //    }

        //}
    }
}

