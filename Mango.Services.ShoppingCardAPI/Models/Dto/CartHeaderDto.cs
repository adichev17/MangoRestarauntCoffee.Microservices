﻿namespace Mango.Services.ShoppingCardAPI.Models.Dto
{
    public class CartHeaderDto
    {
        public int CartHeaderId { get; set; }
        public string UserId { get; set; }
        public string? CouponCode { get; set; } = null;
    }
}
