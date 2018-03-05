using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class MessageContent : Structure
    {

        public partial class messageBasicGroupChatCreate : MessageContent
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "messageBasicGroupChatCreate";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string title_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("member_user_ids")]
                public int[] member_user_ids_;

        }

    }

}