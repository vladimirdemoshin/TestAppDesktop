﻿#pragma checksum "..\..\Admin.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "164D3B1AD59D02E3E7572A3014705930"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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


namespace TestApp.Client {
    
    
    /// <summary>
    /// Admin
    /// </summary>
    public partial class Admin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel TransactionStack;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ItemsListView;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnShowItems;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBoxItemID;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBoxDescription;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBoxPrice;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddItem;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRemoveSelectedItem;
        
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
            System.Uri resourceLocater = new System.Uri("/TestApp.Client;component/admin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Admin.xaml"
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
            this.TransactionStack = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.ItemsListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.BtnShowItems = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\Admin.xaml"
            this.BtnShowItems.Click += new System.Windows.RoutedEventHandler(this.BtnShowItemsClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TxtBoxItemID = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\Admin.xaml"
            this.TxtBoxItemID.GotFocus += new System.Windows.RoutedEventHandler(this.TxtBoxItemID_GotFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TxtBoxDescription = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\Admin.xaml"
            this.TxtBoxDescription.GotFocus += new System.Windows.RoutedEventHandler(this.TxtBoxDescription_GotFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TxtBoxPrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\Admin.xaml"
            this.TxtBoxPrice.GotFocus += new System.Windows.RoutedEventHandler(this.TxtBoxPrice_GotFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnAddItem = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\Admin.xaml"
            this.BtnAddItem.Click += new System.Windows.RoutedEventHandler(this.BtnAddItemClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnRemoveSelectedItem = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\Admin.xaml"
            this.BtnRemoveSelectedItem.Click += new System.Windows.RoutedEventHandler(this.BtnRemoveSelectedItemClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

