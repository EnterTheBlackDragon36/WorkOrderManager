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

namespace WorkOrderManager.Forms
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NewCompany : Page
    {
        public NewCompany()
        {
            this.InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {

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

        #region CRUD Controls

        //public int AddLang(string langTitle)
        //{
        //    int result = -1;

        //    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
        //    {
        //        conn.Open();
        //        using (SQLiteCommand cmd = new SQLiteCommand(conn))
        //        {
        //            cmd.CommandText = "INSERT INTO Language(LangTitle) VALUES(@Lang)";
        //            cmd.Prepare();
        //            cmd.Parameters.AddWithValue("@Lang", langTitle);
        //            try
        //            {
        //                result = cmd.ExecuteNonQuery();
        //            }
        //            catch (SQLiteException e)
        //            {

        //            }
        //        }
        //        conn.Close();
        //    }
        //    return result;
        //}


        //public int UpdateLang(int id, string newLangTitle)
        //{
        //    int result = -1;
        //    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
        //    {
        //        conn.Open();
        //        using (SQLiteCommand cmd = new SQLiteCommand(conn))
        //        {
        //            cmd.CommandText = "UPDATE Language SET LangTitle = @Lang WHERE Id = @Id";
        //            cmd.Prepare();
        //            cmd.Parameters.AddWithValue("@Lang", newLangTitle);
        //            cmd.Parameters.AddWithValue("@Id", id);
        //            try
        //            {
        //                result = cmd.ExecuteNonQuery();
        //            }
        //            catch (SQLiteException e)
        //            {

        //            }
        //        }
        //        conn.Close();
        //    }

        //    return result;
        //}


        //public int DeleteLang(int id)
        //{
        //    int result = -1;
        //    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
        //    {
        //        conn.Open();
        //        using (SQLiteCommand cmd = new SQLiteCommand(conn))
        //        {
        //            cmd.CommandText = "DELETE FROM Language WHERE Id = @I";
        //            cmd.Prepare();
        //            cmd.Parameters.AddWithValue("@I", id);
        //            try
        //            {
        //                result = cmd.ExecuteNonQuery();
        //            }
        //            catch (SQLiteException e)
        //            {

        //            }
        //        }
        //        conn.Close();
        //    }
        //    return result;
        //}

        #endregion


        private void getCompany()
        {
            Company company = new Company();
            
            company.CompanyName = companyName.Text;
            company.CompanyPhone = companyPhoneNumber.Text;
            company.CompanyFax = companyFaxNumber.Text;
            company.companyWebAddress = companyWebsite.Text;

            company.CompanyAddress.StreetAddress = companyAddress.Text;
            company.CompanyAddress.Address2 = companyAddress2.Text;
            company.CompanyAddress.City = City.Text;
            company.CompanyAddress.State = companyState.Text;
            company.CompanyAddress.ZipCode = companyZipCode.Text;
                        
        }
    }
}
