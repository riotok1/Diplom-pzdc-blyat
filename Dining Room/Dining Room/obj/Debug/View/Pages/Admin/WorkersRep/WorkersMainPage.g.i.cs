﻿#pragma checksum "..\..\..\..\..\..\View\Pages\Admin\WorkersRep\WorkersMainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7F869B25076AEB9ECBB73EAAC23F335FD3190CE7A3356F3583D603F33C63D6D2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Dining_Room.View.Pages.Admin.WorkersRep;
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


namespace Dining_Room.View.Pages.Admin.WorkersRep {
    
    
    /// <summary>
    /// WorkersMainPage
    /// </summary>
    public partial class WorkersMainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\..\..\View\Pages\Admin\WorkersRep\WorkersMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button workersBtn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\..\View\Pages\Admin\WorkersRep\WorkersMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button postsBtn;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\..\View\Pages\Admin\WorkersRep\WorkersMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Dining Room;component/view/pages/admin/workersrep/workersmainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\View\Pages\Admin\WorkersRep\WorkersMainPage.xaml"
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
            
            #line 7 "..\..\..\..\..\..\View\Pages\Admin\WorkersRep\WorkersMainPage.xaml"
            ((Dining_Room.View.Pages.Admin.WorkersRep.WorkersMainPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.workersBtn = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\..\..\View\Pages\Admin\WorkersRep\WorkersMainPage.xaml"
            this.workersBtn.Click += new System.Windows.RoutedEventHandler(this.workersBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.postsBtn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\..\..\View\Pages\Admin\WorkersRep\WorkersMainPage.xaml"
            this.postsBtn.Click += new System.Windows.RoutedEventHandler(this.postsBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.backBtn = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\..\..\View\Pages\Admin\WorkersRep\WorkersMainPage.xaml"
            this.backBtn.Click += new System.Windows.RoutedEventHandler(this.backBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
