using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CaseStudy.Business.Models
{
    public class BoundingPoly
    {
        [JsonPropertyName("vertices")]
        public List<Vertex> Vertices { get; set; }
    }
}
