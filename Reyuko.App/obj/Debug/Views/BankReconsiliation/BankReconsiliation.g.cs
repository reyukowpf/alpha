﻿#pragma checksum "..\..\..\..\Views\BankReconsiliation\BankReconsiliation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5FA9F9916CAF8B243749D60687CC72EB458CFA153DF7A9EE526DA2A2BABDBCC8"
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


namespace Reyuko.App.Views.BankReconsiliation {
    
    
    /// <summary>
    /// BankReconsiliation
    /// </summary>
    public partial class BankReconsiliation : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 92 "..\..\..\..\Views\BankReconsiliation\BankReconsiliation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbAccountcode;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\Views\BankReconsiliation\BankReconsiliation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtaccountbalance;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\Views\BankReconsiliation\BankReconsiliation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGReconsiliation;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\..\Views\BankReconsiliation\BankReconsiliation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGBankReconsiliation;
        
        #line default
        #line hidden
        
        
        #line 313 "..\..\..\..\Views\BankReconsiliation\BankReconsiliation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGAnalysis;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/bankreconsiliation/bankreconsiliation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\BankReconsiliation\BankReconsiliation.xaml"
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
            
            #line 41 "..\..\..\..\Views\BankReconsiliation\BankReconsiliation.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.playtutorial_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 62 "..\..\..\..\Views\BankReconsiliation\BankReconsiliation.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Adjusment_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 69 "..\..\..\..\Views\BankReconsiliation\BankReconsiliation.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AutoReconsiliation_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 76 "..\..\..\..\Views\BankReconsiliation\BankReconsiliation.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Reconsiliation_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 83 "..\..\..\..\Views\BankReconsiliation\BankReconsiliation.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Refresh_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cbAccountcode = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.txtaccountbalance = ((System.Windows.Controls.TextBox)(target));
            
            #line 94 "..\..\..\..\Views\BankReconsiliation\BankReconsiliation.xaml"
            this.txtaccountbalance.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Txtaccountbalance_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DGReconsiliation = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.DGBankReconsiliation = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.DGAnalysis = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

