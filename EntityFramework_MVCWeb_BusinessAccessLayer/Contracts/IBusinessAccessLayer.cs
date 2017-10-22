using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework_MVCWeb_BusinessAccessLayer.Domain_Models;

namespace EntityFramework_MVCWeb_BusinessAccessLayer.Contracts
{
    public interface IBusinessAccessLayer
    {
        IEnumerable<Doctor_BAL> GetAllDoctors();
    }
}
