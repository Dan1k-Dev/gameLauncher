﻿#pragma checksum "..\..\..\Windows\SignIn.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5B88A8C0B23117D2B83639D6D73E8D6AB65D2D237250D4DEAF8C91AB91F5158B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GameLauncher;
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


namespace GameLauncher {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Windows\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CloseApp;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Windows\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Minimize;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Windows\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SignUp;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Windows\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button googleSite;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Windows\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GitHubSite;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Windows\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button vkSite;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Windows\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock incorrectInfo;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\Windows\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmail;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\Windows\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\Windows\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sign;
        
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
            System.Uri resourceLocater = new System.Uri("/GameLauncher;component/windows/signin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\SignIn.xaml"
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
            this.CloseApp = ((System.Windows.Controls.Image)(target));
            
            #line 19 "..\..\..\Windows\SignIn.xaml"
            this.CloseApp.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.CloseApp_MouseUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Minimize = ((System.Windows.Controls.Image)(target));
            
            #line 22 "..\..\..\Windows\SignIn.xaml"
            this.Minimize.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Minimize_MouseUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SignUp = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Windows\SignIn.xaml"
            this.SignUp.Click += new System.Windows.RoutedEventHandler(this.SignUp_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 51 "..\..\..\Windows\SignIn.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.googleSite = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Windows\SignIn.xaml"
            this.googleSite.Click += new System.Windows.RoutedEventHandler(this.googleSite_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GitHubSite = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\Windows\SignIn.xaml"
            this.GitHubSite.Click += new System.Windows.RoutedEventHandler(this.GitHubSite_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.vkSite = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\Windows\SignIn.xaml"
            this.vkSite.Click += new System.Windows.RoutedEventHandler(this.vkSite_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.incorrectInfo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.txtEmail = ((System.Windows.Controls.TextBox)(target));
            
            #line 113 "..\..\..\Windows\SignIn.xaml"
            this.txtEmail.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.txtEmail_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 128 "..\..\..\Windows\SignIn.xaml"
            this.txtPassword.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.txtPassword_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Sign = ((System.Windows.Controls.Button)(target));
            
            #line 135 "..\..\..\Windows\SignIn.xaml"
            this.Sign.Click += new System.Windows.RoutedEventHandler(this.Sign_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

