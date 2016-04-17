using System;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BudaEngine
{
	public abstract class Component
	{
		public virtual void LoadContent (ContentManager Content){}
		public virtual void Update(){}
		public virtual void Draw(SpriteBatch spriteBatch){}
	}
}

