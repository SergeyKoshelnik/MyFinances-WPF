﻿#pragma checksum "..\..\..\View\AddDebts.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "97D442B3EA855EDB94A6209A99F9CAF0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MyFinances.View;
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


namespace MyFinances.View {
    
    
    /// <summary>
    /// AddDebts
    /// </summary>
    public partial class AddDebts : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\View\AddDebts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblEnterNameDebt;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\View\AddDebts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxEnterNameDebt;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\View\AddDebts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblEnterSummDebt;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\View\AddDebts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxEnterSummDebt;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\AddDebts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblEnterDateEndDebt;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\View\AddDebts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePickerDebts;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\View\AddDebts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddDebts;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\View\AddDebts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelAddDebts;
        
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
            System.Uri resourceLocater = new System.Uri("/MyFinances;component/view/adddebts.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\AddDebts.xaml"
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
            this.lblEnterNameDebt = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.textBoxEnterNameDebt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.lblEnterSummDebt = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.textBoxEnterSummDebt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.lblEnterDateEndDebt = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.datePickerDebts = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.btnAddDebts = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\View\AddDebts.xaml"
            this.btnAddDebts.Click += new System.Windows.RoutedEventHandler(this.btnAddDebts_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCancelAddDebts = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\View\AddDebts.xaml"
            this.btnCancelAddDebts.Click += new System.Windows.RoutedEventHandler(this.btnCancelAddDebts_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

