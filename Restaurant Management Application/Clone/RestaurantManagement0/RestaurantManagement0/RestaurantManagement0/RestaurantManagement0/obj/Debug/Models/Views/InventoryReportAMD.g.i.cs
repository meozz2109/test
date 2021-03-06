﻿#pragma checksum "..\..\..\..\Models\Views\InventoryReportAMD.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "507EBDEEF5C93921568DF016DC73105A5A9DF5AFD109EBDF0E04E26AC70417F0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using RestaurantManagement0.Models.AMDs;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace RestaurantManagement0.Models.AMDs {
    
    
    /// <summary>
    /// InventoryReportAMD
    /// </summary>
    public partial class InventoryReportAMD : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 124 "..\..\..\..\Models\Views\InventoryReportAMD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchIButton;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\..\Models\Views\InventoryReportAMD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchIBox;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\..\..\Models\Views\InventoryReportAMD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\..\Models\Views\InventoryReportAMD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEdit;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\..\Models\Views\InventoryReportAMD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDel;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\..\Models\Views\InventoryReportAMD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\..\..\Models\Views\InventoryReportAMD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSkip;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\..\..\Models\Views\InventoryReportAMD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvInventoryReport;
        
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
            System.Uri resourceLocater = new System.Uri("/RestaurantManagement0;component/models/views/inventoryreportamd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Models\Views\InventoryReportAMD.xaml"
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
            
            #line 9 "..\..\..\..\Models\Views\InventoryReportAMD.xaml"
            ((RestaurantManagement0.Models.AMDs.InventoryReportAMD)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchIButton = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.SearchIBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 136 "..\..\..\..\Models\Views\InventoryReportAMD.xaml"
            this.SearchIBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.SearchIBox_KeyDown);
            
            #line default
            #line hidden
            
            #line 144 "..\..\..\..\Models\Views\InventoryReportAMD.xaml"
            this.SearchIBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchIBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 145 "..\..\..\..\Models\Views\InventoryReportAMD.xaml"
            this.SearchIBox.GotFocus += new System.Windows.RoutedEventHandler(this.SearchIBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 157 "..\..\..\..\Models\Views\InventoryReportAMD.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 163 "..\..\..\..\Models\Views\InventoryReportAMD.xaml"
            this.btnEdit.Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnDel = ((System.Windows.Controls.Button)(target));
            
            #line 169 "..\..\..\..\Models\Views\InventoryReportAMD.xaml"
            this.btnDel.Click += new System.Windows.RoutedEventHandler(this.btnDel_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 175 "..\..\..\..\Models\Views\InventoryReportAMD.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSkip = ((System.Windows.Controls.Button)(target));
            
            #line 181 "..\..\..\..\Models\Views\InventoryReportAMD.xaml"
            this.btnSkip.Click += new System.Windows.RoutedEventHandler(this.btnSkip_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lvInventoryReport = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

