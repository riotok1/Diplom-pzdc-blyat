#pragma checksum "..\..\..\..\..\..\View\Pages\Admin\WorkersRep\StaffViewPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8A53FABD609FF23440C126EBDFC9F138F994C231A4303B28AA78D2B999F1DA10"
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
    /// StaffViewPage
    /// </summary>
    public partial class StaffViewPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\..\..\View\Pages\Admin\WorkersRep\StaffViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listDataView;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\..\View\Pages\Admin\WorkersRep\StaffViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bacKBtn;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\..\View\Pages\Admin\WorkersRep\StaffViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button wordBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Dining Room;component/view/pages/admin/workersrep/staffviewpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\View\Pages\Admin\WorkersRep\StaffViewPage.xaml"
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
            
            #line 7 "..\..\..\..\..\..\View\Pages\Admin\WorkersRep\StaffViewPage.xaml"
            ((Dining_Room.View.Pages.Admin.WorkersRep.StaffViewPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.listDataView = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.bacKBtn = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\..\..\View\Pages\Admin\WorkersRep\StaffViewPage.xaml"
            this.bacKBtn.Click += new System.Windows.RoutedEventHandler(this.bacKBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.wordBtn = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\..\..\View\Pages\Admin\WorkersRep\StaffViewPage.xaml"
            this.wordBtn.Click += new System.Windows.RoutedEventHandler(this.wordBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

