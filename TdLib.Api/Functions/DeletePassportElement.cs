using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Deletes a Telegram Passport element
        /// </summary>
        public class DeletePassportElement : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "deletePassportElement";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Element type
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("type")]
            public PassportElementType Type { get; set; }
        }

        /// <summary>
        /// Deletes a Telegram Passport element
        /// </summary>
        public static Task<Ok> DeletePassportElementAsync(
            this Client client, PassportElementType type = default)
        {
            return client.ExecuteAsync(new DeletePassportElement
            {
                Type = type
            });
        }
    }
}