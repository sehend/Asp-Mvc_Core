﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class AppointmentViewModel
    {
        public AppointmentViewModel()
        {
        }

        public int Id { get; set; }
        public string Dentist { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string UserId { get; set; }
    }
}
