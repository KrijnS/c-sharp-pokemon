﻿using Microsoft.Xna.Framework.Graphics;

namespace MonoGame
{
    class SpriteFactory : ISpriteFactory
    {
        public enum sprites
        {
            // player
            leftIdlePlayer, leftWalkingPlayer, rightIdlePlayer, rightWalkingPlayer, upIdlePlayer, upWalkingPlayer, downIdlePlayer, downWalkingPlayer
        }

        public SpriteFactory()
        {
        }

        public IAnimatedSprite builder(SpriteFactory.sprites sprite)
        {
            if (sprite == sprites.downIdlePlayer)
            {
                Texture2D downIdleTexture = Game1.gameContent.Load<Texture2D>("PlayerSprites/DownIdlePlayer");
                return new StaticSprite(downIdleTexture);
            }
            if (sprite == sprites.downWalkingPlayer)
            {
                Texture2D downWalkingTexture = Game1.gameContent.Load<Texture2D>("PlayerSprites/DownMovingPlayer");
                return new PlayerMovingSprite(downWalkingTexture, 3, 1);
            }
            if (sprite == sprites.leftIdlePlayer)
            {
                Texture2D leftIdleTexture = Game1.gameContent.Load<Texture2D>("PlayerSprites/LeftIdlePlayer");
                return new StaticSprite(leftIdleTexture);
            }
            if (sprite == sprites.leftWalkingPlayer)
            {
                Texture2D leftWalkingTexture = Game1.gameContent.Load<Texture2D>("PlayerSprites/LeftMovingPlayer");
                return new PlayerMovingSprite(leftWalkingTexture, 3, 1);
            }
            if (sprite == sprites.rightIdlePlayer)
            {
                Texture2D rightIdleTexture = Game1.gameContent.Load<Texture2D>("PlayerSprites/RightIdlePlayer");
                return new StaticSprite(rightIdleTexture);
            }
            if (sprite == sprites.rightWalkingPlayer)
            {
                Texture2D rightWalkingTexture = Game1.gameContent.Load<Texture2D>("PlayerSprites/RightMovingPlayer");
                return new PlayerMovingSprite(rightWalkingTexture, 3, 1);
            }
            if (sprite == sprites.upIdlePlayer)
            {
                Texture2D upIdleTexture = Game1.gameContent.Load<Texture2D>("PlayerSprites/UpIdlePlayer");
                return new StaticSprite(upIdleTexture);
            }
            if (sprite == sprites.upWalkingPlayer)
            {
                Texture2D upWalkingTexture = Game1.gameContent.Load<Texture2D>("PlayerSprites/UpMovingPlayer");
                return new PlayerMovingSprite(upWalkingTexture, 3, 1);
            }
            return null;
        }
    }
}
