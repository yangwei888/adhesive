﻿#pragma checksum "C:\pls\vsonline\Adhesive\Adhesive.Mongodb.Silverlight\Views\ViewListData.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BA608F52B7B38D874601404637A9206A"
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
    
    
    public partial class ViewListData : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal BusyIndicator Busy;
        
        internal System.Windows.Controls.ScrollViewer PageScrollViewer;
        
        internal System.Windows.Controls.StackPanel ContentStackPanel;
        
        internal System.Windows.Controls.TextBox PageSize;
        
        internal System.Windows.Controls.Button Refresh;
        
        internal System.Windows.Controls.Button Detail;
        
        internal System.Windows.Controls.Button Stat;
        
        internal System.Windows.Controls.Button Group;
        
        internal System.Windows.Controls.Button CopyUrlAddress;
        
        internal System.Windows.Controls.TextBlock RangeDetail;
        
        internal System.Windows.Controls.TabControl ListGridTab;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Adhesive.Mongodb.Silverlight;component/Views/ViewListData.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Busy = ((BusyIndicator)(this.FindName("Busy")));
            this.PageScrollViewer = ((System.Windows.Controls.ScrollViewer)(this.FindName("PageScrollViewer")));
            this.ContentStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentStackPanel")));
            this.PageSize = ((System.Windows.Controls.TextBox)(this.FindName("PageSize")));
            this.Refresh = ((System.Windows.Controls.Button)(this.FindName("Refresh")));
            this.Detail = ((System.Windows.Controls.Button)(this.FindName("Detail")));
            this.Stat = ((System.Windows.Controls.Button)(this.FindName("Stat")));
            this.Group = ((System.Windows.Controls.Button)(this.FindName("Group")));
            this.CopyUrlAddress = ((System.Windows.Controls.Button)(this.FindName("CopyUrlAddress")));
            this.RangeDetail = ((System.Windows.Controls.TextBlock)(this.FindName("RangeDetail")));
            this.ListGridTab = ((System.Windows.Controls.TabControl)(this.FindName("ListGridTab")));
        }
    }
}
