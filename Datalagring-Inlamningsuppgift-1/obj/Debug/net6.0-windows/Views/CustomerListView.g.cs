﻿#pragma checksum "..\..\..\..\Views\CustomerListView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DF608B62C81C68393B5B8EE122B19CE8B64A1820"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Datalagring_Inlamningsuppgift_1.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Datalagring_Inlamningsuppgift_1.Views {
    
    
    /// <summary>
    /// CustomerListView
    /// </summary>
    public partial class CustomerListView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Views\CustomerListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox customerList;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\Views\CustomerListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button customerSearchBtn;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Views\CustomerListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox customerSearchValue;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Views\CustomerListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button customerAllBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Datalagring-Inlamningsuppgift-1;component/views/customerlistview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\CustomerListView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.customerList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.customerSearchBtn = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\..\Views\CustomerListView.xaml"
            this.customerSearchBtn.Click += new System.Windows.RoutedEventHandler(this.customerSearchBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.customerSearchValue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.customerAllBtn = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\Views\CustomerListView.xaml"
            this.customerAllBtn.Click += new System.Windows.RoutedEventHandler(this.customerAllBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

