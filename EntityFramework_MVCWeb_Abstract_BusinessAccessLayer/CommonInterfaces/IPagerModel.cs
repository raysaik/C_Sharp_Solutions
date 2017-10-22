using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_MVCWeb_Abstract_BusinessAccessLayer.CommonInterfaces
{
    public interface IPagerModel
    {
        int TotalPages { get; set; }
        int CurrentPage { get; set; }

        void GoToFirstPage(IBusinessDomainModels domainModel);
        void GoToPreviousPage(IBusinessDomainModels domainModel, ref int currentPage);
        void GoToNextPage(IBusinessDomainModels domainModel, ref int currentPage);
        void GoToLastPage(IBusinessDomainModels domainModel, ref int currentPage);
    }
}
