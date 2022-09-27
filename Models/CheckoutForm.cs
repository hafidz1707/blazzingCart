using System;
using System.ComponentModel.DataAnnotations;

namespace shopping_cart_blazor.Models
{
    public class CheckoutForm
    {
        //create validation when user checkout or buy some product
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = "";
        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; } = "";
    }
}

