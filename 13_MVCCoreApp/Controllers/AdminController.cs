    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    namespace _13_MVCCoreApp.Controllers
    {
        public class AdminController : Controller
        {
            public string Index() => "Hello from Index method of Admin Controller";
        }
    }