﻿#pragma checksum "c:\Users\Amar.B\Documents\Visual Studio 2015\Projects\UWP\UWP\Pogled\DodajKnjiguStranica.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BD3BA04A84C628C6B9B5E7F6B24F8800"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UWP.Pogled
{
    partial class DodajKnjiguStranica : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.podlogaStranice = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 39 "..\..\..\Pogled\DodajKnjiguStranica.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.vratiIzbornikStranicu;
                    #line default
                }
                break;
            case 3:
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 32 "..\..\..\Pogled\DodajKnjiguStranica.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.otvoriPodloguIzbornika;
                    #line default
                }
                break;
            case 4:
                {
                    this.kontrolaNaslov = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.kontrolaAutori = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
                {
                    this.kontrolaISBN = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.kontrolaIzdavac = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.kontrolaGodinaIzdanja = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 9:
                {
                    global::Windows.UI.Xaml.Controls.Button element9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 125 "..\..\..\Pogled\DodajKnjiguStranica.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element9).Click += this.ponistiKnjigu;
                    #line default
                }
                break;
            case 10:
                {
                    global::Windows.UI.Xaml.Controls.Button element10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 131 "..\..\..\Pogled\DodajKnjiguStranica.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element10).Click += this.dodajKnjigu;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

