﻿#pragma checksum "..\..\..\TestDesign.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1E2816FE98685C4B727E56B4A1B45F0A008C1540"
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
using WpfAnimatedGif;


namespace HealthNotificationWpf {
    
    
    /// <summary>
    /// TestDesign
    /// </summary>
    public partial class TestDesign : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 109 "..\..\..\TestDesign.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtNotifMain;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\TestDesign.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Exit;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\TestDesign.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnImage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HealthNotificationWpf;component/testdesign.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TestDesign.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 14 "..\..\..\TestDesign.xaml"
            ((HealthNotificationWpf.TestDesign)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\TestDesign.xaml"
            ((HealthNotificationWpf.TestDesign)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\TestDesign.xaml"
            ((HealthNotificationWpf.TestDesign)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtNotifMain = ((System.Windows.Controls.TextBlock)(target));
            
            #line 110 "..\..\..\TestDesign.xaml"
            this.txtNotifMain.Loaded += new System.Windows.RoutedEventHandler(this.txtBlockLoaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Exit = ((System.Windows.Controls.Image)(target));
            
            #line 134 "..\..\..\TestDesign.xaml"
            this.Exit.AddHandler(System.Windows.Input.Mouse.MouseDownEvent, new System.Windows.Input.MouseButtonEventHandler(this.Exit_MouseDown));
            
            #line default
            #line hidden
            
            #line 135 "..\..\..\TestDesign.xaml"
            this.Exit.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Exit_MouseEnter);
            
            #line default
            #line hidden
            
            #line 136 "..\..\..\TestDesign.xaml"
            this.Exit.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Exit_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnImage = ((System.Windows.Controls.Button)(target));
            
            #line 151 "..\..\..\TestDesign.xaml"
            this.btnImage.Loaded += new System.Windows.RoutedEventHandler(this.VixieFace_Loaded);
            
            #line default
            #line hidden
            
            #line 152 "..\..\..\TestDesign.xaml"
            this.btnImage.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 176 "..\..\..\TestDesign.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
