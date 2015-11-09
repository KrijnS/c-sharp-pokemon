﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame
{
    public class Tile
    {
        public float xpos = 0, ypos = 0;
        public ITileState state;
        public enum TileType { wall, tree}
        public Vector2 position = new Vector2(0, 0);
        
        public Tile(ITileState state, Vector2 position)
        {
            this.state = state;
            this.position = position;
        }

        public Rectangle GetBoundingBox()
        {
            return state.GetBoundingBox(position);
        }

        public void Update(GameTime gameTime)
        {
            state.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {
            state.Draw(spriteBatch, location, color);
        }
    }
}
