﻿using Diggity.Project.Models.Abstract.PlayerShipComponents;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class Hull : IHull
    {
        public Hull(short ID, float Durability, float Health, IThermalPlating Plating, string Name)
        {
            this.ID = ID;
            this.Durability = Durability;
            this.Health = Health;
            this.Plating = Plating;
            this.Name = Name;
        }

        public short ID { get; set; }
        public float Durability { get; set; }
        public float Health { get; set; }
        public IThermalPlating Plating { get; set; }
        public string Name { get; set; }
    }
}