using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCinemaPlanner
{
    class Ticket
    {
        [BsonId]
        public string Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("type")]
        public string Type { get; set; }
        [BsonElement("timeofday")]
        public string TimeOfDay { get; set; }
        [BsonElement("price")]
        public decimal Price { get; set; }

    }
}
