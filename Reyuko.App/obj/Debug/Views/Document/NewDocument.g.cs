﻿#pragma checksum "..\..\..\..\Views\Document\NewDocument.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7F2C44D84A85E3597FA737A3E59634917C570687620135594796792CE5D903FE"
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


namespace Reyuko.App.Views.Document {
    
    
    /// <summary>
    /// NewDocument
    /// </summary>
    public partial class NewDocument : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 71 "..\..\..\..\Views\Document\NewDocument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbDocumentTipe;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Views\Document\NewDocument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDocumentNo;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Views\Document\NewDocument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtTanggalDokumen;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\Views\Document\NewDocument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbNamakontak;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Views\Document\NewDocument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbdepartment;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Views\Document\NewDocument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbproyek;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\Views\Document\NewDocument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescription;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\Views\Document\NewDocument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Departmen;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\Views\Document\NewDocument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Projec;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/document/newdocument.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Document\NewDocument.xaml"
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
            
            #line 47 "..\..\..\..\Views\Document\NewDocument.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 54 "..\..\..\..\Views\Document\NewDocument.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbDocumentTipe = ((System.Windows.Controls.ComboBox)(target));
            
            #line 71 "..\..\..\..\Views\Document\NewDocument.xaml"
            this.cbDocumentTipe.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbTypedokumen_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtDocumentNo = ((System.Windows.Controls.TextBox)(target));
            
            #line 72 "..\..\..\..\Views\Document\NewDocument.xaml"
            this.txtDocumentNo.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtDocumentNo_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dtTanggalDokumen = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.cbNamakontak = ((System.Windows.Controls.ComboBox)(target));
            
            #line 74 "..\..\..\..\Views\Document\NewDocument.xaml"
            this.cbNamakontak.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbNamaKontak_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cbdepartment = ((System.Windows.Controls.ComboBox)(target));
            
            #line 75 "..\..\..\..\Views\Document\NewDocument.xaml"
            this.cbdepartment.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.department_selectionchange);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cbproyek = ((System.Windows.Controls.ComboBox)(target));
            
            #line 76 "..\..\..\..\Views\Document\NewDocument.xaml"
            this.cbproyek.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.proyek_selectionchange);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtDescription = ((System.Windows.Controls.TextBox)(target));
            
            #line 77 "..\..\..\..\Views\Document\NewDocument.xaml"
            this.txtDescription.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtDescription_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Departmen = ((System.Windows.Controls.RadioButton)(target));
            
            #line 78 "..\..\..\..\Views\Document\NewDocument.xaml"
            this.Departmen.Checked += new System.Windows.RoutedEventHandler(this.Departmen_Checked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Projec = ((System.Windows.Controls.RadioButton)(target));
            
            #line 79 "..\..\..\..\Views\Document\NewDocument.xaml"
            this.Projec.Checked += new System.Windows.RoutedEventHandler(this.Proyek_Checked);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 81 "..\..\..\..\Views\Document\NewDocument.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UploadFileA_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 87 "..\..\..\..\Views\Document\NewDocument.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UploadFileB_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 93 "..\..\..\..\Views\Document\NewDocument.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UploadFileC_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 99 "..\..\..\..\Views\Document\NewDocument.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UploadFileD_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

