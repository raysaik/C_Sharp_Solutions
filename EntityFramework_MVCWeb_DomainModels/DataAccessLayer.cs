using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_MVCWeb_DataAccessLayer
{
    public class DataAccessLayer
    {
        //ISSUE: should not be static
        public static CASQLENBEntities db = new CASQLENBEntities(); 

        public DataAccessLayer()
        {
            //db =            
        }

        //ISSUE: should not be static
        public static IEnumerable<DoctorMaster> GetAllDoctorsFromDB()
        {
            return db.DoctorMasters.ToList();
        }


    }
}
