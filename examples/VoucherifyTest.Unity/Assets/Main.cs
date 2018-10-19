using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Main : MonoBehaviour {

    public string message = "Hello World";

    // Use this for initialization
    void Start()
    {
        Voucherify.Client.Api api = new Voucherify.Client.Api("fb1d6851-48e0-4333-9095-610b757a5793", "5e01417d-d50d-401a-b4f2-cc23909ad09c", "*")
            .WithEndpoint("api.voucherify.io/client/v1");


        api.Validations.ValidateVoucher(
            new Voucherify.DataModel.Queries.VoucherValidation() { Code = "zZAOtkuv" },
            (response) => {
                if (response.Exception != null)
                {
                    message = "Exception: " + response.Exception.ToString();
                }
                else
                {
                    message = "Voucher:" + response.Result.ToString();
                }

                Canvas.ForceUpdateCanvases();
            });
    }

    void OnGUI()
    {
        GUILayout.Label(message);
    }
}
