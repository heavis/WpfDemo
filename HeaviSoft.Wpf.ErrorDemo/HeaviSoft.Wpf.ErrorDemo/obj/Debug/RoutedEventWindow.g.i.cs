﻿#pragma checksum "..\..\RoutedEventWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C7EEDEDCAED0FEE4EEF27167DBDA5598"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HeaviSoft.Wpf.ErrorDemo;
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


namespace HeaviSoft.Wpf.ErrorDemo {
    
    
    /// <summary>
    /// RoutedEventWindow
    /// </summary>
    public partial class RoutedEventWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\RoutedEventWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid1;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\RoutedEventWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid1_1;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\RoutedEventWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid1_1_1;
        
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
            System.Uri resourceLocater = new System.Uri("/HeaviSoft.Wpf.ErrorDemo;component/routedeventwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RoutedEventWindow.xaml"
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
            this.Grid1 = ((System.Windows.Controls.Grid)(target));
            
            #line 9 "..\..\RoutedEventWindow.xaml"
            this.Grid1.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid1_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 9 "..\..\RoutedEventWindow.xaml"
            this.Grid1.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid1_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Grid1_1 = ((System.Windows.Controls.Grid)(target));
            
            #line 10 "..\..\RoutedEventWindow.xaml"
            this.Grid1_1.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid1_1_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 10 "..\..\RoutedEventWindow.xaml"
            this.Grid1_1.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid1_1_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Grid1_1_1 = ((System.Windows.Controls.Grid)(target));
            
            #line 11 "..\..\RoutedEventWindow.xaml"
            this.Grid1_1_1.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid1_1_1_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 11 "..\..\RoutedEventWindow.xaml"
            this.Grid1_1_1.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid1_1_1_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

