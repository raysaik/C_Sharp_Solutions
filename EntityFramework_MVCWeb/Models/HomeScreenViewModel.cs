using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework_MVCWeb.Models
{
    public class HomeScreenViewModel
    {
        public HomeScreenViewModel(Doctors newDoc)
        {
            this.doctors = newDoc;
        }
        public Doctors doctors
        {
            get;
            set;
        }
    }
}