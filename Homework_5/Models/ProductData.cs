using System;
using Newtonsoft.Json;

namespace Homework_5.Models
{
    public class ProductData
    {
        [JsonProperty("productId")]
        public int Id { get; set; }

        [JsonProperty("productName")]
        public string Name { get; set; }

        [JsonProperty("productCode")]
        public string Code { get; set; }

        [JsonProperty("releaseDate")]
        public string ReleaseData { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("starRating")]
        public double Rating { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }
    }
}
