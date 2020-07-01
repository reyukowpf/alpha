﻿#pragma checksum "..\..\..\..\Views\Department\Department.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3850CB5DB40191F74A2ADBF093EDBA3A2DCDF455F3D718D3020E80040738C3C9"
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


namespace Reyuko.App.Views.Department {
    
    
    /// <summary>
    /// Department
    /// </summary>
    public partial class Department : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\..\Views\Department\Department.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LIDepartment;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\..\Views\Department\Department.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.AutoCompleteBox srcustomer;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\..\..\Views\Department\Department.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtDepartmentCode;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\..\..\Views\Department\Department.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtDepartmentName;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\..\..\Views\Department\Department.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtSubDepartment;
        
        #line default
        #line hidden
        
        
        #line 182 "..\..\..\..\Views\Department\Department.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtPIC;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\..\..\Views\Department\Department.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtRemarks;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\..\..\Views\Department\Department.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGBudget;
        
        #line default
        #line hidden
        
        
        #line 375 "..\..\..\..\Views\Department\Department.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGTeam;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/department/department.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Department\Department.xaml"
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
            this.LIDepartment = ((System.Windows.Controls.ListView)(target));
            
            #line 43 "..\..\..\..\Views\Department\Department.xaml"
            this.LIDepartment.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LIDepartment_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 87 "..\..\..\..\Views\Department\Department.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 94 "..\..\..\..\Views\Department\Department.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Viewinactived_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 101 "..\..\..\..\Views\Department\Department.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.playtutorial_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 111 "..\..\..\..\Views\Department\Department.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnNewDepartment_Clicks);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 119 "..\..\..\..\Views\Department\Department.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEditDepartment_Clicks);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 127 "..\..\..\..\Views\Department\Department.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Print_Clicks);
            
            #line default
            #line hidden
            return;
            case 8:
            this.srcustomer = ((System.Windows.Controls.AutoCompleteBox)(target));
            return;
            case 9:
            this.txtDepartmentCode = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.txtDepartmentName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.txtSubDepartment = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.txtPIC = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.txtRemarks = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            this.DGBudget = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 15:
            this.DGTeam = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

