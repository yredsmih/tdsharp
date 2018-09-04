using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class PageBlock : Object
        {
            public class PageBlockCollage : PageBlock
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "pageBlockCollage";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("page_blocks")]
                public PageBlock[] PageBlocks { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("caption")]
                public RichText Caption { get; set; }
            }
        }
    }
}