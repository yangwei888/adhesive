﻿#pragma checksum "C:\pls\vsonline\Adhesive\Adhesive.Mongodb.Silverlight\Views\AlarmDetail.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "39C00E23896B98238F48393552B0A7E1"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.19448
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Adhesive.Mongodb.Silverlight {
    
    
    public partial class AlarmDetail : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.BusyIndicator Busy;
        
        internal System.Windows.Controls.ScrollViewer PageScrollViewer;
        
        internal System.Windows.Controls.StackPanel ContentStackPanel;
        
        internal System.Windows.Controls.StackPanel DetailTable;
        
        internal System.Windows.Controls.DataGrid DetailGrid;
        
        internal System.Windows.Controls.StackPanel DetailChange;
        
        internal System.Windows.Controls.TextBlock Welcome;
        
        internal System.Windows.Controls.TextBox message;
        
        internal System.Windows.Controls.TextBlock Errormessage;
        
        internal System.Windows.Controls.TextBox mail;
        
        internal System.Windows.Controls.TextBlock Errormail;
        
        internal System.Windows.Controls.Button change;
        
        internal System.Windows.Controls.Button finish;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Adhesive.Mongodb.Silverlight;component/Views/AlarmDetail.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Busy = ((System.Windows.Controls.BusyIndicator)(this.FindName("Busy")));
            this.PageScrollViewer = ((System.Windows.Controls.ScrollViewer)(this.FindName("PageScrollViewer")));
            this.ContentStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentStackPanel")));
            this.DetailTable = ((System.Windows.Controls.StackPanel)(this.FindName("DetailTable")));
            this.DetailGrid = ((System.Windows.Controls.DataGrid)(this.FindName("DetailGrid")));
            this.DetailChange = ((System.Windows.Controls.StackPanel)(this.FindName("DetailChange")));
            this.Welcome = ((System.Windows.Controls.TextBlock)(this.FindName("Welcome")));
            this.message = ((System.Windows.Controls.TextBox)(this.FindName("message")));
            this.Errormessage = ((System.Windows.Controls.TextBlock)(this.FindName("Errormessage")));
            this.mail = ((System.Windows.Controls.TextBox)(this.FindName("mail")));
            this.Errormail = ((System.Windows.Controls.TextBlock)(this.FindName("Errormail")));
            this.change = ((System.Windows.Controls.Button)(this.FindName("change")));
            this.finish = ((System.Windows.Controls.Button)(this.FindName("finish")));
        }
    }
}
