namespace Cheeseman.Models.TPL.Schedule
{
    public class ScheduleStatusModel
    {
        public enum StatusCode { PENDING, ACCEPTED, REJECTED, CANCELLED }

        public long BOOKING_ID { get; set; } = 0;

        public StatusCode STATUS { get; set; } = StatusCode.PENDING;

        public string? BILL_NUMBER { get; set; } = null;
    }
}