using EntityFramework_MVCWeb_Abstract_BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_MVCWeb_BusinessAccessLayer.Domain_Models
{
    public class Doctor_BAL : IBusinessDomainModels
    {

            //members
            private string _doctorName;

            public string DoctorName
            {
                get { return _doctorName; }
                set { _doctorName = value; }
            }
            private int _doctorId;

            public int DoctorId
            {
                get { return _doctorId; }
                set { _doctorId = value; }
            }
            private string _doctorCategory;

            public string DoctorCategory
            {
                get { return _doctorCategory; }
                set { _doctorCategory = value; }
            }
            private long _doctorPhoneNo;

            public long DoctorPhoneNo
            {
                get { return _doctorPhoneNo; }
                set { _doctorPhoneNo = value; }
            }

            //behaviours
        
    }
}
