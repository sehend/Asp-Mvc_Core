using Core;
using Core.Model;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Services
{
    public class AppointmentsService : Service<Core.Model.Appointment>
    {
        public AppointmentsService(IUnitOfWork unitOfWork, IRepository<Appointment> repository) : base(unitOfWork, repository)
        {
        }

        public IEnumerable<Appointment> GetAppointments(string userId)
        {
            var rep = _repository as Data.Repositories.Repository<Appointment>;

            var result = rep._DbSet.Where(a => a.UserId == userId).Include(a => a.User).AsEnumerable();

            return result; 
        }
    }
}
