﻿#pragma checksum "..\..\..\Windows\EditProfile.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "40D205DA87D3B29D2E8218A13BFE3AF3F17A5B4216D8F0A59F6AAD4701FFB3B7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GameLauncher.Windows;
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
using Xceed.Wpf.Toolkit;


namespace GameLauncher.Windows {
    
    
    /// <summary>
    /// EditProfile
    /// </summary>
    public partial class EditProfile : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Windows\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Windows\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Nickname;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Windows\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Email;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Windows\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Password;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Windows\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Okay;
        
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
            System.Uri resourceLocater = new System.Uri("/GameLauncher;component/windows/editprofile.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\EditProfile.xaml"
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
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Windows\EditProfile.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Nickname = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\Windows\EditProfile.xaml"
            this.Nickname.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Nickname_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Email = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\Windows\EditProfile.xaml"
            this.Email.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Email_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Password = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\..\Windows\EditProfile.xaml"
            this.Password.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Password_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Okay = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Windows\EditProfile.xaml"
            this.Okay.Click += new System.Windows.RoutedEventHandler(this.Okay_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

