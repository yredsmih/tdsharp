using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class getTextEntities : Method<TextEntities>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "getTextEntities";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("text")]
                public string text_;

        }

    }

}