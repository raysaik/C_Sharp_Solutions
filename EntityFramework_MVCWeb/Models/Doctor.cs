using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using EntityFramework_MVCWeb_BusinessAccessLayer.Domain_Models;

namespace EntityFramework_MVCWeb.Models
{
    public class Doctors
    {
        //members
        private IEnumerable<Doctor_BAL> doctors;

        public IEnumerable<Doctor_BAL> DoctorsBAL
        {
            get { return doctors; }
            set { doctors = value; }
        }
        //private string _doctorName;

        //[Display(Name="Doctor Name",Description="This is the doctors name")]
        //public string DoctorName
        //{
        //    get { return _doctorName; }
        //    set { _doctorName = value; }
        //}
        //private int _doctorId;

        //[Display(Name = "Doctor Id")]
        //public int DoctorId
        //{
        //    get { return _doctorId; }
        //    set { _doctorId = value; }
        //}
        //private string _doctorCategory;

        //[Display(Name = "Category")]
        //public string DoctorCategory
        //{
        //    get { return _doctorCategory; }
        //    set { _doctorCategory = value; }
        //}
        //private long _doctorPhoneNo;

        //[Display(Name = "Contact No")]
        //public long DoctorPhoneNo
        //{
        //    get { return _doctorPhoneNo; }
        //    set { _doctorPhoneNo = value; }
        //}

        //behaviours
    }
}