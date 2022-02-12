﻿using System.Numerics;

namespace Diggity.Project.Models.Abstract.Grids
{
    public interface IGrid
    {
        public int ID { get; set; }
        public Vector2 InternalCoordinate { get; set; }
        public IGridBox[,] InternalGrid { get; set; }
        
        public float GetGridWidth();
        public float GetGridHeight();

        public float Width => GetGridWidth();
        public float Height => GetGridHeight();
        
        // TODO: Figure out what to do when grid size exceeds building window. Scrollable.
    }
}