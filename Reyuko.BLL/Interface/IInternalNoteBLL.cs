using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IInternalNoteBLL
    {
        int AddInternalNote(InternalNote oData);
        bool EditInternalNote(InternalNote oData);
        bool RemoveInternalNote(int id);

    }
}
