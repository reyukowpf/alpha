﻿#pragma checksum "..\..\..\..\Views\Document\Documentinvoice.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0BBC0A7311A106324ECBFAC1953DB6DCF23DF10672EB8DEA1359B67A4DF3214F"
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


namespace Reyuko.App.Views.Document {
    
    
    /// <summary>
    /// Documentinvoice
    /// </summary>
    public partial class Documentinvoice : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 70 "..\..\..\..\Views\Document\Documentinvoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbDocumentTipe;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Views\Document\Documentinvoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDocumentNo;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Views\Document\Documentinvoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Tanggal;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Views\Document\Documentinvoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbNamakontak;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\Views\Document\Documentinvoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescription;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Views\Document\Documentinvoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbdepartment;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Views\Document\Documentinvoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbproyek;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\Views\Document\Documentinvoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Departmen;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\Views\Document\Documentinvoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Projec;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\Views\Document\Documentinvoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image kamera;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/document/documentinvoice.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Document\Documentinvoice.xaml"
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
            
            #line 49 "..\..\..\..\Views\Document\Documentinvoice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 57 "..\..\..\..\Views\Document\Documentinvoice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbDocumentTipe = ((System.Windows.Controls.ComboBox)(target));
            
            #line 70 "..\..\..\..\Views\Document\Documentinvoice.xaml"
            this.cbDocumentTipe.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbTypedokumen_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtDocumentNo = ((System.Windows.Controls.TextBox)(target));
            
            #line 71 "..\..\..\..\Views\Document\Documentinvoice.xaml"
            this.txtDocumentNo.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtDocumentNo_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Tanggal = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.cbNamakontak = ((System.Windows.Controls.ComboBox)(target));
            
            #line 73 "..\..\..\..\Views\Document\Documentinvoice.xaml"
            this.cbNamakontak.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbNamaKontak_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtDescription = ((System.Windows.Controls.TextBox)(target));
            
            #line 74 "..\..\..\..\Views\Document\Documentinvoice.xaml"
            this.txtDescription.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtDescription_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cbdepartment = ((System.Windows.Controls.ComboBox)(target));
            
            #line 75 "..\..\..\..\Views\Document\Documentinvoice.xaml"
            this.cbdepartment.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.department_selectionchange);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cbproyek = ((System.Windows.Controls.ComboBox)(target));
            
            #line 76 "..\..\..\..\Views\Document\Documentinvoice.xaml"
            this.cbproyek.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.proyek_selectionchange);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Departmen = ((System.Windows.Controls.RadioButton)(target));
            
            #line 77 "..\..\..\..\Views\Document\Documentinvoice.xaml"
            this.Departmen.Checked += new System.Windows.RoutedEventHandler(this.Departmen_Checked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Projec = ((System.Windows.Controls.RadioButton)(target));
            
            #line 78 "..\..\..\..\Views\Document\Documentinvoice.xaml"
            this.Projec.Checked += new System.Windows.RoutedEventHandler(this.Proyek_Checked);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 80 "..\..\..\..\Views\Document\Documentinvoice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UploadFileA_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 86 "..\..\..\..\Views\Document\Documentinvoice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UploadFileB_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 92 "..\..\..\..\Views\Document\Documentinvoice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UploadFileC_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 98 "..\..\..\..\Views\Document\Documentinvoice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UploadFileD_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.kamera = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

