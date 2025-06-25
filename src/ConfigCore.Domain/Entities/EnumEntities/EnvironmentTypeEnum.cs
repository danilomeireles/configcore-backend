using System.Text.Json.Serialization;

namespace ConfigCore.Domain.Entities.EnumEntities;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum EnvironmentTypeEnum
{
    Development = 1,
    Staging = 2,
    Production = 3
}