using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BudaEngine.Core
{
	public class Sprite
	{
		/// <summary>
		/// Initializes a new instance of the Sprite class.
		/// </summary>
		public Sprite()
		{
			this.SpriteEffects = SpriteEffects.None;
			this.Layer = 1;
			this.Color = Color.White;
		    this.Texture = null;
		}
		public Sprite(string name): this(){
			this.AssetName = name;
		}

		/// <summary>
		/// Loads the content relevant to the Sprite.
		/// </summary>
		/// <param name="game"></param>
	/// <summary>
		/// Gets or sets the assetname which MonoGame uses to find the texture file.
		/// </summary>
		public string AssetName { get; set; }

		/// <summary>
		/// Gets or sets the texture object of the sprite.
		/// </summary>
		public Texture2D Texture { get; set;}


		/// <summary>
		/// Gets the size.
		/// </summary>
		/// <value>The size.</value>
		public Vector2 Size {
		    get
		    {
		            return new Vector2(Texture.Width, Texture.Height);

		    } }

		/// <summary>
		/// Gets or sets the color filter to draw over the sprite. Works best on white textures.
		/// </summary>
		public Color Color { get; set; }

		/// <summary>
		/// Gets or sets the origin of the sprite. By default this is the center.
		/// </summary>
		public Vector2 Origin {
			get { 
				if (Texture != null) {
					return new Vector2 (Texture.Width / 2, Texture.Height/2);
				} else {
					return Vector2.Zero;
				}
			}
		}

		/// <summary>
		/// Gets or sets any additional effects placed on the sprite.
		/// </summary>
		public SpriteEffects SpriteEffects { get; set; }

		/// <summary>
		/// Gets or sets the number that determines if this sprite is drawn in front of or behind another. 
		/// If the numbers are the same the last one drawn in the code is drawn on top.
		/// </summary>
		public float Layer { get; set; }
	}
}

