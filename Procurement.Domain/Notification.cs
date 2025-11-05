namespace Procurement.Domain
{
    public class Notification
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public NotificationType Type { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }
        public NotificationChannel Channel { get; set; }
    }

    public enum NotificationType
    {
        OrderCreated,
        OrderUpdated,
        OrderCancelled,
        OrderShipped,
        OrderDelivered
    }

    public enum NotificationChannel
    {
        Email,
        InApp,
        Push
    }
}