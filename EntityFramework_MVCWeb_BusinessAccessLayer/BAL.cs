using EntityFramework_MVCWeb_BusinessAccessLayer.Contracts;
using EntityFramework_MVCWeb_BusinessAccessLayer.Domain_Models;
using EntityFramework_MVCWeb_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_MVCWeb_BusinessAccessLayer
{
    public class BAL : IBusinessAccessLayer
    {
        public IEnumerable<Doctor_BAL> GetAllDoctors()
        {
            IEnumerable<DoctorMaster> docMasters =  DataAccessLayer.GetAllDoctorsFromDB();
            List<Doctor_BAL> docBalList = new List<Doctor_BAL>();
            Doctor_BAL docBal = null;
            foreach (DoctorMaster dm in docMasters)
            {
                docBal = new Doctor_BAL();
                docBal.DoctorName = dm.DoctorName;
                docBal.DoctorId = dm.DoctorId;
                docBal.DoctorCategory = dm.Specialist;
                long phone;
                docBal.DoctorPhoneNo = long.TryParse(dm.Phone, out phone) ? phone : 0;
                docBalList.Add(docBal);
            }
            return docBalList;
        }
    }
}
