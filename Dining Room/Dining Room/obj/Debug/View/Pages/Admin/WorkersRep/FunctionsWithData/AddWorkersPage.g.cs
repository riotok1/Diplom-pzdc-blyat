﻿#pragma checksum "..\..\..\..\..\..\..\View\Pages\Admin\WorkersRep\FunctionsWithData\AddWorkersPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AB9F57F9522A7BA95FB650A3F80791860447DE22ECD9B25FB81D8FDCB9A08A5D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Dining_Room.View.Pages.Admin.WorkersRep.FunctionsWithData;
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


namespace Dining_Room.View.Pages.Admin.WorkersRep.FunctionsWithData {
    
    
    /// <summary>
    /// AddWorkersPage
    /// </summary>
    public partial class AddWorkersPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\..\..\..\View\Pages\Admin\WorkersRep\FunctionsWithData\AddWorkersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox surnameTxb;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\..\..\View\Pages\Admin\WorkersRep\FunctionsWithData\AddWorkersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameTxb;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\..\..\View\Pages\Admin\WorkersRep\FunctionsWithData\AddWorkersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox patronymicTxb;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\..\..\View\Pages\Admin\WorkersRep\FunctionsWithData\AddWorkersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox usStaff;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\..\..\..\View\Pages\Admin\WorkersRep\FunctionsWithData\AddWorkersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backBtn;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\..\..\..\View\Pages\Admin\WorkersRep\FunctionsWithData\AddWorkersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Dining Room;component/view/pages/admin/workersrep/functionswithdata/addworkerspa" +
                    "ge.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\View\Pages\Admin\WorkersRep\FunctionsWithData\AddWorkersPage.xaml"
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
            this.surnameTxb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.nameTxb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.patronymicTxb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.usStaff = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.backBtn = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\..\..\..\..\View\Pages\Admin\WorkersRep\FunctionsWithData\AddWorkersPage.xaml"
            this.backBtn.Click += new System.Windows.RoutedEventHandler(this.backBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.addBtn = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\..\..\..\..\View\Pages\Admin\WorkersRep\FunctionsWithData\AddWorkersPage.xaml"
            this.addBtn.Click += new System.Windows.RoutedEventHandler(this.addBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
