using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class ThumbnailFormat : Object
        {
            /// <summary>
            /// The thumbnail is in static GIF format. It will be used only for some bot inline results
            /// </summary>
            public class ThumbnailFormatGif : ThumbnailFormat
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "thumbnailFormatGif";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }


            }
        }
    }
}