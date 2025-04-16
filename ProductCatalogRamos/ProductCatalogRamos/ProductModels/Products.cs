﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ProductCatalogServiceRamos.ProductModels
{
    public class Products
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; }
    }
}