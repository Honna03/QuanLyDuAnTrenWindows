﻿#pragma checksum "..\..\..\..\Forms\Login.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4D98BA710B3DC3743B9676F19096641AE7B699F9"
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


namespace QuanLyDuAnTrenWindows.Controls {
    
    
    /// <summary>
    /// LoginControl
    /// </summary>
    public partial class LoginControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\..\Forms\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUsername;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Forms\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Forms\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogin;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\Forms\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnForgotPassword;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\Forms\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegister;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/QuanLyDuAn;V1.0.0.0;component/forms/login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Forms\Login.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtUsername = ((System.Windows.Controls.TextBox)(target));
            
            #line 48 "..\..\..\..\Forms\Login.xaml"
            this.txtUsername.GotFocus += new System.Windows.RoutedEventHandler(this.TxtUsername_GotFocus);
            
            #line default
            #line hidden
            
            #line 49 "..\..\..\..\Forms\Login.xaml"
            this.txtUsername.LostFocus += new System.Windows.RoutedEventHandler(this.TxtUsername_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.btnLogin = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\..\Forms\Login.xaml"
            this.btnLogin.Click += new System.Windows.RoutedEventHandler(this.BtnLogin_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnForgotPassword = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\..\..\Forms\Login.xaml"
            this.btnForgotPassword.Click += new System.Windows.RoutedEventHandler(this.BtnForgotPassword_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnRegister = ((System.Windows.Controls.Button)(target));
            
            #line 115 "..\..\..\..\Forms\Login.xaml"
            this.btnRegister.Click += new System.Windows.RoutedEventHandler(this.BtnRegister_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

