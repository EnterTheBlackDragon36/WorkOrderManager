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
    public sealed partial class NewWorkOrder : Page
    {
        public NewWorkOrder()
        {
            this.InitializeComponent();
            //By default Inking only accepts input from the stylus (pen) only. Following enables all other input
            inkSignatureCanvas.InkPresenter.InputDeviceTypes = Windows.UI.Core.CoreInputDeviceTypes.Mouse | Windows.UI.Core.CoreInputDeviceTypes.Touch;
        }

        public void retrieveCompanyAddress()
        {
            Company company = new Company();
            company.CompanyAddress.StreetAddress = txtstreetAddress.Text;
            company.CompanyAddress.City = txtcity.Text;
            company.CompanyAddress.State = txtstate.Text;
            company.CompanyAddress.ZipCode = txtzipcode.Text;            
        }
    }
}
