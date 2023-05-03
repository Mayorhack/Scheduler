using Microsoft.AspNetCore.Mvc;
using Scheduler.Dto.Appointment;
using Scheduler.Models;
using Scheduler.Services.AppointmentServices;

namespace Scheduler.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {

        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }


        public IAppointmentService AppointmentService { get; }

        [HttpGet("getAll")]
        public async Task<ActionResult<ResponseService<Appointment>>> GetAll()
        {
            return  Ok(await _appointmentService.GetAllAppointments());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseService<Appointment>>> Get(int id)
        {

            var data = await _appointmentService.GetAppointmentById(id);
            if(data.Data == null) {
                return NotFound(data);            
            }
            return Ok(data);
        }
        [HttpPost]
        public async Task<ActionResult<ResponseService<Appointment>>> Post(AddAppointmentDto appointment) {

  
            return Ok(await _appointmentService.CreateAppointment(appointment));
        
        
        }
        [HttpPut]
        public async Task<ActionResult<ResponseService<List<Appointment>>>> Update(UpdatedAppointmentDto appointment)
        {
            var data = await _appointmentService.UpdateAppointment(appointment);
            if (data.Data == null) {
               return NotFound(data);
            }
            return Ok(data);
        }
        [HttpDelete]
        public async Task<ActionResult<ResponseService<List<Appointment>>>> Delete(int id)
        {
            var data = await _appointmentService.DeleteAppointment(id);
           
            if (data.Data == null)
            {
               return NotFound(data);
            }
            return Ok(data);
        }

    }
}
