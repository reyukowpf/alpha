﻿#pragma checksum "..\..\..\..\Views\CategoryProduk\CategoryProduk.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0FF73AB470A13C327547F8E0DE06289EE081AB9CEB7DCFAC2CDEBC8772E29EE7"
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


namespace Reyuko.App.Views.CategoryProduk {
    
    
    /// <summary>
    /// CategoryProduk
    /// </summary>
    public partial class CategoryProduk : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 70 "..\..\..\..\Views\CategoryProduk\CategoryProduk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCategoryName;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Views\CategoryProduk\CategoryProduk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBKategoryParent;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Views\CategoryProduk\CategoryProduk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescription;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/categoryproduk/categoryproduk.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\CategoryProduk\CategoryProduk.xaml"
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
            
            #line 50 "..\..\..\..\Views\CategoryProduk\CategoryProduk.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 58 "..\..\..\..\Views\CategoryProduk\CategoryProduk.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtCategoryName = ((System.Windows.Controls.TextBox)(target));
            
            #line 70 "..\..\..\..\Views\CategoryProduk\CategoryProduk.xaml"
            this.txtCategoryName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtCategoryName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CBKategoryParent = ((System.Windows.Controls.ComboBox)(target));
            
            #line 71 "..\..\..\..\Views\CategoryProduk\CategoryProduk.xaml"
            this.CBKategoryParent.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CBKategoryParent_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtDescription = ((System.Windows.Controls.TextBox)(target));
            
            #line 72 "..\..\..\..\Views\CategoryProduk\CategoryProduk.xaml"
            this.txtDescription.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtDescription_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

