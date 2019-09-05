using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo.Models;

namespace Todo.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodoContext _context;
        public TodoController(TodoContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}