﻿#pragma checksum "..\..\..\View\AddSummForAccumulation.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1353EC82BF21DEC3B6CF3B9DE7A11C42"
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
    /// AddSummForAccumulation
    /// </summary>
    public partial class AddSummForAccumulation : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\View\AddSummForAccumulation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblEnterNameAccumulation;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\View\AddSummForAccumulation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxEnterNameAccumulation;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\View\AddSummForAccumulation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblAddSummAccumulation;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\View\AddSummForAccumulation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxAddSummAccumulation;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\View\AddSummForAccumulation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddSummAccumulation;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\View\AddSummForAccumulation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelAddSummAccumulation;
        
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
            System.Uri resourceLocater = new System.Uri("/MyFinances;component/view/addsummforaccumulation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\AddSummForAccumulation.xaml"
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
            this.lblEnterNameAccumulation = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.comboBoxEnterNameAccumulation = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.lblAddSummAccumulation = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.textBoxAddSummAccumulation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnAddSummAccumulation = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\View\AddSummForAccumulation.xaml"
            this.btnAddSummAccumulation.Click += new System.Windows.RoutedEventHandler(this.btnAddSummAccumulation_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnCancelAddSummAccumulation = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\View\AddSummForAccumulation.xaml"
            this.btnCancelAddSummAccumulation.Click += new System.Windows.RoutedEventHandler(this.btnCancelAddSummAccumulation_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

