﻿#pragma checksum "C:\pls\vsonline\Adhesive\Adhesive.Mongodb.Silverlight\Views\Home.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E9D01BA9EE16465AC55B3D5A29AFA756"
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
    
    
    public partial class Home : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.BusyIndicator Busy;
        
        internal System.Windows.Controls.ScrollViewer PageScrollViewer;
        
        internal System.Windows.Controls.WrapPanel ContentStackPanel;
        
        internal System.Windows.Controls.Button RefreshCategory;
        
        internal System.Windows.Controls.ComboBox CategoryList;
        
        internal System.Windows.Controls.ComboBox DatabaseList;
        
        internal System.Windows.Controls.CheckBox CheckAllTables;
        
        internal System.Windows.Controls.WrapPanel TableListPanel;
        
        internal System.Windows.Controls.ComboBox TimeRange;
        
        internal System.Windows.Controls.Button PrevTimeOffset;
        
        internal System.Windows.Controls.Button CurrentTimeOffset;
        
        internal System.Windows.Controls.Button NextTimeOffset;
        
        internal System.Windows.Controls.DatePicker BeginDate;
        
        internal System.Windows.Controls.TimePicker BeginTime;
        
        internal System.Windows.Controls.DatePicker EndDate;
        
        internal System.Windows.Controls.TimePicker EndTime;
        
        internal System.Windows.Controls.TextBox AddTime;
        
        internal System.Windows.Controls.CheckBox AutoRefresh;
        
        internal System.Windows.Controls.Expander AdvancedSearchPanel;
        
        internal System.Windows.Controls.Border CascadeFilterList;
        
        internal System.Windows.Controls.StackPanel CascadeFilterListPanel;
        
        internal System.Windows.Controls.Border SelectFilterList;
        
        internal System.Windows.Controls.StackPanel SelectFilterListPanel;
        
        internal System.Windows.Controls.Border MultipleSelectFilterList;
        
        internal System.Windows.Controls.StackPanel MultipleSelectFilterListPanel;
        
        internal System.Windows.Controls.Border TextboxFilterList;
        
        internal System.Windows.Controls.StackPanel TextboxFilterListPanel;
        
        internal System.Windows.Controls.StackPanel ViewModelPanel;
        
        internal System.Windows.Controls.CheckBox RemberLastSelection;
        
        internal System.Windows.Controls.Button Search;
        
        internal System.Windows.Controls.TextBox DetailId;
        
        internal System.Windows.Controls.Button SearchDetailOnlyById;
        
        internal System.Windows.Controls.TextBox ContextId;
        
        internal System.Windows.Controls.Button SearchListOnlyByContextId;
        
        internal System.Windows.Controls.TextBox UrlAddress;
        
        internal System.Windows.Controls.Button SearchByUrlAddress;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Adhesive.Mongodb.Silverlight;component/Views/Home.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Busy = ((System.Windows.Controls.BusyIndicator)(this.FindName("Busy")));
            this.PageScrollViewer = ((System.Windows.Controls.ScrollViewer)(this.FindName("PageScrollViewer")));
            this.ContentStackPanel = ((System.Windows.Controls.WrapPanel)(this.FindName("ContentStackPanel")));
            this.RefreshCategory = ((System.Windows.Controls.Button)(this.FindName("RefreshCategory")));
            this.CategoryList = ((System.Windows.Controls.ComboBox)(this.FindName("CategoryList")));
            this.DatabaseList = ((System.Windows.Controls.ComboBox)(this.FindName("DatabaseList")));
            this.CheckAllTables = ((System.Windows.Controls.CheckBox)(this.FindName("CheckAllTables")));
            this.TableListPanel = ((System.Windows.Controls.WrapPanel)(this.FindName("TableListPanel")));
            this.TimeRange = ((System.Windows.Controls.ComboBox)(this.FindName("TimeRange")));
            this.PrevTimeOffset = ((System.Windows.Controls.Button)(this.FindName("PrevTimeOffset")));
            this.CurrentTimeOffset = ((System.Windows.Controls.Button)(this.FindName("CurrentTimeOffset")));
            this.NextTimeOffset = ((System.Windows.Controls.Button)(this.FindName("NextTimeOffset")));
            this.BeginDate = ((System.Windows.Controls.DatePicker)(this.FindName("BeginDate")));
            this.BeginTime = ((System.Windows.Controls.TimePicker)(this.FindName("BeginTime")));
            this.EndDate = ((System.Windows.Controls.DatePicker)(this.FindName("EndDate")));
            this.EndTime = ((System.Windows.Controls.TimePicker)(this.FindName("EndTime")));
            this.AddTime = ((System.Windows.Controls.TextBox)(this.FindName("AddTime")));
            this.AutoRefresh = ((System.Windows.Controls.CheckBox)(this.FindName("AutoRefresh")));
            this.AdvancedSearchPanel = ((System.Windows.Controls.Expander)(this.FindName("AdvancedSearchPanel")));
            this.CascadeFilterList = ((System.Windows.Controls.Border)(this.FindName("CascadeFilterList")));
            this.CascadeFilterListPanel = ((System.Windows.Controls.StackPanel)(this.FindName("CascadeFilterListPanel")));
            this.SelectFilterList = ((System.Windows.Controls.Border)(this.FindName("SelectFilterList")));
            this.SelectFilterListPanel = ((System.Windows.Controls.StackPanel)(this.FindName("SelectFilterListPanel")));
            this.MultipleSelectFilterList = ((System.Windows.Controls.Border)(this.FindName("MultipleSelectFilterList")));
            this.MultipleSelectFilterListPanel = ((System.Windows.Controls.StackPanel)(this.FindName("MultipleSelectFilterListPanel")));
            this.TextboxFilterList = ((System.Windows.Controls.Border)(this.FindName("TextboxFilterList")));
            this.TextboxFilterListPanel = ((System.Windows.Controls.StackPanel)(this.FindName("TextboxFilterListPanel")));
            this.ViewModelPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ViewModelPanel")));
            this.RemberLastSelection = ((System.Windows.Controls.CheckBox)(this.FindName("RemberLastSelection")));
            this.Search = ((System.Windows.Controls.Button)(this.FindName("Search")));
            this.DetailId = ((System.Windows.Controls.TextBox)(this.FindName("DetailId")));
            this.SearchDetailOnlyById = ((System.Windows.Controls.Button)(this.FindName("SearchDetailOnlyById")));
            this.ContextId = ((System.Windows.Controls.TextBox)(this.FindName("ContextId")));
            this.SearchListOnlyByContextId = ((System.Windows.Controls.Button)(this.FindName("SearchListOnlyByContextId")));
            this.UrlAddress = ((System.Windows.Controls.TextBox)(this.FindName("UrlAddress")));
            this.SearchByUrlAddress = ((System.Windows.Controls.Button)(this.FindName("SearchByUrlAddress")));
        }
    }
}

