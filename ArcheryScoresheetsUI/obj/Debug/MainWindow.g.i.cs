﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2E92ED4BE504F873625E018BA888AE33222C9F38C99B7E563FFF5200A1D298C0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ScoresheetsLibrary.ViewModels;
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


namespace ArcheryScoresheetsUI {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 61 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DistanceBox;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ArrowsPerEndBox;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumberOfEndsBox;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ScoringSystemListBox;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox FaceSizeListBox;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox PlaceListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/ArcheryScoresheetsUI;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.DistanceBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 63 "..\..\MainWindow.xaml"
            this.DistanceBox.LostFocus += new System.Windows.RoutedEventHandler(this.On_DistanceBoxLostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ArrowsPerEndBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 73 "..\..\MainWindow.xaml"
            this.ArrowsPerEndBox.LostFocus += new System.Windows.RoutedEventHandler(this.On_ArrowsPerEndBoxLostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NumberOfEndsBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 83 "..\..\MainWindow.xaml"
            this.NumberOfEndsBox.LostFocus += new System.Windows.RoutedEventHandler(this.On_NumberOfEndsBoxLostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ScoringSystemListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 91 "..\..\MainWindow.xaml"
            this.ScoringSystemListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.On_ScoringSystemChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FaceSizeListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 104 "..\..\MainWindow.xaml"
            this.FaceSizeListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.On_FaceSizeChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PlaceListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 119 "..\..\MainWindow.xaml"
            this.PlaceListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.On_PlaceChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

