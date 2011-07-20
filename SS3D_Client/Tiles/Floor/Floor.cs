﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GorgonLibrary;
using GorgonLibrary.Graphics;
using System.Drawing;


namespace SS3D.Tiles.Floor
{
    public class Floor : Tile
    {
        public Floor(Sprite _sprite, TileState state, float size, Vector2D _position, Point _tilePosition)
            : base(_sprite, state, size, _position, _tilePosition)
        {
            tileType = TileType.Floor;
            name = "Floor";
        }


    }
}