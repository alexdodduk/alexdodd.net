using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace alexdodd.net.Models
{
    public class EmailSignUp
    {
        public int ID { get; set; }

        [Required(ErrorMessage="PROTIP: Try entering something into the textbox before hitting \"Sign up\"")]
        [EmailAddress(ErrorMessage="That... doesn't look like an email address. Try adding an '@' or two")]
        public string Email { get; set; }
    }
}