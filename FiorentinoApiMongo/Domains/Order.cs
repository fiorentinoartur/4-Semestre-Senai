using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace FiorentinoApiMongo.Domains
{
    public class Order
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }


        [BsonElement("date")]
        public DateOnly? Date { get; set; }

        [BsonElement("status")]
        public bool? Status { get; set; }


        [BsonElement("clientId"), BsonRepresentation(BsonType.ObjectId)]
      
        [JsonIgnore]
        public string? ClientId { get; set; }

        [BsonIgnore]
        public Client? Client { get; set; }

        [BsonElement("productId")]
        //Referência para que eu consiga cadastrar um pedido com os produtos            
        [JsonIgnore]
        public List<string>? ProductId { get; set; }

        //Referência para que quando eu liste os pedidos, venha os dados de cada produto
        [BsonIgnore]
        public List<Product>? Products { get; set; }








    }
}
