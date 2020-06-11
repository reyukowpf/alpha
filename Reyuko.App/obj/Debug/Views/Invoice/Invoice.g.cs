﻿#pragma checksum "..\..\..\..\Views\Invoice\Invoice.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5C11166D969E1726DC18C78FB709F839624231995A46269BCE1EF83956D284D0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Xpf.DXBinding;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Reyuko.App.Views.Invoice {
    
    
    /// <summary>
    /// Invoice
    /// </summary>
    public partial class Invoice : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 134 "..\..\..\..\Views\Invoice\Invoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.AutoCompleteBox srcustomer;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\..\Views\Invoice\Invoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbRecap;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\..\Views\Invoice\Invoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbClasification;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\..\Views\Invoice\Invoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtvalue;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\..\Views\Invoice\Invoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRange;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\..\..\Views\Invoice\Invoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbAgingReceivable;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\..\Views\Invoice\Invoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbAnnualinvoice;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\..\..\Views\Invoice\Invoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCurrency;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\..\Views\Invoice\Invoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGInvoice;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/invoice/invoice.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Invoice\Invoice.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 39 "..\..\..\..\Views\Invoice\Invoice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Viewaschart_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 46 "..\..\..\..\Views\Invoice\Invoice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Viewposted_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 53 "..\..\..\..\Views\Invoice\Invoice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.playtutorial_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 74 "..\..\..\..\Views\Invoice\Invoice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NewInvoice_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 82 "..\..\..\..\Views\Invoice\Invoice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Payment_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 90 "..\..\..\..\Views\Invoice\Invoice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Detail_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 98 "..\..\..\..\Views\Invoice\Invoice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Print_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 106 "..\..\..\..\Views\Invoice\Invoice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Refresh_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 114 "..\..\..\..\Views\Invoice\Invoice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.srcustomer = ((System.Windows.Controls.AutoCompleteBox)(target));
            
            #line 134 "..\..\..\..\Views\Invoice\Invoice.xaml"
            this.srcustomer.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.customer_selectedchange);
            
            #line default
            #line hidden
            return;
            case 11:
            this.cbRecap = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.cbClasification = ((System.Windows.Controls.ComboBox)(target));
            
            #line 149 "..\..\..\..\Views\Invoice\Invoice.xaml"
            this.cbClasification.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbClasification_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.txtvalue = ((System.Windows.Controls.TextBox)(target));
            
            #line 150 "..\..\..\..\Views\Invoice\Invoice.xaml"
            this.txtvalue.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Txtvalue_TextChanged);
            
            #line default
            #line hidden
            return;
            case 14:
            this.txtRange = ((System.Windows.Controls.TextBox)(target));
            
            #line 151 "..\..\..\..\Views\Invoice\Invoice.xaml"
            this.txtRange.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtRange_TextChanged);
            
            #line default
            #line hidden
            return;
            case 15:
            this.cbAgingReceivable = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 16:
            this.cbAnnualinvoice = ((System.Windows.Controls.ComboBox)(target));
            
            #line 153 "..\..\..\..\Views\Invoice\Invoice.xaml"
            this.cbAnnualinvoice.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Annualinvoice_selectedchange);
            
            #line default
            #line hidden
            return;
            case 17:
            this.cbCurrency = ((System.Windows.Controls.ComboBox)(target));
            
            #line 154 "..\..\..\..\Views\Invoice\Invoice.xaml"
            this.cbCurrency.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.currency_selectedchange);
            
            #line default
            #line hidden
            return;
            case 18:
            this.DGInvoice = ((System.Windows.Controls.DataGrid)(target));
            
            #line 173 "..\..\..\..\Views\Invoice\Invoice.xaml"
            this.DGInvoice.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DGInvoice_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

