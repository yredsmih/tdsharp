using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class ResendChangePhoneNumberCode : Function<AuthenticationCodeInfo>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "resendChangePhoneNumberCode";

            [JsonProperty("@extra")] public override string Extra { get; set; }
        }
    }
}