﻿#pragma checksum "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0D27716B5E3FFA6DEF6EEE38103D87DE9CF20A45F3295D55123BD786A5F5EE4D"
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


namespace Reyuko.App.Views.CustomerGroup {
    
    
    /// <summary>
    /// CustomerGroup
    /// </summary>
    public partial class CustomerGroup : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LICustomerGroup;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtIDCustomerGroup;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtGroupName;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtDiscount;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtNote;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Editors.SearchControl txtSearch;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/customergroup/customergroup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
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
            
            #line 19 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 26 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.playtutorial_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LICustomerGroup = ((System.Windows.Controls.ListView)(target));
            
            #line 39 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
            this.LICustomerGroup.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LICustomerGroup_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 82 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnNewCustomerGroup_Clicks);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 89 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEditCustomerGroup_Clicks);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtIDCustomerGroup = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txtGroupName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.txtDiscount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.txtNote = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.txtSearch = ((DevExpress.Xpf.Editors.SearchControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

