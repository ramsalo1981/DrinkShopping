﻿using DrinkAndGo.Models;

namespace DrinkAndGo.Data.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
