﻿#pragma checksum "..\..\..\..\Views\AccountData\DeleteAccountLevel.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0AB105074C4273ACF761104BA2DA7FEC4BC70EE113AE7690F093E0E5F4474385"
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


namespace Reyuko.App.Views.AccountData {
    
    
    /// <summary>
    /// DeleteAccounLevel
    /// </summary>
    public partial class DeleteAccounLevel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\..\..\Views\AccountData\DeleteAccountLevel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbAccountData;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Views\AccountData\DeleteAccountLevel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAccountcode;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Views\AccountData\DeleteAccountLevel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblAccountLevel;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/accountdata/deleteaccountlevel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\AccountData\DeleteAccountLevel.xaml"
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
            
            #line 40 "..\..\..\..\Views\AccountData\DeleteAccountLevel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.savelevel_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 48 "..\..\..\..\Views\AccountData\DeleteAccountLevel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbAccountData = ((System.Windows.Controls.ComboBox)(target));
            
            #line 57 "..\..\..\..\Views\AccountData\DeleteAccountLevel.xaml"
            this.cbAccountData.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbAccountData_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtAccountcode = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\..\..\Views\AccountData\DeleteAccountLevel.xaml"
            this.txtAccountcode.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtAccountcode_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lblAccountLevel = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

