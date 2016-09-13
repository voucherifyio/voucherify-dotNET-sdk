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
using Voucherify.Client;
using Voucherify.Client.DataModel;
using Voucherify.Client.Exceptions;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Voucherify.Client.net45.Portable.Example
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private const string app_token = "<your_app_token>";
        private const string app_id = "<your_app_id>";

        public MainPage()
        {
            this.InitializeComponent();
            this.TestVoucherify();
        }

        public async void TestVoucherify()
        {
            VoucherifyClient client = new VoucherifyClient(app_id, app_token).WithSSL();

            try
            {
                Voucher newVoucher = new Voucher()
                {
                    Discount = Discount.WithAmountOff(10),
                    Type = VoucherType.DiscountVoucher
                };

                Voucher voucher =await  client.Vouchers.CreateVoucher(newVoucher);
                this.textBlockResult.Text = string.Format("Voucher. Code: {0} Campaign: {1} Category: {2} Discount: {3}", voucher.Code, voucher.Campaign, voucher.Category, voucher.Discount.Type.ToString());
            }
            catch (Exception exception)
            {
                this.textBlockEror.Text = exception.ToString();
            }
        }
    }
}