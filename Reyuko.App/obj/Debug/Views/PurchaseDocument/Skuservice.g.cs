﻿#pragma checksum "..\..\..\..\Views\PurchaseDocument\Skuservice.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4538EB42AD13C8DE92205B1E869FC4A63F40D6391A141CC51FB0C5839EB191CC"
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


namespace Reyuko.App.Views.PurchaseDocument {
    
    
    /// <summary>
    /// Skuservice
    /// </summary>
    public partial class Skuservice : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 58 "..\..\..\..\Views\PurchaseDocument\Skuservice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label info;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Views\PurchaseDocument\Skuservice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txttotal;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Views\PurchaseDocument\Skuservice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.AutoCompleteBox srsku;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\Views\PurchaseDocument\Skuservice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtprice;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\Views\PurchaseDocument\Skuservice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtdiskon;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\Views\PurchaseDocument\Skuservice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txttax;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\Views\PurchaseDocument\Skuservice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txttotaltax;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\Views\PurchaseDocument\Skuservice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txttotal1;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\Views\PurchaseDocument\Skuservice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtdiskon1;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/purchasedocument/skuservice.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\PurchaseDocument\Skuservice.xaml"
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
            
            #line 12 "..\..\..\..\Views\PurchaseDocument\Skuservice.xaml"
            ((Reyuko.App.Views.PurchaseDocument.Skuservice)(target)).Loaded += new System.Windows.RoutedEventHandler(this.load);
            
            #line default
            #line hidden
            return;
            case 2:
            this.info = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.txttotal = ((System.Windows.Controls.TextBox)(target));
            
            #line 60 "..\..\..\..\Views\PurchaseDocument\Skuservice.xaml"
            this.txttotal.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txttotal_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.srsku = ((System.Windows.Controls.AutoCompleteBox)(target));
            
            #line 67 "..\..\..\..\Views\PurchaseDocument\Skuservice.xaml"
            this.srsku.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.produk_selectedchange);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtprice = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.txtdiskon = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txttax = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.txttotaltax = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.txttotal1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.txtdiskon1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            
            #line 92 "..\..\..\..\Views\PurchaseDocument\Skuservice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Addsku_Clicks);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 99 "..\..\..\..\Views\PurchaseDocument\Skuservice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Clicks);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
