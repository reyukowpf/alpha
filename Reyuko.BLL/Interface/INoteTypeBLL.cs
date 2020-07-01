using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface INoteTypeBLL
    {
        int AddNoteType(NoteType oData);
        bool EditNoteType(NoteType oData);
        bool RemoveNoteType(int id);

    }
}
