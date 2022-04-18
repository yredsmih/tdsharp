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
        /// Contains information about a group call participant's video channel
        /// </summary>
        public partial class GroupCallParticipantVideoInfo : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "groupCallParticipantVideoInfo";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// List of synchronization source groups of the video
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("source_groups")]
            public GroupCallVideoSourceGroup[] SourceGroups { get; set; }

            /// <summary>
            /// Video channel endpoint identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("endpoint_id")]
            public string EndpointId { get; set; }

            /// <summary>
            /// True if the video is paused. This flag needs to be ignored, if new video frames are received
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_paused")]
            public bool IsPaused { get; set; }
        }
    }
}