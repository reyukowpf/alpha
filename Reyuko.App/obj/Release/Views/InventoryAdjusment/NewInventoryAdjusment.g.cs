﻿#pragma checksum "..\..\..\..\Views\InventoryAdjusment\NewInventoryAdjusment.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D1C69BFB8EFEC020B2A8F07CA205A3C1ECD72FED19D3CF84E298F7A652D7CEC7"
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


namespace Reyuko.App.Views.InventoryAdjusment {
    
    
    /// <summary>
    /// NewInventoryAdjusment
    /// </summary>
    public partial class NewInventoryAdjusment : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 96 "..\..\..\..\Views\InventoryAdjusment\NewInventoryAdjusment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbAction;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\Views\InventoryAdjusment\NewInventoryAdjusment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbAccount;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\Views\InventoryAdjusment\NewInventoryAdjusment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Editors.SearchControl DocumentReference;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\Views\InventoryAdjusment\NewInventoryAdjusment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRefferenceNumber;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\Views\InventoryAdjusment\NewInventoryAdjusment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNote;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\Views\InventoryAdjusment\NewInventoryAdjusment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbLocationA;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\Views\InventoryAdjusment\NewInventoryAdjusment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbLocationB;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\Views\InventoryAdjusment\NewInventoryAdjusment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbDepartment;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\Views\InventoryAdjusment\NewInventoryAdjusment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Editors.SearchControl IDstaff;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\Views\InventoryAdjusment\NewInventoryAdjusment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGSKUInventoryAdjusment;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/inventoryadjusment/newinventoryadjusment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\InventoryAdjusment\NewInventoryAdjusment.xaml"
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
            
            #line 25 "..\..\..\..\Views\InventoryAdjusment\NewInventoryAdjusment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.saveasdraft_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 32 "..\..\..\..\Views\InventoryAdjusment\NewInventoryAdjusment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.saveaspdf_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 39 "..\..\..\..\Views\InventoryAdjusment\NewInventoryAdjusment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.playtutorial_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 61 "..\..\..\..\Views\InventoryAdjusment\NewInventoryAdjusment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveInventoryAdjusment_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 69 "..\..\..\..\Views\InventoryAdjusment\NewInventoryAdjusment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Print_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 77 "..\..\..\..\Views\InventoryAdjusment\NewInventoryAdjusment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cbAction = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.cbAccount = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.DocumentReference = ((DevExpress.Xpf.Editors.SearchControl)(target));
            return;
            case 10:
            this.txtRefferenceNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.txtNote = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.cbLocationA = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 13:
            this.cbLocationB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 14:
            this.cbDepartment = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 15:
            this.IDstaff = ((DevExpress.Xpf.Editors.SearchControl)(target));
            return;
            case 16:
            this.DGSKUInventoryAdjusment = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

