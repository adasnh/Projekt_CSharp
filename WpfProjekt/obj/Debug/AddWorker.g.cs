﻿#pragma checksum "..\..\AddWorker.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F5271FB04CF91024D4749A0B46F7F82AAF0559A9D58FDBD94E6D61ED0D8D47A3"
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
using WpfProjekt;


namespace WpfProjekt {
    
    
    /// <summary>
    /// AddWorker
    /// </summary>
    public partial class AddWorker : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\AddWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid1;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AddWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox imieTextBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AddWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nazwiskoTextBox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\AddWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridWorkers;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\AddWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn id_pracownikaColumn;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\AddWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn imieColumn;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\AddWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn nazwiskoColumn;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfProjekt;component/addworker.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddWorker.xaml"
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
            this.grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.imieTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.nazwiskoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 37 "..\..\AddWorker.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Create_button);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 45 "..\..\AddWorker.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Update_button);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 53 "..\..\AddWorker.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_button);
            
            #line default
            #line hidden
            return;
            case 7:
            this.gridWorkers = ((System.Windows.Controls.DataGrid)(target));
            
            #line 61 "..\..\AddWorker.xaml"
            this.gridWorkers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.gridWorkers_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.id_pracownikaColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 9:
            this.imieColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 10:
            this.nazwiskoColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
