using System.Text.Json;
using System.Text.Json.Serialization;

namespace Assingment_EFCore.Application.Models.Requests
{
    internal class DateOnlyJsonConverter : JsonConverter<DateOnly>
    {
        public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string dateString = reader.GetString();
            if (DateOnly.TryParse(dateString, out DateOnly date))
            {
                return date;
            }
            throw new JsonException("Invalid date format");
        }

        public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}