<<<<<<< HEAD
﻿#pragma checksum "..\..\..\..\..\src\ui\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F62934C877695E0CC51FD9A2F0E7E3C4BD882407"
=======
﻿#pragma checksum "..\..\..\..\..\src\ui\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6B7CDF5F97042D69F6CBAF3DB46EE8EFC25F157F"
>>>>>>> a25ed2aeb3125910c741f1164af5b015d869a067
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using LiveCharts.Wpf;
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
using national_statistics;


namespace national_statistics {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
<<<<<<< HEAD
        
        #line 25 "..\..\..\..\..\src\ui\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\src\ui\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.PieChart pieChart;
        
        #line default
        #line hidden
        
=======
>>>>>>> a25ed2aeb3125910c741f1164af5b015d869a067
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
<<<<<<< HEAD
            System.Uri resourceLocater = new System.Uri("/national-statistics;component/src/ui/mainwindow.xaml", System.UriKind.Relative);
=======
            System.Uri resourceLocater = new System.Uri("/national-statistics;V1.0.0.0;component/src/ui/mainwindow.xaml", System.UriKind.Relative);
>>>>>>> a25ed2aeb3125910c741f1164af5b015d869a067
            
            #line 1 "..\..\..\..\..\src\ui\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 24 "..\..\..\..\..\src\ui\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonCreateGraphic_Click);
            
            #line default
            #line hidden
            return;
            case 2:
<<<<<<< HEAD
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 25 "..\..\..\..\..\src\ui\MainWindow.xaml"
            this.dataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);
=======
            
            #line 25 "..\..\..\..\..\src\ui\MainWindow.xaml"
            ((System.Windows.Controls.DataGrid)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);
>>>>>>> a25ed2aeb3125910c741f1164af5b015d869a067
            
            #line default
            #line hidden
            return;
<<<<<<< HEAD
            case 3:
            this.pieChart = ((LiveCharts.Wpf.PieChart)(target));
            return;
=======
>>>>>>> a25ed2aeb3125910c741f1164af5b015d869a067
            }
            this._contentLoaded = true;
        }
    }
}

