using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FiorentinoApiMongo.Domains
{
    public class OrderProducts
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        
 
        [BsonElement("productId"), BsonRepresentation(BsonType.ObjectId)]
        public string? ProductId { get; set; }   
        
        [BsonId]
        [BsonElement("OrderId")]
        public string? OrderId { get; set; }


    }
}
