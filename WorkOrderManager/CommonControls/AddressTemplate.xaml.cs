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
using WorkOrderManager.Classes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WorkOrderManager.CommonControls
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddressTemplate : Page
    {
        public AddressTemplate()
        {
            this.InitializeComponent();
        }


        private void AutoSuggestState_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                if (sender.Text.Length > 1)
                {
                    sender.ItemsSource = this.GetSuggestions(sender.Text);
                }
                else
                {
                    sender.ItemsSource = new string[] { "No Suggestions..." };
                }
            }
        }

        private string[] stateSuggestion = new string[] { "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Conneticuit", "Deleware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" };



        private string[] GetSuggestions(string text)
        {
            string[] result = null;

            result = stateSuggestion.Where(x => x.Contains(text)).ToArray();

            return result;
        }

        public Address getAddress()
        {
            Address address = new Address();

            address.StreetAddress = Address.Text;
            address.Address2 = Address2.Text;
            address.City = City.Text;
            address.State = AutoSuggestState.Text;
            address.ZipCode = ZipCode.Text;

            return address;

        }
    }
}
