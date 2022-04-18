using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class MessageForwardOrigin : Object
        {
            /// <summary>
            /// The message was imported from an exported message history
            /// </summary>
            public class MessageForwardOriginMessageImport : MessageForwardOrigin
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageForwardOriginMessageImport";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Name of the sender
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("sender_name")]
                public string SenderName { get; set; }
            }
        }
    }
}