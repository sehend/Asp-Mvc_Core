﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
  public  class AppUser : IdentityUser
    {
        public string City { get; set; }

        public string Picture { get; set; }
        public DateTime? BirthDay { get; set; }
        public int Gender { get; set; }

    }
}
