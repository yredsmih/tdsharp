using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class TerminateSession : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "terminateSession";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter.Int64))]
        [JsonProperty("session_id")]
        public Int64 SessionId { get; set; }

    }

}