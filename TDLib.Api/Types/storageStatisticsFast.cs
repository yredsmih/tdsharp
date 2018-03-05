using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class StorageStatisticsFast : Structure
    {

        public partial class storageStatisticsFast : StorageStatisticsFast
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "storageStatisticsFast";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("files_size")]
                public long? files_size_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("file_count")]
                public int? file_count_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("database_size")]
                public long? database_size_;

        }

    }

}