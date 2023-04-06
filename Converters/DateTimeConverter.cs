using Newtonsoft.Json;
using System;
using System.Diagnostics;
using smart_backend.Utilities;

namespace smart_backend.Converters

{
    public class DateTimeConverter : JsonConverter<DateTime?>
    {

        public override void WriteJson(JsonWriter writer, DateTime? value, JsonSerializer serializer)
        {
            if (value.IsNull())
            {
                writer.WriteNull();
            }
            else
            {
                Debug.Assert(value != null, nameof(value) + " != null");
                writer.WriteValue(value.Value.ToString("yyyy-MM-ddTHH:mm:sszzz"));
            }
        }

        public override DateTime? ReadJson(JsonReader reader, Type objectType, DateTime? existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            // var date = TimeZoneInfo
            //     .ConvertTimeBySystemTimeZoneId(, "America/Lima");
            return DateTime.Parse(reader.Value.ToString());
        }

    }
}
