﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ejemploRezorPages.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; } 
        [TempData]
        public string Nombre { get; set; }

        public void OnGet(int id)
        {
            Message = "Your contact page. id = " + id.ToString();
        }
    }
}
