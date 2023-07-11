﻿using Microsoft.AspNetCore.Mvc;
using VacationSplit.Models;
using VacationSplit.Services;

namespace VacationSplit.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(User user)
        {
            SecurityService securityService = new SecurityService();

            if (securityService.IsValid(user)) 
            {
                return View("LoginSuccess", user);
            } else 
            {
                return View("LoginFailure", user);
            }
            
        }

    }
}
