using Diggity.Project.Models.Abstract.Types;
using Diggity.Project.Models.Concrete.PlayerShipComponents;
using Diggity.Project.Models.Enums;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Diggity.Project.Models.Concrete.StaticRepositories
{
    public class GameItemsRepository : Dictionary<int, (string Name, Dictionary<EOrientation, Texture2D> Textures, IType type)>
    {
        public GameItemsRepository(ContentManager manager)
        {
            InitializeCollection(manager);
        }

        private void InitializeCollection(ContentManager manager)
        {
            var ScrapPlating = new ThermalPlating(ID: 0, 0, 100, 2, "Scrap Thermal Plating", 5, 5);
            //Add(0, ("ScrapThermalPlating", manager.Load<Texture2D>("Graphics/Player/ThermalPlatings/ScrapThermalPlating/ScrapThermalPlating"), ScrapPlating));


            var ScrapHullTextures = new Dictionary<EOrientation, Texture2D>
            {
                { EOrientation.Base, manager.Load<Texture2D>("Graphics/Player/Hulls/ScrapHull/Player") },
                { EOrientation.Left, manager.Load<Texture2D>("Graphics/Player/Hulls/ScrapHull/PlayerLeft") },
                { EOrientation.Up, manager.Load<Texture2D>("Graphics/Player/Hulls/ScrapHull/PlayerUp") },
                { EOrientation.Right, manager.Load<Texture2D>("Graphics/Player/Hulls/ScrapHull/PlayerRight") },
                { EOrientation.Down, manager.Load<Texture2D>("Graphics/Player/Hulls/ScrapHull/PlayerDown") }
            };
            Add(1, ("ScrapHull", ScrapHullTextures, new Hull(ID: 1, Durability: 5, Health: 50, Plating: new ThermalPlating(ScrapPlating), Name: "Scrap Hull", Worth: 5, Weight: 5)));


            var ScrapDrillTextures = new Dictionary<EOrientation, Texture2D>
            {
                { EOrientation.Left, manager.Load<Texture2D>("Graphics/Player/Drills/ScrapDrill/ScrapDrillLeft") },
                { EOrientation.Up, manager.Load<Texture2D>("Graphics/Player/Drills/ScrapDrill/ScrapDrillUp") },
                { EOrientation.Right, manager.Load<Texture2D>("Graphics/Player/Drills/ScrapDrill/ScrapDrillRight") },
                { EOrientation.Down, manager.Load<Texture2D>("Graphics/Player/Drills/ScrapDrill/ScrapDrillDown") }
            };
            Add(2, ("ScrapDrill", ScrapDrillTextures, new Drill(ID: 2, Hardness: 0.1f, Plating: new ThermalPlating(ScrapPlating), Name: "Scrap Drill")));


            //Add(3, ("ScrapEngine", manager.Load<Texture2D>("Graphics/Player/Engines/ScrapEngine/ScrapEngine"), new Engine(ID: 3, Speed: 2, Plating: new ThermalPlating(ScrapPlating), Name: "Scrap Engine", ActiveFuelConsumption: 1, Worth: 5, Weight: 5)));
            //Add(4, ("ScrapFuelTank", manager.Load<Texture2D>("Graphics/Player/FuelTanks/ScrapFuelTank/ScrapFuelTank"), new FuelTank(ID: 4, Capacity: 200, Fuel: 200, Name: "Scrap Fuel Tank", Worth: 5, Weight: 5)));
            //Add(5, ("ScrapThruster", manager.Load<Texture2D>("Graphics/Player/Thrusters/ScrapThruster/ScrapThruster"), new Thruster(ID: 5, Speed: 2, Power: 50, Plating: new ThermalPlating(ScrapPlating), Name: "Scrap Thruster", ActiveFuelConsumption: 2, Weight: 5, Worth: 5)));

        }
    }
}