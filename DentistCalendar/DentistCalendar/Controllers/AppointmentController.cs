using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Model;
using Core.Models;
using Core.Repositories;
using Data;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.Services;

namespace DentistCalendar.Controllers
{
    public class AppointmentController : Controller
    {
        //private readonly IRepository<Appointment> _appointment;
        private readonly AppointmentsService service;
        //private AppDbContext _context;
        public AppointmentController(Services.Services.AppointmentsService service)
        {
            //_appointment = repository;
            //   _context = context;
            this.service = service;
        }

        public JsonResult GetAppointments()
        {
            var appointments = service.GetAll().Adapt<AppointmentViewModel>();

            return Json(appointments);
        }

        public JsonResult GetAppointmentsByDentist(string userId="")
        {

            //var appointments = service.GetAll();
            //appo
            var result = service.GetAppointments(userId).Select(x => new AppointmentViewModel()
            {
                Id = x.Id,
                Dentist = x.User.Name + " " + x.User.Surname,
                PatientName = x.PatientName,
                PatientSurname = x.PatientSurname,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                Description = x.Description,
                Color = x.User.Color,
                UserId = x.User.Id
            });
            return Json(result);


            //var model = _context.Appointments.Where(x => x.UserId == userId)
            //  .Include(x => x.User).Select(x => new AppointmentViewModel()
            //  {
            //      Id = x.Id,
            //      Dentist = x.User.Name + " " + x.User.Surname,
            //      PatientName = x.PatientName,
            //      PatientSurname = x.PatientSurname,
            //      StartDate = x.StartDate,
            //      EndDate = x.EndDate,
            //      Description = x.Description,
            //      Color = x.User.Color,
            //      UserId = x.User.Id
            //  });

            //return model;
          
        }

        [HttpPost]
        public JsonResult AddOrUpdateAppointment(AddOrUpdateAppointmentModel model)
        {
            var entity = model.Adapt<Appointment>();

            //service.Update(entity);

            //service.(entity);
            //Validasyon
            if (model.Id == 0)
            {

                var result = model.Adapt<Appointment>();

                service.Save(result);

                //Appointment entity = new Appointment()
                //{
                //    CreatedDate = DateTime.Now,
                //    StartDate = model.StartDate,
                //    EndDate = model.EndDate,
                //    PatientName = model.PatientName,
                //    PatientSurname = model.PatientSurname,
                //    Description = model.Description,
                //    UserId = model.UserId
                //};

                //_context.Add(entity);
                //_context.SaveChanges();
            }
            else
            {
                service.Update(entity);
                //var entity = _context.Appointments.SingleOrDefault(x => x.Id == model.Id);
                //if (entity == null)
                //{
                //    return Json("Güncellenecek veri bulunamadı.");
                //}
                //entity.UpdatedDate = DateTime.Now;
                //entity.PatientName = model.PatientName;
                //entity.PatientSurname = model.PatientSurname;
                //entity.Description = model.Description;
                //entity.StartDate = model.StartDate;
                //entity.EndDate = model.EndDate;
                //entity.UserId = model.UserId;

                //_context.Update(entity);
                //_context.SaveChanges();
            }

            return Json("200");
        }

        public JsonResult DeleteAppointment(int id = 0)
        {
            service.Delete(id);
            //var entity = _context.Appointments.SingleOrDefault(x => x.Id == id);
            //if (entity == null)
            //{
            //    return Json("Kayıt bulunamadı.");
            //}
            //_appointment.Delete(id);
            return Json("200");
        }
    }
}