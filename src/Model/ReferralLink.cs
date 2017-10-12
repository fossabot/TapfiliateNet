using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapfiliateNet.Model
{
    public class ReferralLink
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("asset_id")]
        public string AssetId { get; set; }

        [JsonProperty("source_id")]
        public string SourceId { get; set; }
    }
}
