﻿#pragma checksum "..\..\..\..\Views\Invoice\Sku.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "70DB71A896759BDFFCD591E307360F640DC4F8C35D2F0DFF0AD47C2FE7446F1E"
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


namespace Reyuko.App.Views.Invoice {
    
    
    /// <summary>
    /// Sku
    /// </summary>
    public partial class Sku : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 59 "..\..\..\..\Views\Invoice\Sku.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label info;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Views\Invoice\Sku.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txttotal;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Views\Invoice\Sku.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.AutoCompleteBox srsku;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\Views\Invoice\Sku.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtunit;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\Views\Invoice\Sku.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtprice;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\Views\Invoice\Sku.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtdiskon;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\Views\Invoice\Sku.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txttax;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\Views\Invoice\Sku.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txttotaltax;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\Views\Invoice\Sku.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txttotal1;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\Views\Invoice\Sku.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/invoice/sku.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Invoice\Sku.xaml"
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
            
            #line 12 "..\..\..\..\Views\Invoice\Sku.xaml"
            ((Reyuko.App.Views.Invoice.Sku)(target)).Loaded += new System.Windows.RoutedEventHandler(this.load);
            
            #line default
            #line hidden
            return;
            case 2:
            this.info = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.txttotal = ((System.Windows.Controls.TextBox)(target));
            
            #line 61 "..\..\..\..\Views\Invoice\Sku.xaml"
            this.txttotal.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txttotal_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.srsku = ((System.Windows.Controls.AutoCompleteBox)(target));
            
            #line 68 "..\..\..\..\Views\Invoice\Sku.xaml"
            this.srsku.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.produk_selectedchange);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtunit = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.txtprice = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txtdiskon = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.txttax = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.txttotaltax = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.txttotal1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.txtdiskon1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            
            #line 102 "..\..\..\..\Views\Invoice\Sku.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Addsku_Clicks);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 109 "..\..\..\..\Views\Invoice\Sku.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Clicks);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

