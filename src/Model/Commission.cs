﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TapfiliateNet.Model
{
    public class Commission
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("approved")]
        public bool? Approved { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("payout")]
        public int? Payout { get; set; }

        [JsonProperty("commission_type")]
        public string CommissionType { get; set; }

        [JsonProperty("conversion_sub_amount")]
        public decimal ConversionSubAmount { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }
}