using System;

namespace shop_app.entity;

public class ProductOrder
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
    public Guid OrderId { get; set; }
    public Order Order { get; set; }
    public int Amount { get; set; }
}