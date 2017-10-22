using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework_MVCWeb_DataAccessLayer;

namespace EntityFramework_MVCWeb_Abstract_BusinessAccessLayer
{
    public interface IBusinessAccessLayer
    {
        //members
        DoctorMaster _DocMaster { get; set; }

        //behaviours
        IEnumerable<DoctorMaster> GetAllDoctors();
        
    }
}
