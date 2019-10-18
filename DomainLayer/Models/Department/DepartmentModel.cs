
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Core.Models.Department;

//To keep in mind : let your models derive IOnPropertyChanged interface
//and give them an event EventHandler OnPropertyChanged
//this helps for validations , async validations, database operations, thread safe operations
//such that other operations are locked while the current one is in progress
namespace DomainLayer.Models.Department
{
    public class DepartmentModel : IDepartmentModel//, INotifyPropertyChanged
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
                        
        public string CityLocation {get; set; }

        public string StateLocation { get; set; }        
    }
}
