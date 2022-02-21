using Diggity.Project.Models.Abstract;
using Diggity.Project.Models.Concrete.PlayerShipComponents;
using Newtonsoft.Json;

namespace Diggity.Project.Models.Concrete
{
    public class Player : APlayer
    {
        [JsonConstructor]
        public Player(Engine Engine, Hull Hull, Drill Drill, Inventory Inventory, Thruster Thruster, FuelTank FuelTank)
        {
            this.Engine = Engine;
            this.Hull = Hull;
            this.Drill = Drill;
            this.Inventory = Inventory;
            this.Thruster = Thruster;
            this.FuelTank = FuelTank;
        }
    }
}