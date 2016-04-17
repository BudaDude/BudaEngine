using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using BudaEngine;

namespace BudaEngine.Core
{
	public class GameObject
	{

		public GameObject ()
		{
			transform = new Transform ();
			this.Active = true;
            this.Sprite = new Sprite();
		}

		public Sprite Sprite{ get; protected set;}

		public string Name{ get; set; }

		protected Transform transform;

		/// <summary>
		/// This game.
		/// </summary>

		public bool Active;

	    public virtual void Initialize()
	    {
	        
	    }

	    public virtual void Update()
	    {

	    }

	    public virtual void Draw(SpriteBatch spriteBatch)
	    {
	        if (spriteBatch != null && Sprite.Texture != null)
	        {
			//	spriteBatch.Draw(Sprite.Texture, Position,null, Sprite.Color,Rotation,Sprite.Origin,Scale,Sprite.SpriteEffects,Sprite.Layer );
	        }



	    }
	}
}

