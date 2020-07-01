using System.Data.Entity;
using Reyuko.DAL.Interface;
using Reyuko.Utils;

namespace Reyuko.DAL
{
    public class DBTransaction : IDBTransaction
    {
        private DbContextTransaction _transaction;
        public DBTransaction(ReyukoContext context, System.Data.IsolationLevel isolationLevel = System.Data.IsolationLevel.Snapshot)
        {
            string contextName = AppConfig.Current.ContextName;
            if (contextName.ToLower() == "localcontext")
            {
                _transaction = context.Database.BeginTransaction();
            }
            else
            {
                _transaction = context.Database.BeginTransaction(isolationLevel);
            }
        }

        public void Commit()
        {
            _transaction.Commit();
        }

        public void Rollback()
        {
            _transaction.Rollback();
        }

        public void Dispose()
        {
            _transaction.Dispose();
        }

    }
}
