using System.Runtime.Serialization;

namespace TradeHubSharp.Rest.Enums
{
    public enum CandlesticksResolution
    {
        [EnumMember(Value = "1")] OneMinute = 1,
        [EnumMember(Value = "5")] FiveMinute = 5,
        [EnumMember(Value = "30")] ThirtyMinute = 30,
        [EnumMember(Value = "60")] OneHour = 60,
        [EnumMember(Value = "360")] SixHour = 360,
        [EnumMember(Value = "1440")] OneDay = 1440
    }
}
