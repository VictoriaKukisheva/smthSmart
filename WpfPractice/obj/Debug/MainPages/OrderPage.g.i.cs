﻿#pragma checksum "..\..\..\MainPages\OrderPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F111B47755081370E89E5A1C09B14F9D86AC0378A1E1B0116E8678320A2EBF94"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfPractice.MainPages;


namespace WpfPractice.MainPages {
    
    
    /// <summary>
    /// OrderPage
    /// </summary>
    public partial class OrderPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\MainPages\OrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition AdminRow;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\MainPages\OrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TbFinder1;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\MainPages\OrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbFinder;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\MainPages\OrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbSort;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\MainPages\OrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.DatePickerTextBox TbDatePick;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\MainPages\OrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LbOrders;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\MainPages\OrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddFurniture;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\MainPages\OrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TbFindeFurniture;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\MainPages\OrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnChangeToUserTable;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfPractice;component/mainpages/orderpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainPages\OrderPage.xaml"
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
            
            #line 9 "..\..\..\MainPages\OrderPage.xaml"
            ((WpfPractice.MainPages.OrderPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AdminRow = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 3:
            this.TbFinder1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.TbFinder = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\MainPages\OrderPage.xaml"
            this.TbFinder.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbFinder_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CbSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 40 "..\..\..\MainPages\OrderPage.xaml"
            this.CbSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbSort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TbDatePick = ((System.Windows.Controls.Primitives.DatePickerTextBox)(target));
            
            #line 42 "..\..\..\MainPages\OrderPage.xaml"
            this.TbDatePick.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbDatePick_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LbOrders = ((System.Windows.Controls.ListView)(target));
            
            #line 49 "..\..\..\MainPages\OrderPage.xaml"
            this.LbOrders.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.LbOrders_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnAddFurniture = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\..\MainPages\OrderPage.xaml"
            this.BtnAddFurniture.Click += new System.Windows.RoutedEventHandler(this.BtnAddFurniture_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TbFindeFurniture = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.BtnChangeToUserTable = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\MainPages\OrderPage.xaml"
            this.BtnChangeToUserTable.Click += new System.Windows.RoutedEventHandler(this.BtnChangeToUserTable_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
