﻿#pragma checksum "..\..\..\..\UI\ERP.UI.EmployeeEntry.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FF56E7FE2249C874A5BA55FCE7EDAC96D8445FA7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WPFDemo;


namespace WPFDemo.ERP.UI {
    
    
    /// <summary>
    /// EmployeeEntry
    /// </summary>
    public partial class EmployeeEntry : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\UI\ERP.UI.EmployeeEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstNameText;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\UI\ERP.UI.EmployeeEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastNameText;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\UI\ERP.UI.EmployeeEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdentityNumberText;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\UI\ERP.UI.EmployeeEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BirthPlaceText;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\UI\ERP.UI.EmployeeEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker BirthDateText;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\UI\ERP.UI.EmployeeEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SubmitButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFDemo;V1.0.0.0;component/ui/erp.ui.employeeentry.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\ERP.UI.EmployeeEntry.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.FirstNameText = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\..\UI\ERP.UI.EmployeeEntry.xaml"
            this.FirstNameText.KeyDown += new System.Windows.Input.KeyEventHandler(this.FirstNameText_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LastNameText = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\..\UI\ERP.UI.EmployeeEntry.xaml"
            this.LastNameText.KeyDown += new System.Windows.Input.KeyEventHandler(this.LastNameText_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.IdentityNumberText = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\..\..\UI\ERP.UI.EmployeeEntry.xaml"
            this.IdentityNumberText.KeyDown += new System.Windows.Input.KeyEventHandler(this.IdentityNumberText_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BirthPlaceText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BirthDateText = ((System.Windows.Controls.DatePicker)(target));
            
            #line 50 "..\..\..\..\UI\ERP.UI.EmployeeEntry.xaml"
            this.BirthDateText.KeyUp += new System.Windows.Input.KeyEventHandler(this.BirthDateText_KeyUp);
            
            #line default
            #line hidden
            
            #line 50 "..\..\..\..\UI\ERP.UI.EmployeeEntry.xaml"
            this.BirthDateText.KeyDown += new System.Windows.Input.KeyEventHandler(this.BirthDateText_KeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SubmitButton = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\UI\ERP.UI.EmployeeEntry.xaml"
            this.SubmitButton.Click += new System.Windows.RoutedEventHandler(this.SubmitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

