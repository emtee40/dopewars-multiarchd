// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using DopeWars.Domain;
//
//    var drug = Drug.FromJson(jsonString);

namespace DopeWars.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Drug
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Price")]
        public long Price { get; set; }

        [JsonProperty("Amount")]
        public long Amount { get; set; }

        [JsonProperty("WeightType")]
        public string WeightType { get; set; }

        [JsonProperty("Available")]
        public bool Available { get; set; }
    }

    public partial class Drug
    {
        public static Drug[] FromJson(string json) => JsonConvert.DeserializeObject<Drug[]>(json, DopeWars.Domain.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Drug[] self) => JsonConvert.SerializeObject(self, DopeWars.Domain.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
