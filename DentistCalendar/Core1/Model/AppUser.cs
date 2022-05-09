using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core1.Model
{
  public  class AppUser
    {
        public bool IsDentist { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Color { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
