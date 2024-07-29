using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FiorentinoApiMongo.Domains
{
    public class Order
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonId]
        public string? ClientId { get; set; }

        [BsonElement("date")]
        public DateOnly? Date { get; set; }    
        
        [BsonElement("status")]
        public bool? Status { get; set; }





  
    }
}
