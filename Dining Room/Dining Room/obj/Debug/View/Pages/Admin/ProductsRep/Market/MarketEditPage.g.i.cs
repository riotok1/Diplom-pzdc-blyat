﻿#pragma checksum "..\..\..\..\..\..\..\View\Pages\Admin\ProductsRep\Market\MarketEditPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DAFF1E8B445A9BF3E53B9D4AC96898E40DD4D333692CFB261CF665C730FFE786"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Dining_Room.View.Pages.Admin.ProductsRep.Market;
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


namespace Dining_Room.View.Pages.Admin.ProductsRep.Market {
    
    
    /// <summary>
    /// MarketEditPage
    /// </summary>
    public partial class MarketEditPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\..\..\..\View\Pages\Admin\ProductsRep\Market\MarketEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgLoad;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\..\..\View\Pages\Admin\ProductsRep\Market\MarketEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button openBtn;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\..\..\View\Pages\Admin\ProductsRep\Market\MarketEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox productTxb;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\..\..\..\View\Pages\Admin\ProductsRep\Market\MarketEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox priceTxb;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\..\..\..\View\Pages\Admin\ProductsRep\Market\MarketEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backBtn;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\..\..\..\View\Pages\Admin\ProductsRep\Market\MarketEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Dining Room;component/view/pages/admin/productsrep/market/marketeditpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\View\Pages\Admin\ProductsRep\Market\MarketEditPage.xaml"
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
            this.imgLoad = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.openBtn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\..\..\..\View\Pages\Admin\ProductsRep\Market\MarketEditPage.xaml"
            this.openBtn.Click += new System.Windows.RoutedEventHandler(this.openBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.productTxb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.priceTxb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.backBtn = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\..\..\..\..\View\Pages\Admin\ProductsRep\Market\MarketEditPage.xaml"
            this.backBtn.Click += new System.Windows.RoutedEventHandler(this.backBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.editBtn = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\..\..\..\..\View\Pages\Admin\ProductsRep\Market\MarketEditPage.xaml"
            this.editBtn.Click += new System.Windows.RoutedEventHandler(this.editBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
