﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace Ecom.Repository.Models
{
    public class User : IdentityUser
    {
        public string Role { get; set; } //customer or admin
    }
}