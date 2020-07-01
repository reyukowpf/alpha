using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IDataMataUangBLL
    {
        int AddMataUang(DataMataUang oData);
        bool EditMataUang(DataMataUang oData);
        bool RemoveMataUang(int id);

        int AddKurs(KursMataUang oData);
        bool EditKurs(KursMataUang oData);
        bool RemoveKurs(int id);



    }
}
