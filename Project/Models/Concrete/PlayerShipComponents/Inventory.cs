﻿using Diggity.Project.Models.Abstract.PlayerShipComponents;
using Diggity.Project.Models.Concrete.Grids;
using Newtonsoft.Json;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class Inventory : AInventory
    {
        [JsonConstructor]
        public Inventory(short ID, Grid Items, float SizeLimit, string Name, float Worth, float Weight)
        {
            this.ID = ID;
            this.Items = Items;
            this.SizeLimit = SizeLimit;
            this.Name = Name;
            this.Worth = Worth;
            this.Weight = Weight;
        }
    }
}