using System;

namespace Reyuko.DAL.Interface
{
    public interface IDBTransaction : IDisposable
    {
        void Commit();
        void Rollback();
    }
}
