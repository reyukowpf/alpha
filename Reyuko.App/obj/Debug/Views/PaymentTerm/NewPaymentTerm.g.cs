﻿#pragma checksum "..\..\..\..\Views\PaymentTerm\NewPaymentTerm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FB487FDA2CB2F361551F56C11337A739CE8D3C3A7986E05033CB020194590670"
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


namespace Reyuko.App.Views.PaymentTerm {
    
    
    /// <summary>
    /// NewPaymentTerm
    /// </summary>
    public partial class NewPaymentTerm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 69 "..\..\..\..\Views\PaymentTerm\NewPaymentTerm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSchemeName;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Views\PaymentTerm\NewPaymentTerm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGradePeriode;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Views\PaymentTerm\NewPaymentTerm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDownPayment;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Views\PaymentTerm\NewPaymentTerm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbanuality;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Views\PaymentTerm\NewPaymentTerm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDuration;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\Views\PaymentTerm\NewPaymentTerm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtInterest;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\Views\PaymentTerm\NewPaymentTerm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkActive;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/paymentterm/newpaymentterm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\PaymentTerm\NewPaymentTerm.xaml"
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
            
            #line 42 "..\..\..\..\Views\PaymentTerm\NewPaymentTerm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 50 "..\..\..\..\Views\PaymentTerm\NewPaymentTerm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtSchemeName = ((System.Windows.Controls.TextBox)(target));
            
            #line 69 "..\..\..\..\Views\PaymentTerm\NewPaymentTerm.xaml"
            this.txtSchemeName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtSchemeName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtGradePeriode = ((System.Windows.Controls.TextBox)(target));
            
            #line 70 "..\..\..\..\Views\PaymentTerm\NewPaymentTerm.xaml"
            this.txtGradePeriode.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtGradePeriode_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtDownPayment = ((System.Windows.Controls.TextBox)(target));
            
            #line 71 "..\..\..\..\Views\PaymentTerm\NewPaymentTerm.xaml"
            this.txtDownPayment.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtDownPayment_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cbanuality = ((System.Windows.Controls.ComboBox)(target));
            
            #line 72 "..\..\..\..\Views\PaymentTerm\NewPaymentTerm.xaml"
            this.cbanuality.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbAnnual_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtDuration = ((System.Windows.Controls.TextBox)(target));
            
            #line 73 "..\..\..\..\Views\PaymentTerm\NewPaymentTerm.xaml"
            this.txtDuration.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtDuration_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtInterest = ((System.Windows.Controls.TextBox)(target));
            
            #line 74 "..\..\..\..\Views\PaymentTerm\NewPaymentTerm.xaml"
            this.txtInterest.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtInterest_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.chkActive = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

