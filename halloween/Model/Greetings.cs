using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace halloween.wwwroot.Model
{
    public class Greetings
    {
        [DisplayName("Your friend's name")]
        [Display(Prompt = "Your friend's name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "You must enter between 3 to 100 characters")]
        public string receiverName { get; set; }

        [DisplayName("Your friend's email")]
        [Display(Prompt = "username@domain.com")]
        [Required(ErrorMessage = "Required")]
        public string receiverEmail { get; set; }

        [DisplayName("Subject")]
        [Required(ErrorMessage = "Required")]
        public string subject { get; set; }

        [DisplayName("Personalized Message")]
        [Required(ErrorMessage = "Required")]
        public string message { get; set; }

        [DisplayName("Sender's Name")]
        [Required(ErrorMessage = "Required")]
        public string senderName { get; set; }

        [DisplayName("Sender's Email")]
        [Required(ErrorMessage = "Required")]
        public string senderEmail { get; set; }

        [Required(ErrorMessage = "Required")]
        public string agree { get; set; }

        [Required(ErrorMessage = "Required")]
        public string createDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public string createIP { get; set; }

        public string sendDate { get; set; }
        public string sendIP { get; set; }

    }
}
