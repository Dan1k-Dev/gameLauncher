﻿#pragma checksum "..\..\..\Pages\Develop.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CDD9BB8C6FA90F1F55860C87274876C709EA1CB36F04709E8226B8C308071F9E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GameLauncher.Pages;
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


namespace GameLauncher.Pages {
    
    
    /// <summary>
    /// Develop
    /// </summary>
    public partial class Develop : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 95 "..\..\..\Pages\Develop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TopMenu;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Pages\Develop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GamesB;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\Pages\Develop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShopB;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\Pages\Develop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AccountB;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Pages\Develop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CartB;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\Pages\Develop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DevelopB;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\Pages\Develop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CloseLauncher;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\Pages\Develop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MinimizeLauncher;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\Pages\Develop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddGame;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\Pages\Develop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditGamee;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\Pages\Develop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RepCurGame;
        
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
            System.Uri resourceLocater = new System.Uri("/GameLauncher;component/pages/develop.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Develop.xaml"
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
            this.TopMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.GamesB = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\Pages\Develop.xaml"
            this.GamesB.Click += new System.Windows.RoutedEventHandler(this.GamesB_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ShopB = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\Pages\Develop.xaml"
            this.ShopB.Click += new System.Windows.RoutedEventHandler(this.ShopB_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AccountB = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\..\Pages\Develop.xaml"
            this.AccountB.Click += new System.Windows.RoutedEventHandler(this.AccountB_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CartB = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\..\Pages\Develop.xaml"
            this.CartB.Click += new System.Windows.RoutedEventHandler(this.CartB_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DevelopB = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.CloseLauncher = ((System.Windows.Controls.Image)(target));
            
            #line 115 "..\..\..\Pages\Develop.xaml"
            this.CloseLauncher.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.CloseLauncher_MouseUp);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MinimizeLauncher = ((System.Windows.Controls.Image)(target));
            
            #line 118 "..\..\..\Pages\Develop.xaml"
            this.MinimizeLauncher.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.MinimizeLauncher_MouseUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AddGame = ((System.Windows.Controls.Button)(target));
            
            #line 128 "..\..\..\Pages\Develop.xaml"
            this.AddGame.Click += new System.Windows.RoutedEventHandler(this.AddGame_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.EditGamee = ((System.Windows.Controls.Button)(target));
            
            #line 132 "..\..\..\Pages\Develop.xaml"
            this.EditGamee.Click += new System.Windows.RoutedEventHandler(this.EditGamee_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.RepCurGame = ((System.Windows.Controls.Button)(target));
            
            #line 136 "..\..\..\Pages\Develop.xaml"
            this.RepCurGame.Click += new System.Windows.RoutedEventHandler(this.RepCurGame_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

