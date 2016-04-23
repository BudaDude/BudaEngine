using System;
using Microsoft.Xna.Framework.Graphics;
using BudaEngine;

namespace BudaEngine
{
	public abstract class DrawableGameObject : GameObject
	{
		public abstract void LoadContent();
		public abstract void Draw (SpriteBatch spriteBatch);
	}
}

