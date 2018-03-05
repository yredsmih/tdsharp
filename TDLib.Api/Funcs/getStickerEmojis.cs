using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class getStickerEmojis : Method<StickerEmojis>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "getStickerEmojis";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sticker")]
                public InputFile sticker_;

        }

    }

}