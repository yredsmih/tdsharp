using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class UserPrivacySettingRule : Structure
    {

        public partial class userPrivacySettingRuleRestrictUsers : UserPrivacySettingRule
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "userPrivacySettingRuleRestrictUsers";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_ids")]
                public int[] user_ids_;

        }

    }

}