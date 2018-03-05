using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class recoverAuthenticationPassword : Method<Ok>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "recoverAuthenticationPassword";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("recovery_code")]
                public string recovery_code_;

        }

    }

}