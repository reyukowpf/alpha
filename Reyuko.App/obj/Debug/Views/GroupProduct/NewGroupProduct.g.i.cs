﻿#pragma checksum "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "87955DF2F98CA03256A4838542E372247F54EE88C1DC642E17D456148FE31041"
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


namespace Reyuko.App.Views.GroupProduct {
    
    
    /// <summary>
    /// NewGroupProduct
    /// </summary>
    public partial class NewGroupProduct : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 60 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancel;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGroupName;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSKU;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCategory;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescription;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkDiscount;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDiscount;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtTanggalMulaiDiskon;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtTanggalAkhirDiskon;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/groupproduct/newgroupproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
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
            this.BtnSave = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
            this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
            this.BtnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtGroupName = ((System.Windows.Controls.TextBox)(target));
            
            #line 83 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
            this.txtGroupName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtGroupName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtSKU = ((System.Windows.Controls.TextBox)(target));
            
            #line 84 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
            this.txtSKU.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtSKU_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cbCategory = ((System.Windows.Controls.ComboBox)(target));
            
            #line 85 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
            this.cbCategory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbCategory_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtDescription = ((System.Windows.Controls.TextBox)(target));
            
            #line 86 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
            this.txtDescription.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtDescription_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.chkDiscount = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.txtDiscount = ((System.Windows.Controls.TextBox)(target));
            
            #line 88 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
            this.txtDiscount.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtDiscount_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dtTanggalMulaiDiskon = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 10:
            this.dtTanggalAkhirDiskon = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 11:
            
            #line 92 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UploadFileA_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 98 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UploadFileB_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 104 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UploadFileC_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 110 "..\..\..\..\Views\GroupProduct\NewGroupProduct.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UploadFileD_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

