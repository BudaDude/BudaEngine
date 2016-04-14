
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BudaEngine.Extras
{
	static class DebugContent
	{
		public static SpriteFont Font { get; private set;}


		public static void Load(ContentManager content)
		{
			Font = content.Load<SpriteFont> ("score");

		}
	}
}
