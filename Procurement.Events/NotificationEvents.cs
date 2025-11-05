namespace Procurement.Events
{
    public class NotificationSentEvent
    {
        public Guid NotificationId { get; set; }
        public Guid UserId { get; set; }
        public Procurement.Domain.NotificationType Type { get; set; }
        public Procurement.Domain.NotificationChannel Channel { get; set; }
        public DateTime SentAt { get; set; }
    }
}