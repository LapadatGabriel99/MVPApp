using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Core;
using RepositoryLayer.Core.Repository.DepartmentRepository;
using RepositoryLayer.Persistence.Repository.DepartmentRepository;

namespace RepositoryLayer.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public IDataTransaction Transaction { get; set; }
        public IDepartmentRepository Departments { get; set; }

        private readonly Context _context;

        public UnitOfWork(Context context)
        {
            _context = context;
            Transaction = new DataTransaction(_context);
            Departments = new DepartmentRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
