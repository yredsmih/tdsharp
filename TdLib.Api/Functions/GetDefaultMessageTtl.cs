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
        /// Returns default message Time To Live setting (self-destruct timer) for new chats
        /// </summary>
        public class GetDefaultMessageTtl : Function<MessageTtl>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getDefaultMessageTtl";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }


        }

        /// <summary>
        /// Returns default message Time To Live setting (self-destruct timer) for new chats
        /// </summary>
        public static Task<MessageTtl> GetDefaultMessageTtlAsync(
            this Client client)
        {
            return client.ExecuteAsync(new GetDefaultMessageTtl
            {
                
            });
        }
    }
}