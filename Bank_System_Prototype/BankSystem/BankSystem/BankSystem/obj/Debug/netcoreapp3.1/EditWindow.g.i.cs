﻿#pragma checksum "..\..\..\EditWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F792DAAEFC1DF87E26C0476BC2AD4FC1E9DA2219"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Bank_System;
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


namespace Bank_System {
    
    
    /// <summary>
    /// EditWindow
    /// </summary>
    public partial class EditWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxFirstName;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxLastName;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxBirthday;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxName;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxCreateDate;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioNatural;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioLegal;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButOpenCalenNatural;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButOpenCalenLegal;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButEdit;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\EditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButCancel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BankSystem;component/editwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\EditWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\EditWindow.xaml"
            ((Bank_System.EditWindow)(target)).Initialized += new System.EventHandler(this.Window_Initialized);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BoxFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BoxLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BoxBirthday = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BoxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.BoxCreateDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.RadioNatural = ((System.Windows.Controls.RadioButton)(target));
            
            #line 40 "..\..\..\EditWindow.xaml"
            this.RadioNatural.Checked += new System.Windows.RoutedEventHandler(this.RadioNatural_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RadioLegal = ((System.Windows.Controls.RadioButton)(target));
            
            #line 41 "..\..\..\EditWindow.xaml"
            this.RadioLegal.Checked += new System.Windows.RoutedEventHandler(this.RadioLegal_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ButOpenCalenNatural = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\EditWindow.xaml"
            this.ButOpenCalenNatural.Click += new System.Windows.RoutedEventHandler(this.ButOpenCalen_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ButOpenCalenLegal = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\EditWindow.xaml"
            this.ButOpenCalenLegal.Click += new System.Windows.RoutedEventHandler(this.ButOpenCalen_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ButEdit = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.ButCancel = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

