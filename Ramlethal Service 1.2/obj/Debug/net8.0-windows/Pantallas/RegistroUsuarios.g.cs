﻿#pragma checksum "..\..\..\..\Pantallas\RegistroUsuarios.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D7A8359FC70AC488CF1CD7F698197DA0E5F3F7FD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Ramlethal_Service_1._2.Pantallas;
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


namespace Ramlethal_Service_1._2.Pantallas {
    
    
    /// <summary>
    /// RegistroUsuarios
    /// </summary>
    public partial class RegistroUsuarios : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Pantallas\RegistroUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid tbc_registronombreusuario;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Pantallas\RegistroUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_registrousuario;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Pantallas\RegistroUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Bnt_regresomenuregistro;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Pantallas\RegistroUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx_registronombre;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Pantallas\RegistroUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx_registrocorreo;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Pantallas\RegistroUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx_confirmarcontrasena;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Ramlethal Service 1.2;component/pantallas/registrousuarios.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pantallas\RegistroUsuarios.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tbc_registronombreusuario = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.btn_registrousuario = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\Pantallas\RegistroUsuarios.xaml"
            this.btn_registrousuario.Click += new System.Windows.RoutedEventHandler(this.btn_registrousuario_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Bnt_regresomenuregistro = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\Pantallas\RegistroUsuarios.xaml"
            this.Bnt_regresomenuregistro.Click += new System.Windows.RoutedEventHandler(this.Bnt_regresomenuregistro_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbx_registronombre = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\..\Pantallas\RegistroUsuarios.xaml"
            this.tbx_registronombre.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbx_registrocorreo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbx_confirmarcontrasena = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

