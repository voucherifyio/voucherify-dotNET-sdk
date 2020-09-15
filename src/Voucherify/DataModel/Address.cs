#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT    
using System;   
using System.Collections.Generic;   
using System.Text;  
using Newtonsoft.Json;  

namespace Voucherify.DataModel  
{   
    [JsonObject]    
    public class Address    
    {   
        [JsonProperty(PropertyName = "city")]   
        public string City { get; set; }    

        [JsonProperty(PropertyName = "state")]  
        public string State { get; set; }   

        [JsonProperty(PropertyName = "line_1")] 
        public string Line1 { get; set; }   

        [JsonProperty(PropertyName = "line_2")] 
        public string Line2 { get; set; }   

        [JsonProperty(PropertyName = "country")]    
        public string Country { get; set; } 

        [JsonProperty(PropertyName = "postal_code")]    
        public string PostalCode { get; set; }  

        public override string ToString()   
        {   
            return string.Format("Address(Country={0},City={1})", this.Country, this.City); 
        }   
    }   
}   
#endif 