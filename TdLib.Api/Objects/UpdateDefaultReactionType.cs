using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class Update : Object
        {
            /// <summary>
            /// The type of default reaction has changed
            /// </summary>
            public class UpdateDefaultReactionType : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateDefaultReactionType";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The new type of the default reaction
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("reaction_type")]
                public ReactionType ReactionType { get; set; }
            }
        }
    }
}