﻿using BethanysPieShopAdmin.Models;

namespace BethanysPieShopAdmin.Data.Repositories
{
    public interface IOrderRepository
    {
        Task<Order?> GetOrderDetailsAsync(int? orderId);
        Task<IEnumerable<Order>> GetAllOrdersWithDetailsAsync();
    }
}
