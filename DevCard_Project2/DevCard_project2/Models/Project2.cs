using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NuGet.Protocol.Core.Types;

namespace DevCard_project2.Models
{
    public class Project2
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Client { get; set; }

        public Project2(long id, string name, string description,string image,
            string client)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Client = client;
        }
    }
}