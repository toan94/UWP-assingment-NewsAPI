﻿#pragma checksum "C:\Users\justm\OneDrive\Desktop\napi\App1\App1\ArticleView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8C671D3E2C4D6503EB65DADD02B3B3A2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1
{
    partial class ArticleView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // ArticleView.xaml line 14
                {
                    this.btnHomePage = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnHomePage).Click += this.BtnHomePage_Click;
                }
                break;
            case 3: // ArticleView.xaml line 15
                {
                    this.bookmarkBtn = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.bookmarkBtn).Click += this.bookmarkBtn_Click;
                }
                break;
            case 4: // ArticleView.xaml line 22
                {
                    this.Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 5: // ArticleView.xaml line 23
                {
                    this.Author = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // ArticleView.xaml line 24
                {
                    this.Title = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // ArticleView.xaml line 25
                {
                    this.Description = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // ArticleView.xaml line 26
                {
                    this.Content = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

