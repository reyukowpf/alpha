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
   public class model1 : INotifyPropertyChanged
    {
        public IEnumerable<produk> _persons;

        public IEnumerable<produk> Persons
        {
            get { return _persons; }
            set { _persons = value; }
        }

        public produk _sperson;

        public produk SPerson
        {
            get { return _sperson; }
            set { _sperson = value;
                OnPropertyChanged("SPerson");
                if (this._sperson != value )
                {
                    this._sperson = value;
        //            PrpSelectedTable = value.First();
                }
            }
        }
        private produk selectedTable;
      
        public produk PrpSelectedTable
        {
            get
            {
                return selectedTable;
            }
            set
            {
                selectedTable = value;
                OnPropertyChanged("PrpSelectedTable");
                ComboValue = value.IdProduk;
                OnPropertyChanged("ComboValue");
            }
        }
        public int ComboValue
        {
            get;
            set;
        }
        public model1()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.Persons = uow.produk.GetAll();                
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
