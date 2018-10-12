﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjectCubeServer.Models.DomainClasses
{
    public class Tagset
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public List<Hierarchy> Hierarchies { get; set; }
        public List<TagTagsetRelation> Tags { get; set; }

        /*
        public Tagset(string name)
        {
            this.Name = name;
            this.Hierarchies = new List<Hierarchy>();
            this.Tags = new List<TagTagsetRelation>();
        }
        */
    }
}