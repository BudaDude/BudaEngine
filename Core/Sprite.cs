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
			this.Origin = Vector2.Zero;
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
		public Texture2D Texture { get; set; }

		/// <summary>
		/// Gets or sets the source rectangle, which is used to determine where on the texture file to draw the sprite from.
		/// </summary>
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
		/// Gets or sets the origin of the sprite. By default this is the top left corner.
		/// </summary>
		public Vector2 Origin { get; set; }

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

