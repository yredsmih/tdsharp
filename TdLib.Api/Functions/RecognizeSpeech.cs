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
        /// Recognizes speech in a video note or a voice note message. The message must be successfully sent and must not be scheduled. May return an error with a message "MSG_VOICE_TOO_LONG" if media duration is too big to be recognized
        /// </summary>
        public class RecognizeSpeech : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "recognizeSpeech";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat to which the message belongs
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifier of the message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }
        }

        /// <summary>
        /// Recognizes speech in a video note or a voice note message. The message must be successfully sent and must not be scheduled. May return an error with a message "MSG_VOICE_TOO_LONG" if media duration is too big to be recognized
        /// </summary>
        public static Task<Ok> RecognizeSpeechAsync(
            this Client client, long chatId = default, long messageId = default)
        {
            return client.ExecuteAsync(new RecognizeSpeech
            {
                ChatId = chatId, MessageId = messageId
            });
        }
    }
}