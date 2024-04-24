using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerialzationTask
{
    public class Product : ISerializable
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        

        

        public  void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("name", Name,typeof(Product));
            info.AddValue("id", Id, typeof(Product));
            info.AddValue("description", Description, typeof(Product));
            info.AddValue("category", Category, typeof(Product));
        }
    }
}
