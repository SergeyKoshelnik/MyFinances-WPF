﻿#pragma checksum "..\..\..\View\EnterQuestion.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5D36AD8D4A809D23C684E239EA7A7AA2"
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
    /// EnterQuestion
    /// </summary>
    public partial class EnterQuestion : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\View\EnterQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblEnterQuestion;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\View\EnterQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblQuestion;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\View\EnterQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxEnterQuestion;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\EnterQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEnterQuestionOK;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\View\EnterQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEnterQuestionExit;
        
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
            System.Uri resourceLocater = new System.Uri("/MyFinances;component/view/enterquestion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\EnterQuestion.xaml"
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
            this.lblEnterQuestion = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.lblQuestion = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.textBoxEnterQuestion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnEnterQuestionOK = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\View\EnterQuestion.xaml"
            this.btnEnterQuestionOK.Click += new System.Windows.RoutedEventHandler(this.btnEnterQuestionOK_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnEnterQuestionExit = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\View\EnterQuestion.xaml"
            this.btnEnterQuestionExit.Click += new System.Windows.RoutedEventHandler(this.btnEnterQuestionExit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

