﻿#pragma checksum "..\..\..\..\Dashboard\Dashboard.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20C2EBE9D65620F7746B02573BC46DD619F98C56"
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
using Program;
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


namespace Program {
    
    
    /// <summary>
    /// Dashboard1
    /// </summary>
    public partial class Dashboard1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\Dashboard\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse user_img;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Dashboard\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label user_name;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Dashboard\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label user_position;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\Dashboard\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dashboard_btn;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\Dashboard\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button menu_btn;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\Dashboard\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button order_btn;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\..\Dashboard\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button account_btn;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\..\Dashboard\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button history_btn;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\Dashboard\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button employee_btn;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\..\Dashboard\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit_btn;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\..\..\Dashboard\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame SubPanel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Program;component/dashboard/dashboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Dashboard\Dashboard.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 19 "..\..\..\..\Dashboard\Dashboard.xaml"
            ((Program.Dashboard1)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.user_img = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 3:
            this.user_name = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.user_position = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.dashboard_btn = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\..\Dashboard\Dashboard.xaml"
            this.dashboard_btn.Click += new System.Windows.RoutedEventHandler(this.dashboard_btn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.menu_btn = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\..\..\Dashboard\Dashboard.xaml"
            this.menu_btn.Click += new System.Windows.RoutedEventHandler(this.menu_btn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.order_btn = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.account_btn = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.history_btn = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.employee_btn = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.exit_btn = ((System.Windows.Controls.Button)(target));
            
            #line 163 "..\..\..\..\Dashboard\Dashboard.xaml"
            this.exit_btn.Click += new System.Windows.RoutedEventHandler(this.exit_btn_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.SubPanel = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

