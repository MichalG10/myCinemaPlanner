using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCinemaPlanner
{
    class TicketOrder
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("seanceid")]
        public int seanceId { get; set; }
        [BsonElement("place")]
        public int Place { get; set; }
        [BsonElement("discount")]
        public decimal Discount { get; set; }
        [BsonElement("tickets_id")]
        public string ticketsId { get; set; }
        [BsonElement("date")]
        public DateTime Date { get; set; }

    }
}
