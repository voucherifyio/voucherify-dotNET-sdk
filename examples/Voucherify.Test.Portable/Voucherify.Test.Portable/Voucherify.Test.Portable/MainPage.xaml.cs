extern alias Client;
extern alias Server;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Voucherify.Test.Portable
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            InitializeVoucherify().GetAwaiter().GetResult();
        }

        public async Task InitializeVoucherify()
        {
            try
            {
                Client.Voucherify.Client.Api apiClient = new Client.Voucherify.Client.Api("fb1d6851-48e0-4333-9095-610b757a5793", "5e01417d-d50d-401a-b4f2-cc23909ad09c", "*")
                       .WithEndpoint("api-tls12.voucherify.io/client/v1").WithSSL();

                var responseClient = await apiClient.Validations.ValidateVoucher(new Client.Voucherify.DataModel.Queries.VoucherValidation() { Code = "zZAOtkuv" });
                Label label = new Label() {
                    Text = responseClient.ToString(),
                    TextColor = Color.Green,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };
                this.StackLayoutMain.Children.Add(label);

            }
            catch (Client.Voucherify.Core.Exceptions.VoucherifyClientException exClient)
            {
                Label label = new Label() {
                    Text = exClient.ToString(),
                    TextColor = Color.Red,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };
                this.StackLayoutMain.Children.Add(label);
            }

            Server.Voucherify.Api api = new Server.Voucherify.Api("1f2c2d05-42d0-4c78-adee-4beb0c379a47", "485b5d2e-0604-4731-a744-1e544a69c9f1")
                .WithEndpoint("api.voucherify.io/v1").WithSSL();

            try
            {
                var response = await api.Validations.ValidateVoucher("zZAOtkuv", new Server.Voucherify.DataModel.Contexts.Validation());
                Label label = new Label() {
                    Text = response.ToString(),
                    TextColor = Color.Green,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };

                this.StackLayoutMain.Children.Add(label);
            }
            catch (Server.Voucherify.Core.Exceptions.VoucherifyClientException exClient)
            {
                Label label = new Label() {
                    Text = exClient.ToString(),
                    TextColor = Color.Red,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };

                this.StackLayoutMain.Children.Add(label);
            }
        }
    }
}
