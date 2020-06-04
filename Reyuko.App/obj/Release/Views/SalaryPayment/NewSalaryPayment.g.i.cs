﻿#pragma checksum "..\..\..\..\Views\SalaryPayment\NewSalaryPayment.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EBB9DA5D1623793DDF4F540BBED4E3A175F71F0FB936321653554FAB629416FD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Core;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.ConditionalFormatting;
using DevExpress.Xpf.Core.DataSources;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Core.ServerMode;
using DevExpress.Xpf.DXBinding;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Editors.DataPager;
using DevExpress.Xpf.Editors.DateNavigator;
using DevExpress.Xpf.Editors.ExpressionEditor;
using DevExpress.Xpf.Editors.Filtering;
using DevExpress.Xpf.Editors.Flyout;
using DevExpress.Xpf.Editors.Popups;
using DevExpress.Xpf.Editors.Popups.Calendar;
using DevExpress.Xpf.Editors.RangeControl;
using DevExpress.Xpf.Editors.Settings;
using DevExpress.Xpf.Editors.Settings.Extension;
using DevExpress.Xpf.Editors.Validation;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.ConditionalFormatting;
using DevExpress.Xpf.Grid.LookUp;
using DevExpress.Xpf.Grid.TreeList;
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


namespace Reyuko.App.Views.SalaryPayment {
    
    
    /// <summary>
    /// NewSalaryPayment
    /// </summary>
    public partial class NewSalaryPayment : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 84 "..\..\..\..\Views\SalaryPayment\NewSalaryPayment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCashAccount;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\Views\SalaryPayment\NewSalaryPayment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSalaryAccount;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\Views\SalaryPayment\NewSalaryPayment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTaxAccount;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\Views\SalaryPayment\NewSalaryPayment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Editors.SearchControl IDstaff;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\Views\SalaryPayment\NewSalaryPayment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtTotalPaymentValue;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\Views\SalaryPayment\NewSalaryPayment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGSalaryPayment;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/salarypayment/newsalarypayment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\SalaryPayment\NewSalaryPayment.xaml"
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
            
            #line 25 "..\..\..\..\Views\SalaryPayment\NewSalaryPayment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.saveasdraft_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 32 "..\..\..\..\Views\SalaryPayment\NewSalaryPayment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.importfile_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 39 "..\..\..\..\Views\SalaryPayment\NewSalaryPayment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.playtutorial_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 60 "..\..\..\..\Views\SalaryPayment\NewSalaryPayment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveNewsalaryPayment_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 68 "..\..\..\..\Views\SalaryPayment\NewSalaryPayment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cbCashAccount = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.cbSalaryAccount = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.cbTaxAccount = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.IDstaff = ((DevExpress.Xpf.Editors.SearchControl)(target));
            return;
            case 10:
            this.txtTotalPaymentValue = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.DGSalaryPayment = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

