﻿#pragma checksum "..\..\..\Ecrã de registo\RegisterScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "75499815125EAD87A4DAC555414E09AFCBF57CFB28A483D33020D1D857F77BFC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Avaliacao1Lab3;
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


namespace Avaliacao1Lab3 {
    
    
    /// <summary>
    /// RegisterScreen
    /// </summary>
    public partial class RegisterScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 124 "..\..\..\Ecrã de registo\RegisterScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SoftList;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\Ecrã de registo\RegisterScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Email;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\Ecrã de registo\RegisterScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox regpass;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\Ecrã de registo\RegisterScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Username1;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\Ecrã de registo\RegisterScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox reguser;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\Ecrã de registo\RegisterScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Password1;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\Ecrã de registo\RegisterScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox regmail;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\Ecrã de registo\RegisterScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegisterButton;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\Ecrã de registo\RegisterScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButtonRegister;
        
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
            System.Uri resourceLocater = new System.Uri("/Avaliacao1Lab3;component/ecr%c3%a3%20de%20registo/registerscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ecrã de registo\RegisterScreen.xaml"
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
            this.SoftList = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Email = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.regpass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.Username1 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.reguser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Password1 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.regmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.RegisterButton = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.BackButtonRegister = ((System.Windows.Controls.Button)(target));
            
            #line 132 "..\..\..\Ecrã de registo\RegisterScreen.xaml"
            this.BackButtonRegister.Click += new System.Windows.RoutedEventHandler(this.BackButtonRegister_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

