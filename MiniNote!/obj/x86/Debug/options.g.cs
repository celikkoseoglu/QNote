﻿#pragma checksum "..\..\..\options.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3F08B64DC77E87F99D06267BF6DF3C30"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
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


namespace QNote {
    
    
    /// <summary>
    /// options
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class options : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 4 "..\..\..\options.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal QNote.options options_window;
        
        #line default
        #line hidden
        
        
        #line 6 "..\..\..\options.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox fontColor;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\options.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button applyButton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\options.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label3;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\options.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label4;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\options.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox notepadColor;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\options.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label5;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\options.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox backgroundColor;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\options.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox fontOption;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\options.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label fontSelect;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\options.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/QNote;component/options.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\options.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.options_window = ((QNote.options)(target));
            
            #line 4 "..\..\..\options.xaml"
            this.options_window.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.fontColor = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.applyButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\options.xaml"
            this.applyButton.Click += new System.Windows.RoutedEventHandler(this.applyButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.label3 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.label4 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.notepadColor = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.label5 = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.backgroundColor = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.fontOption = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.fontSelect = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\options.xaml"
            this.cancelButton.Click += new System.Windows.RoutedEventHandler(this.cancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

