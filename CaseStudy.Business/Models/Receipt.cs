using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CaseStudy.Business.Models
{
    public class Receipt
    {
        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("boundingPoly")]
        public BoundingPoly BoundingPoly { get; set; }
    }
}
