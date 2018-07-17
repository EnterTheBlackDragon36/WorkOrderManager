using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WorkOrderManager.CommonControls;
using WorkOrderManager.Forms;
using WorkOrderManager.Views;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WorkOrderManager.Navigation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MenuNavigation : Page
    {
        public MenuNavigation()
        {
            this.InitializeComponent();
        }

        #region Navigation Controls

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void NavigationList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if(PivotPreview.IsSelected)
            {
                Content.Navigate(typeof(PreviewPivot));
            }
            else if (WorkOrders.IsSelected)
            {
                Content.Navigate(typeof(WorkOrders));
            }
            else if (Companies.IsSelected)
            {
                Content.Navigate(typeof(Companies));
            }
            else if (Contacts.IsSelected)
            {
                Content.Navigate(typeof(Contacts));
            }
            else if (Settings.IsSelected)
            {
                Content.Navigate(typeof(Settings));
            }
            else if (CurrentUser.IsSelected)
            {
                Content.Navigate(typeof(UserAccount));
            }
        }

        #endregion
    }
}
