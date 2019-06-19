using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Voucherify.Client;

public class Main : MonoBehaviour {

    public string message = "Welcome to Unity!";

    // Use this for initialization
    void Start () {
        StartVoucherify(new string[]
        {
            "<app-id>", "<app-token>", "<your-code>"
        }); 
    }

    void StartVoucherify(string[] args)
    {
        addMessage(string.Format("[init] AppId: {0}, AppToken: {1}", args[0], args[1]));
        Api voucherifyApi = new Api(args[0], args[1], "dotNetRepoExample");

        if (args.Length > 3)
        {
            addMessage(string.Format("[init] Changing Host. Address: {0}", args[2]));
            voucherifyApi = voucherifyApi.WithHost(args[2]);
        }

        addMessage(string.Format("[run] Channel: {0}", voucherifyApi.Channel));

        try
        {
            var result = voucherifyApi.Validations.ValidateVoucher(
                new Voucherify.DataModel.Queries.VoucherValidation()
                {
                    Code = args.Length > 3 ? args[3] : args[2]
                }).GetAwaiter().GetResult();

            addMessage(string.Format("[success] Result: {0}", result));
        }
        catch (Voucherify.Core.Exceptions.VoucherifyClientException e)
        {
            addMessage(string.Format("[error] Error: {0}", e));
        }
    }

    void addMessage(string msg)
    {
        message += "\n" + msg;
        Canvas.ForceUpdateCanvases();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        GUILayout.Label(message);
    }
}
