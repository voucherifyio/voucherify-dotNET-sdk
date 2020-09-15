using System;
using System.Collections.Generic;

namespace Voucherify.DataModel.Contexts
{
    public class CustomerConsentUpdate : Dictionary<String, Boolean>
    {
        private const String UnsubscribedKey = "unsubscribed";

        public CustomerConsentUpdate()
        {
        }

        public CustomerConsentUpdate unsubscribeAll ()
        {
            this.Clear();
            this.Add(UnsubscribedKey, true);
            return this;
        }

        public CustomerConsentUpdate subscribeAll()
        {
            this.Clear();
            this.Add(UnsubscribedKey, false);
            return this;
        }

        public CustomerConsentUpdate subscribeTo (String id)
        {
            if (this.ContainsKey(id))
            {
                this[id] = true;
            }
            else
            {
                this.Add(id, true);
            }

            return this;
        }

        public CustomerConsentUpdate unsubscribFrom(String id)
        {
            if (this.ContainsKey(id))
            {
                this[id] = false;
            }
            else
            {
                this.Add(id, false);
            }

            return this;
        }
    }
}
