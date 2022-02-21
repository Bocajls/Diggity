using Diggity.Project.Models.Abstract.PlayerShipComponents;
using Diggity.Project.Models.Enums;
using Microsoft.Xna.Framework;

namespace Diggity.Project.Models.Abstract
{
    public abstract class APlayer
    {
        public Vector2 Coordinates { get; set; } = new Vector2(0, 0);
        public Vector2 Direction { get; set; } = new Vector2(0, 0);
        public EOrientation Orientation
        {
            get
            {
                if (Direction == new Vector2(0,  1)) return EOrientation.Down;
                if (Direction == new Vector2(-1, 0)) return EOrientation.Left;
                if (Direction == new Vector2(0, -1)) return EOrientation.Up;
                if (Direction == new Vector2(1,  0)) return EOrientation.Right;
                return EOrientation.Base;
            }
        }

        public bool Mining { get; set; } = false;
        public string Name { get; set; } = "Undefined";
        public double Cash { get; set; } = 0.0f;
        public AEngine Engine { get; set; }
        public AHull Hull { get; set; }
        public ADrill Drill { get; set; }
        public AInventory Inventory { get; set; }
        public AThruster Thruster { get; set; }
        public AFuelTank FuelTank { get; set; }
        public float Weight { get; } = 0.0f;
    }
}