﻿#pragma checksum "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "786C50EFC7BA848CB674697BEEAFAFEB45C71E51752FC6E3524E3DFAA2396D09"
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


namespace Reyuko.App.Views.CustomerGroup {
    
    
    /// <summary>
    /// CustomerGroup
    /// </summary>
    public partial class CustomerGroup : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 55 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LICustomerGroup;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtIDCustomerGroup;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtGroupName;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtDiscount;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtNote;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.AutoCompleteBox srcustomer;
        
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
            
            #line 39 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 46 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.playtutorial_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LICustomerGroup = ((System.Windows.Controls.ListView)(target));
            
            #line 59 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
            this.LICustomerGroup.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LICustomerGroup_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 102 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnNewCustomerGroup_Clicks);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 109 "..\..\..\..\Views\CustomerGroup\CustomerGroup.xaml"
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
            this.srcustomer = ((System.Windows.Controls.AutoCompleteBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

