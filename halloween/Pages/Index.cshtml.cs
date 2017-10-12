using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace halloween.Pages
{
    public class IndexModel : PageModel
    {   [BindProperty]
        public string name { get; set; }
        [BindProperty]
        public string sendto { get; set; }
        [BindProperty]
        public string from { get; set; }
        [BindProperty]
        public string subject { get; set; }
        [BindProperty]
        public string message { get; set; }
        

        public void OnGet()
        {

        }

        public void OnPost()
        {
            
        }
    }
}

