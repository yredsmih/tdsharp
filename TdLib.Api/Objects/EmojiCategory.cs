using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Contains a list of similar emoji to search for in getStickers and searchStickers
        /// </summary>
        public partial class EmojiCategory : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "emojiCategory";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Name of the category
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("name")]
            public string Name { get; set; }

            /// <summary>
            /// Custom emoji sticker, which represents icon of the category
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("icon")]
            public Sticker Icon { get; set; }

            /// <summary>
            /// List of emojis in the category
            /// </summary>
            [JsonProperty("emojis", ItemConverterType = typeof(Converter))]
            public string[] Emojis { get; set; }
        }
    }
}