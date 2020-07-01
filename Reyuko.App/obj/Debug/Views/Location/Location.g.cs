﻿#pragma checksum "..\..\..\..\Views\Location\Location.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "03568E25F89B8E21130E6C75333D230D0E43384BDEFAA1BDD58D5FB2B765D9FC"
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


namespace Reyuko.App.Views.Location {
    
    
    /// <summary>
    /// Location
    /// </summary>
    public partial class Location : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\Views\Location\Location.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid1;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\Views\Location\Location.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LiLocation;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\..\Views\Location\Location.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.AutoCompleteBox srsidelist;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\..\Views\Location\Location.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.AutoCompleteBox srtable;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\..\Views\Location\Location.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbkategori;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\..\Views\Location\Location.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGLocation;
        
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
            System.Uri resourceLocater = new System.Uri("/Reyuko.App;component/views/location/location.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Location\Location.xaml"
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
            this.grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 51 "..\..\..\..\Views\Location\Location.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnNewLocation_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 59 "..\..\..\..\Views\Location\Location.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEditLocation_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 67 "..\..\..\..\Views\Location\Location.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Print_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LiLocation = ((System.Windows.Controls.ListView)(target));
            
            #line 83 "..\..\..\..\Views\Location\Location.xaml"
            this.LiLocation.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LiLocation_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.srsidelist = ((System.Windows.Controls.AutoCompleteBox)(target));
            
            #line 113 "..\..\..\..\Views\Location\Location.xaml"
            this.srsidelist.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Lokasis_selectedchange);
            
            #line default
            #line hidden
            return;
            case 7:
            this.srtable = ((System.Windows.Controls.AutoCompleteBox)(target));
            
            #line 131 "..\..\..\..\Views\Location\Location.xaml"
            this.srtable.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListProduk_selectedchange);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cbkategori = ((System.Windows.Controls.ComboBox)(target));
            
            #line 143 "..\..\..\..\Views\Location\Location.xaml"
            this.cbkategori.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.KategoriProduk_selectedchange);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DGLocation = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

