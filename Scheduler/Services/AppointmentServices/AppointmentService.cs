using AutoMapper;
using Scheduler.Dto.Appointment;
using Scheduler.Models;

namespace Scheduler.Services.AppointmentServices
{
    public class AppointmentService : IAppointmentService
    {
        private static List<Appointment> appointments = new List<Appointment> {

            new Appointment(),
            new Appointment{Description="Balabu", Id=1}
        };
       
      
        private readonly IMapper _mapper;
        
        static int nextId = 2;
        public AppointmentService(IMapper mapper) {
            _mapper = mapper;
        }
        public async Task<ResponseService<List<GetAppointmentDto>>> CreateAppointment(AddAppointmentDto newAppointment)
        {
            var  responseService= new ResponseService<List<GetAppointmentDto>>();
            Appointment appointment = _mapper.Map<Appointment>(newAppointment);
            appointment.Id = nextId++;
            appointments.Add(_mapper.Map<Appointment>(appointment));
            responseService.Data = (appointments.ConvertAll(c => _mapper.Map<GetAppointmentDto>(c)));
           
            return  responseService;
        }

        public async Task<ResponseService<List<GetAppointmentDto>>> GetAllAppointments()
        {
            return new ResponseService<List<GetAppointmentDto>> { Data=appointments.ConvertAll(c => _mapper.Map<GetAppointmentDto>(c)) };
        }

        public async Task<ResponseService<GetAppointmentDto>> GetAppointmentById(int id)
        {


            var responsService = new ResponseService<GetAppointmentDto>();
            try 
            {
                Appointment appointment = appointments.FirstOrDefault(c => c.Id == id) ?? throw new Exception("Cannot find appointment");
                responsService.Data = _mapper.Map<GetAppointmentDto>(appointment);
            } catch(Exception ex) {
                responsService.Message = ex.Message;
                responsService.Success = false;
            }
            return responsService;
        }

        public async Task<ResponseService<List<GetAppointmentDto>>> UpdateAppointment(UpdatedAppointmentDto updatedAppointmentDto)
        {
            var responsService = new ResponseService<List<GetAppointmentDto>>();

            try {
                Appointment appointment = appointments.FirstOrDefault(a => a.Id == updatedAppointmentDto.Id) ?? throw new Exception("Appointment not found");
                appointment = _mapper.Map(updatedAppointmentDto, appointment);
                responsService.Data = appointments.ConvertAll(a => _mapper.Map<GetAppointmentDto>(a));
            }
            catch(Exception ex) { 
                responsService.Success = false;
                responsService.Message = ex.Message;
            }
            return responsService;
        }

        public async Task<ResponseService<List<GetAppointmentDto>>> DeleteAppointment(int id)
        {
            var responsService = new ResponseService<List<GetAppointmentDto>>();
            try {
                var removedAppointment = appointments.FirstOrDefault(c => c.Id == id);
                if (removedAppointment != null) {
                    appointments.Remove(removedAppointment);
                    responsService.Data = appointments.ConvertAll(a => _mapper.Map<GetAppointmentDto>(a));
                }
                throw new Exception("Appointment Not found");
            }
            catch(Exception ex) {
                responsService.Success = false;
                responsService.Message = ex.Message;
            }
            return responsService;

        }
    }
}
