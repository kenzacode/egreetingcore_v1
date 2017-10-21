using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using halloween.wwwroot.Model;

namespace halloween.Pages
{
    public class IndexModel : PageModel
    {
        //DEFAULT MODE
        public void OnGet()
        {
            isPreviewPage = false;
        }

        //PREVIEW MODE (AFTER SUBMITTING)
        public void OnPost()
        {
            isPreviewPage = true;
        }

        //BRIDGE TO GREETING MODEL
        [BindProperty]
        public Greetings bridgeGreetings { get; set; }

        //TEST IF USER IS LOOKING AT PREVIEW OR FORM
        public bool isPreviewPage { get; set; }


    }

}

