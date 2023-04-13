using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class MessageContent : Object
        {
            /// <summary>
            /// The user allowed the bot to send messages
            /// </summary>
            public class MessageBotWriteAccessAllowed : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageBotWriteAccessAllowed";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Information about the Web App, which requested the access; may be null if none or the Web App was opened from the attachment menu
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("web_app")]
                public WebApp WebApp { get; set; }
            }
        }
    }
}