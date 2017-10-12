using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapfiliateNet.Model
{
    public abstract class AffiliateBase
    {
        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("lastname")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("meta_data")]
        public IDictionary<string, string> Metadata { get; set; }

        [JsonProperty("company")]
        public AffiliateCompany Company { get; set; }

        [JsonProperty("address")]
        public AffiliateAddress Address { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }
    }

    public class AffiliateCompany
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class AffiliateAddress
    {
        [JsonProperty("address")]
        public string StreetAddress { get; set; }

        [JsonProperty("address_two")]
        public string StreetAddressTwo { get; set; }

        [JsonProperty("postal_code")]
        public string Postcode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public AffiliateAddressCountry Country { get; set; }
    }

    public class AffiliateAddressCountry
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
