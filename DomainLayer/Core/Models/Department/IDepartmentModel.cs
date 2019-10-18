using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Core.Models.Department
{
    public interface IDepartmentModel
    {     
        int ID { get; set; }
        string Name { get; set; }
        string Url { get; set; }
        string PhoneNumber { get; set; }
        string Email { get; set; }
        string CityLocation { get; set; }
        string StateLocation { get; set; }

    }
}
