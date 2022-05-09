using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class AppointmentRepository : Repository<Appointment>
    {
        public AppointmentRepository(AppDbContext context) : base(context)
        {
        }
    }   

}
