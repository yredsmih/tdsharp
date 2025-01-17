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
        /// Sets default administrator rights for adding the bot to channel chats; for bots only
        /// </summary>
        public class SetDefaultChannelAdministratorRights : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setDefaultChannelAdministratorRights";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Default administrator rights for adding the bot to channels; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("default_channel_administrator_rights")]
            public ChatAdministratorRights DefaultChannelAdministratorRights { get; set; }
        }

        /// <summary>
        /// Sets default administrator rights for adding the bot to channel chats; for bots only
        /// </summary>
        public static Task<Ok> SetDefaultChannelAdministratorRightsAsync(
            this Client client, ChatAdministratorRights defaultChannelAdministratorRights = default)
        {
            return client.ExecuteAsync(new SetDefaultChannelAdministratorRights
            {
                DefaultChannelAdministratorRights = defaultChannelAdministratorRights
            });
        }
    }
}