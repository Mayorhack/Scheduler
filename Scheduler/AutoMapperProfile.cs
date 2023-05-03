using AutoMapper;
using Scheduler.Dto.Appointment;
using Scheduler.Models;

namespace Scheduler
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Appointment, GetAppointmentDto>();
            CreateMap<AddAppointmentDto, Appointment>();
            CreateMap<UpdatedAppointmentDto, Appointment>();
        }
    }
}
