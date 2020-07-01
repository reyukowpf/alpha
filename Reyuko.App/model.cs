using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.App.Views.AccountingPeriod;

namespace Reyuko.App
{
   public class model : INotifyPropertyChanged
    {
        public IEnumerable<RekeningPerkiraan> tbTables;

        public IEnumerable<RekeningPerkiraan> PrpTables
        {
            get { return tbTables; }
            set
            {
                tbTables = value;
                OnPropertyChanged("PrRawValues");
                if (value != null)
                {
                    //     PrpSelectedTable = value.First();
                }
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
                ComboValue = value.NamaRekeningPerkiraan;
                OnPropertyChanged("ComboValue");
            }
        }
        public string ComboValue
        {
            get;
            set;
        }
        public model()
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
