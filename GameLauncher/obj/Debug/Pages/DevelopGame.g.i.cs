﻿#pragma checksum "..\..\..\Pages\DevelopGame.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E0612D17F5E2CAA2A4EB69157099FEC6243D38F7A44DEE37EA5469A67AA603BE"
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
    /// DevelopGame
    /// </summary>
    public partial class DevelopGame : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Pages\DevelopGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\DevelopGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GameN;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\DevelopGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceGame;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\DevelopGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GanreCB;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Pages\DevelopGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OkGo;
        
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
            System.Uri resourceLocater = new System.Uri("/GameLauncher;component/pages/developgame.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\DevelopGame.xaml"
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
            
            #line 20 "..\..\..\Pages\DevelopGame.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GameN = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\Pages\DevelopGame.xaml"
            this.GameN.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.GameN_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PriceGame = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\Pages\DevelopGame.xaml"
            this.PriceGame.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PriceGame_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.GanreCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.OkGo = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Pages\DevelopGame.xaml"
            this.OkGo.Click += new System.Windows.RoutedEventHandler(this.OkGo_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

