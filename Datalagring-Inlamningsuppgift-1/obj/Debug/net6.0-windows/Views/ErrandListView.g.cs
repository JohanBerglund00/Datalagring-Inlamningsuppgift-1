﻿#pragma checksum "..\..\..\..\Views\ErrandListView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9B066D25E32A64E74588421EF192C6CE06ECE959"
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
    /// ErrandListView
    /// </summary>
    public partial class ErrandListView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\Views\ErrandListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button getErrandBtn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Views\ErrandListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button getErrandSearchBtn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Views\ErrandListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox getErrandSearchValue;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Views\ErrandListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox errandList;
        
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
            System.Uri resourceLocater = new System.Uri("/Datalagring-Inlamningsuppgift-1;component/views/errandlistview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\ErrandListView.xaml"
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
            this.getErrandBtn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\Views\ErrandListView.xaml"
            this.getErrandBtn.Click += new System.Windows.RoutedEventHandler(this.getErrandBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.getErrandSearchBtn = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\Views\ErrandListView.xaml"
            this.getErrandSearchBtn.Click += new System.Windows.RoutedEventHandler(this.getErrandSearchBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.getErrandSearchValue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.errandList = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

