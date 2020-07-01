using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Reyuko.App
{
    public class Room : INotifyPropertyChanged
    {
        public string strRoomlName;
        public string NamaRekeningPerkiraan
        {
            get { return strRoomlName; }
            set { strRoomlName = value; }
        }
        public IEnumerable<RekeningPerkiraan> tbTables;
        public IEnumerable<RekeningPerkiraan> PrpTables
        {
            get { return tbTables; }
            set
            {
                tbTables = value;
                OnPropertyChanged("PrRawValues");
             //   if (value != null && value.Count > 0)
               // {
              //      PrpSelectedTable = value.First();
              //  }
            }
        }
        private RekeningPerkiraan selectedTable;
        public RekeningPerkiraan PrpSelectedTable
        {
            get
            {
                return selectedTable;
            }
            set
            {
                selectedTable = value;
                OnPropertyChanged("PrpSelectedTable");
                ComboValue = value.Id;
                OnPropertyChanged("ComboValue");
            }
        }
        public int ComboValue
        {
            get;
            set;
        }
        public Room()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.tbTables = uow.RekeningPerkiraan.GetAll();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}