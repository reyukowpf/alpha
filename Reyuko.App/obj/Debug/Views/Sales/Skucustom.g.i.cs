﻿#pragma checksum "..\..\..\..\Views\Sales\Skucustom.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "37B2375697777256874241F5E99D1DF32F3F72EA33F846F7360EAEC34F5B2357"
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
    /// Skucustom
    /// </summary>
    public partial class Skucustom : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 58 "..\..\..\..\Views\Sales\Skucustom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txttotal;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Views\Sales\Skucustom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtnama;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Views\Sales\Skucustom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtharga;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Views\Sales\Skucustom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtdiskon;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Views\Sales\Skucustom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txttax;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Views\Sales\Skucustom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txttotal1;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Views\Sales\Skucustom.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/sales/skucustom.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Sales\Skucustom.xaml"
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
            
            #line 12 "..\..\..\..\Views\Sales\Skucustom.xaml"
            ((Reyuko.App.Views.Invoice.Skucustom)(target)).Loaded += new System.Windows.RoutedEventHandler(this.load);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txttotal = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\..\..\Views\Sales\Skucustom.xaml"
            this.txttotal.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txttotal_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtnama = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtharga = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtdiskon = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.txttax = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txttotal1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.txtdiskon1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            
            #line 66 "..\..\..\..\Views\Sales\Skucustom.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Addsku_Clicks);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 73 "..\..\..\..\Views\Sales\Skucustom.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Clicks);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

