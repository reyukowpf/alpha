﻿#pragma checksum "..\..\..\..\Views\Department\NewDepartment.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9689DB599CC4D9ADC56CCB77369B03EB1FAF2543148D4F4431BE142D7EFFB68C"
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
    /// NewDepartment
    /// </summary>
    public partial class NewDepartment : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 65 "..\..\..\..\Views\Department\NewDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDepartmentCode;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Views\Department\NewDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDepartmentName;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Views\Department\NewDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbSubDepartment;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Views\Department\NewDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbPIC;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Views\Department\NewDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRemarks;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/department/newdepartment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Department\NewDepartment.xaml"
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
            
            #line 40 "..\..\..\..\Views\Department\NewDepartment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 48 "..\..\..\..\Views\Department\NewDepartment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtDepartmentCode = ((System.Windows.Controls.TextBox)(target));
            
            #line 65 "..\..\..\..\Views\Department\NewDepartment.xaml"
            this.txtDepartmentCode.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtDepartmentCode_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtDepartmentName = ((System.Windows.Controls.TextBox)(target));
            
            #line 66 "..\..\..\..\Views\Department\NewDepartment.xaml"
            this.txtDepartmentName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtDepartmentName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CbSubDepartment = ((System.Windows.Controls.ComboBox)(target));
            
            #line 67 "..\..\..\..\Views\Department\NewDepartment.xaml"
            this.CbSubDepartment.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbSubDepartment_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CbPIC = ((System.Windows.Controls.ComboBox)(target));
            
            #line 68 "..\..\..\..\Views\Department\NewDepartment.xaml"
            this.CbPIC.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbPIC_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtRemarks = ((System.Windows.Controls.TextBox)(target));
            
            #line 69 "..\..\..\..\Views\Department\NewDepartment.xaml"
            this.txtRemarks.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtRemarks_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

