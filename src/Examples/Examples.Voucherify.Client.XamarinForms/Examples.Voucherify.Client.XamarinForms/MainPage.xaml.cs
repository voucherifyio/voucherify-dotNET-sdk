using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using V = Voucherify;

namespace Examples.Voucherify.Client.XamarinForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string[] args)
        {
            InitializeComponent();
            InitilizeVoucherify(args);
        }

        public void InitilizeVoucherify(string[] args)
        {
            AddLabel(string.Format("[init] AppId: {0} AppToken: {1}", args[0], args[1]));
            V.Client.Api voucherifyApi = new V.Client.Api(args[0], args[1], "dotNetRepoExample");

            if (args.Length > 3)
            {
                AddLabel(string.Format("[init] Changing Endpoint. Address: {0}", args[2]));
                voucherifyApi = voucherifyApi.WithEndpoint(args[2]);
            }
            
            AddLabel(string.Format("[run] Channel: {0}", voucherifyApi.Channel));
 
            try
            {
                var result = voucherifyApi.Validations.ValidateVoucher(
                    new V.DataModel.Queries.VoucherValidation()
                    {
                        Code = args.Length > 3 ? args[3] : args[2]
                    }).GetAwaiter().GetResult();

                AddLabel(string.Format("[success] {0}", result));
            }
            catch (V.Core.Exceptions.VoucherifyClientException e)
            {
                AddLabel(string.Format("[error] {0}", e));
            }
        }

        private void AddLabel(string message)
        {
            this.layout.Children.Add(new Label()
            {
                Text = message,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            }); 
        }
    }
}
