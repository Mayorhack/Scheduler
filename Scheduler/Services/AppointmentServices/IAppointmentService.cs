using Scheduler.Dto.Appointment;
using Scheduler.Models;


namespace Scheduler.Services.AppointmentServices
{
    public interface IAppointmentService
    {
        Task<ResponseService<List<GetAppointmentDto>>> GetAllAppointments();
        Task<ResponseService<GetAppointmentDto>> GetAppointmentById(int id);
        Task<ResponseService<List<GetAppointmentDto>>> CreateAppointment(AddAppointmentDto newAppointment);
        Task<ResponseService<List<GetAppointmentDto>>> UpdateAppointment(UpdatedAppointmentDto updatedAppointment);
        Task<ResponseService<List<GetAppointmentDto>>> DeleteAppointment(int id);

    }
}
