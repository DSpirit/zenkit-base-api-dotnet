using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Zenkit.Api.Base.Models
{
    public class Filter
    {
        [JsonPropertyName("filter")]
        public FilterExpression FilterExpression { get; set; }

        [JsonPropertyName("groupByElementId")]
        public int? GroupByElementId { get; set; }

        [JsonPropertyName("limit")]
        public int? Limit { get; set; }

        [JsonPropertyName("skip")]
        public int? Skip { get; set; }
    }

    public class FilterExpression
    {
        [JsonPropertyName("AND")]
        public AND And { get; set; }

        [JsonPropertyName("OR")]
        public OR Or { get; set; }
    }

    public class AND
    {
        [JsonPropertyName("TERMS")]
        public List<Term> Terms { get; set; }
    }

    public class OR
    {
        [JsonPropertyName("TERMS")]
        public List<Term> Terms { get; set; }
    }

    public class Term
    {
        [JsonPropertyName("elementId")]
        public int ElementId { get; set; }

        [JsonPropertyName("modus")]
        public FilterTermModus Modus { get; set; }

        [JsonPropertyName("negated")]
        public bool Negated { get; set; }

        [JsonPropertyName("filterReferences")]
        public List<string> FilterReferences { get; set; }

        [JsonPropertyName("filterCategories")]
        public List<int> FilterCategories { get; set; }

        [JsonPropertyName("dateType")]
        public DateFilterTermModus DateType { get; set; }

        [JsonPropertyName("dateFrom")]
        public DateTime? DateFrom { get; set; }

        [JsonPropertyName("dateTo")]
        public DateTime? DateTo { get; set; }

        [JsonPropertyName("checked")]
        public bool? Checked { get; set; }

        public int? Level { get; set; }
    }
}