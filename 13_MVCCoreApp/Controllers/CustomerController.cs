﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _13_MVCCoreApp.Controllers
{
    [Route("khach-hang")]
    public class CustomerController : Controller
    {
        [Route("vip")]
        public string Vip()
        {
            return "Khach hang vip";
        }
        [Route("")]
        [Route("normal/{id?}")]
        public string Normal(int id)
        {
            return "Khach hang normal voi id: " + id;
        }
    }
}