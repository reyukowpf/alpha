﻿#pragma checksum "..\..\..\..\Views\Sales\Sales.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "900B78A6F048D9D48532EE36670C468E566A7668D195268E51933C9DE201E99F"
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


namespace Reyuko.App.Views.Sales {
    
    
    /// <summary>
    /// Sales
    /// </summary>
    public partial class Sales : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 102 "..\..\..\..\Views\Sales\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Typelist;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\Views\Sales\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Editors.SearchControl Contact;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\Views\Sales\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbRecap;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\..\Views\Sales\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCustomerClasification;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\Views\Sales\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtvalue;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\Views\Sales\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRange;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\Views\Sales\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbAnnuality;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\Views\Sales\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCurrency;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\..\Views\Sales\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGSalesDocument;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/sales/sales.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Sales\Sales.xaml"
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
            
            #line 20 "..\..\..\..\Views\Sales\Sales.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NewSalesQuotation_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 21 "..\..\..\..\Views\Sales\Sales.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NewSalesOrder_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 27 "..\..\..\..\Views\Sales\Sales.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Viewaschart_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 34 "..\..\..\..\Views\Sales\Sales.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Viewposted_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 41 "..\..\..\..\Views\Sales\Sales.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.playtutorial_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 63 "..\..\..\..\Views\Sales\Sales.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Detail_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 71 "..\..\..\..\Views\Sales\Sales.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Print_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 79 "..\..\..\..\Views\Sales\Sales.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Refresh_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 87 "..\..\..\..\Views\Sales\Sales.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Typelist = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.Contact = ((DevExpress.Xpf.Editors.SearchControl)(target));
            return;
            case 12:
            this.cbRecap = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 13:
            this.cbCustomerClasification = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 14:
            this.txtvalue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.txtRange = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.cbAnnuality = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 17:
            this.cbCurrency = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 18:
            this.DGSalesDocument = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

