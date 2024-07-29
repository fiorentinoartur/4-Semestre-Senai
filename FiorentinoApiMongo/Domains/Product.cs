using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FiorentinoApiMongo.Domains
{
    public class Product
    {
        //define que esta prop é o Id do 
        [BsonId] 
        //define o nome do campo no MongoDb como "_id" e o tipo como ObjectId
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
       
        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("price")]
        public decimal? Price { get; set; }

        //Adiciona um dicionário para atributos adicionais 
        public Dictionary<string, string> AdditionalAttributes { get; set; }


        /// <summary>
        /// Ao ser instanciado um obj da classe Product, o atributo AdditionalAttributes já virá um novo dicionário e portanto habilitado para adicionar + atributos
        /// </summary>
        public Product()
        {
            AdditionalAttributes = new Dictionary<string, string>();    
        }

    }
}
