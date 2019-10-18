using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonComponents.UnitTesting
{
    public class DataAccesException : Exception
    {
        private DataAccessStatus _dataAccessStatus;

        public DataAccessStatus DataAccessStatusInfo 
        {
            get { return _dataAccessStatus; }
            set { _dataAccessStatus = value; } 
        }

        public DataAccesException()
        {

        }

        public DataAccesException(DataAccessStatus dataAccessStatus)
        {
            _dataAccessStatus = dataAccessStatus;
        }

        public DataAccesException(string message, Exception innerException, DataAccessStatus dataAccessStatus) 
            : base(message, innerException)
        {
           
        }
    }
}
