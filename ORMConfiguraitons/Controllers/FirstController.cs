using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ORMConfiguraitons.Models;

namespace ORMConfiguraitons.Controllers
{
    public class FirstController : Controller
    {
        public April2018MVCContext ORM = null;
        public FirstController(April2018MVCContext _ORM)
        {
            ORM = _ORM;
        }


        public IActionResult Index()
        {
           
            return View();
        }

        [HttpGet]
        public IActionResult CreateStudent()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateStudent(Students S)
        {
            ORM.Students.Add(S);
            ORM.SaveChanges();

            ViewBag.Message = "Student Saved Successfully";
            return View();
        }

        [HttpGet]
        public IActionResult CreateTeacher()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateTeacher(Teacher S)
        {
            ORM.Teacher.Add(S);
            ORM.SaveChanges();
            return View();
        }


    }
}