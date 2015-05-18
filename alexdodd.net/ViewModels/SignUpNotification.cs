using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using alexdodd.net.Models;

namespace alexdodd.net.ViewModels
{
    public class SignUpNotification
    {
        public string UniqueEmail { get; set; }
        public string NonUniqueEmail { get; set; }
    }
}