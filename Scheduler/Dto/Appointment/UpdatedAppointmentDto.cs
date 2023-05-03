namespace Scheduler.Dto.Appointment
{
    public class UpdatedAppointmentDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = "New Appointment";
        public string? Description { get; set; }

        public DateTime AppointmentDate { get; set; } = DateTime.Now;
    }
}
