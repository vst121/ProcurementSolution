namespace Procurement.Events
{
    public class OrderCreatedEvent
    {
        public Guid OrderId { get; set; }
        public string OrderNumber { get; set; }
        public Guid CustomerId { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class OrderUpdatedEvent
    {
        public Guid OrderId { get; set; }
        public Procurement.Domain.OrderStatus OldStatus { get; set; }
        public Procurement.Domain.OrderStatus NewStatus { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class OrderCancelledEvent
    {
        public Guid OrderId { get; set; }
        public string Reason { get; set; }
        public DateTime CancelledAt { get; set; }
    }
}