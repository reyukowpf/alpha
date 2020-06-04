using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace Reyuko.App
{
    public class Item
    {
        public Item(string value1, string value2, string value3)
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
    }

    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private bool _dateColumnChecked;
        private bool _refrenceColumnChecked;
        private bool _deskripsiColumnChecked;
        private bool _departmenColumnChecked;
        private bool _projectColumnChecked;
        private bool _currencyColumnChecked;
        private bool _debitColumnChecked;
        private bool _creditColumnChecked;
        private bool _lokasiColumnChecked;
        private bool _customerColumnChecked;
        private bool _salarypaymentColumnChecked;
        private bool _employeeColumnChecked;
        private bool _basicColumnChecked;
        private bool _allowanceColumnChecked;
        private bool _totalovertimeColumnChecked;
        private bool _otherColumnChecked;
        private bool _taxColumnChecked;
        private bool _noteColumnChecked;
        private bool _bankdataColumnChecked;
        private bool _totalColumnChecked;

        public MainWindowViewModel()
        {
        }

        public bool DateColumnChecked
        {
            get { return _dateColumnChecked; }
            set
            {
                _dateColumnChecked = value;
                OnPropertyChanged(nameof(DateColumnChecked));
            }
        }
        public bool ReferenceColumnChecked
        {
            get { return _refrenceColumnChecked; }
            set
            {
                _refrenceColumnChecked = value;
                OnPropertyChanged(nameof(ReferenceColumnChecked));
            }
        }
        public bool DeskripsiColumnChecked
        {
            get { return _deskripsiColumnChecked; }
            set
            {
                _deskripsiColumnChecked = value;
                OnPropertyChanged(nameof(DeskripsiColumnChecked));
            }
        }
        public bool DepartmenColumnChecked
        {
            get { return _departmenColumnChecked; }
            set
            {
                _departmenColumnChecked = value;
                OnPropertyChanged(nameof(DepartmenColumnChecked));
            }
        }
        public bool ProjectColumnChecked
        {
            get { return _projectColumnChecked; }
            set
            {
                _projectColumnChecked = value;
                OnPropertyChanged(nameof(ProjectColumnChecked));
            }
        }
        public bool CurrencyColumnChecked
        {
            get { return _currencyColumnChecked; }
            set
            {
                _currencyColumnChecked = value;
                OnPropertyChanged(nameof(CurrencyColumnChecked));
            }
        }
        public bool DebitColumnChecked
        {
            get { return _debitColumnChecked; }
            set
            {
                _debitColumnChecked = value;
                OnPropertyChanged(nameof(DebitColumnChecked));
            }
        }
        public bool KreditColumnChecked
        {
            get { return _creditColumnChecked; }
            set
            {
                _creditColumnChecked = value;
                OnPropertyChanged(nameof(KreditColumnChecked));
            }
        }
        public bool LokasiColumnChecked
        {
            get { return _lokasiColumnChecked; }
            set
            {
                _lokasiColumnChecked = value;
                OnPropertyChanged(nameof(LokasiColumnChecked));
            }
        }
        public bool SalaryPaymentColumnChecked
        {
            get { return _salarypaymentColumnChecked; }
            set
            {
                _salarypaymentColumnChecked = value;
                OnPropertyChanged(nameof(SalaryPaymentColumnChecked));
            }
        }
        public bool EmployeeColumnChecked
        {
            get { return _employeeColumnChecked; }
            set
            {
                _employeeColumnChecked = value;
                OnPropertyChanged(nameof(EmployeeColumnChecked));
            }
        }
        public bool BasicColumnChecked
        {
            get { return _basicColumnChecked; }
            set
            {
                _basicColumnChecked = value;
                OnPropertyChanged(nameof(BasicColumnChecked));
            }
        }
        public bool AllowanceColumnChecked
        {
            get { return _allowanceColumnChecked; }
            set
            {
                _allowanceColumnChecked = value;
                OnPropertyChanged(nameof(AllowanceColumnChecked));
            }
        }
        public bool TotalovertimeColumnChecked
        {
            get { return _totalovertimeColumnChecked; }
            set
            {
                _totalovertimeColumnChecked = value;
                OnPropertyChanged(nameof(TotalovertimeColumnChecked));
            }
        }
        public bool OthersColumnChecked
        {
            get { return _otherColumnChecked; }
            set
            {
                _otherColumnChecked = value;
                OnPropertyChanged(nameof(OthersColumnChecked));
            }
        }
        public bool TaxColumnChecked
        {
            get { return _taxColumnChecked; }
            set
            {
                _taxColumnChecked = value;
                OnPropertyChanged(nameof(TaxColumnChecked));
            }
        }
        public bool NoteColumnChecked
        {
            get { return _noteColumnChecked; }
            set
            {
                _noteColumnChecked = value;
                OnPropertyChanged(nameof(NoteColumnChecked));
            }
        }
        public bool BankDataColumnChecked
        {
            get { return _bankdataColumnChecked; }
            set
            {
                _bankdataColumnChecked = value;
                OnPropertyChanged(nameof(BankDataColumnChecked));
            }
        }
        public bool TotalColumnChecked
        {
            get { return _totalColumnChecked; }
            set
            {
                _totalColumnChecked = value;
                OnPropertyChanged(nameof(TotalColumnChecked));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            VerifyPropertyName(propertyName);
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [Conditional("DEBUG")]
        private void VerifyPropertyName(string propertyName)
        {
            if (TypeDescriptor.GetProperties(this)[propertyName] == null)
                throw new ArgumentNullException(GetType().Name + " does not contain property: " + propertyName);
        }
    }
}