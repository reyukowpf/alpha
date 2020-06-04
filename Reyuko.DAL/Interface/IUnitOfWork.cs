namespace Reyuko.DAL.Interface
{
    public interface IUnitOfWork
    {
        void Save();
        IDBTransaction BeginTransaction(System.Data.IsolationLevel isolationLevel = System.Data.IsolationLevel.Snapshot);
    }
}
