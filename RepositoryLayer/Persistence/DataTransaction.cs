using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Core;
using System.Data.Entity;

namespace RepositoryLayer.Persistence
{
    public class DataTransaction : IDataTransaction
    {
        private readonly DbContextTransaction _trasaction;

        public DataTransaction(Context context)
        {
            _trasaction = context.Database.BeginTransaction();
        }

        public void Commit()
        {
            _trasaction.Commit();
        }

        public void Dispose()
        {
            _trasaction.Dispose();
        }

        public void RollBack()
        {
            _trasaction.Rollback();
        }
    }
}
