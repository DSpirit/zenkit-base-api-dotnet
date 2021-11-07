using System;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Zenkit.Base.Api.Models
{

    [Serializable]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FilterKeys
    {
        [Description("text")]
        Text,
        [Description("numberFrom")]
        NumberFrom,
        [Description("numberTo")]
        NumberTo,
        [Description("dateType")]
        DateType,
        [Description("dateFrom")]
        DateFrom,
        [Description("dateTo")]
        DateTo,
        [Description("checked")]
        Checked,
        [Description("filterCategories")]
        FilterCategories,
        [Description("filterPersons")]
        FilterPersons,
        [Description("filterReferences")]
        FilterReferences,
        [Description("level")]
        Level
    }

    [Serializable]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FilterTermModus
    {
        [Description("isEmpty")]
        IsEmpty,
        [Description("isNotEmpty")]
        IsNotEmpty,
        [Description("contains")]
        Contains,
        [Description("notContains")]
        NotContains,
        [Description("equals")]
        Equals,
        [Description("notEquals")]
        NotEquals,
        [Description("startsWith")]
        StartsWith,
        [Description("notStartsWith")]
        NotStartsWith,
        [Description("endsWith")]
        EndsWith,
        [Description("notEndsWith")]
        NotEndsWith,
        [Description("inRange")]
        InRange,
        [Description("notInRange")]
        NotInRange,
        [Description("greaterOrEqual")]
        GreaterOrEqual,
        [Description("lessOrEqual")]
        LessOrEqual,
    }

    public enum DateFilterTermModus
    {
        Any = 0,
        ThisYear = 1,
        ThisMonth = 2,
        ThisWeek = 3,
        Yesterday = 4,
        Today = 5,
        Tomorrow = 6,
        NextWeek = 7,
        NextMonth = 8,
        NextYear = 9,
        Custom = 10,
        LastWeek = 11,
        LastMonth = 12,
        LastYear = 13,
        Empty = 14,
        NotEmpty = 15
    }
}