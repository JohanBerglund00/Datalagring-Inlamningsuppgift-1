﻿#pragma checksum "..\..\..\..\Views\RegisterCustomerView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D643AF4359C95D7369863A6CEC07CCF4BB60AFA4"
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
    /// RegisterCustomerView
    /// </summary>
    public partial class RegisterCustomerView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\Views\RegisterCustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstNameText;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Views\RegisterCustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lastNameText;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Views\RegisterCustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox emailText;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Views\RegisterCustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phoneNumberText;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Views\RegisterCustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addressText;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Views\RegisterCustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox postNumberText;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Views\RegisterCustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cityText;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Views\RegisterCustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button submitCustomerButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Datalagring-Inlamningsuppgift-1;component/views/registercustomerview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\RegisterCustomerView.xaml"
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
            this.firstNameText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.lastNameText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.emailText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.phoneNumberText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.addressText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.postNumberText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.cityText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.submitCustomerButton = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\Views\RegisterCustomerView.xaml"
            this.submitCustomerButton.Click += new System.Windows.RoutedEventHandler(this.submitCustomerButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

