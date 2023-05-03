namespace Scheduler.Dto.Appointment
{
    public class AddAppointmentDto
    {
   
        public string Title { get; set; } = "New Appointment";
        public string? Description { get; set; }
        public DateTime AppointmentDate { get; set; } = DateTime.Now;
    }
}
