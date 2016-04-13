using System;
using BudaEngine.Core;
using Microsoft.Xna.Framework.Graphics;
namespace BudaEngine.Core
{
	public class Scene
	{
		public bool isRunning{ get; protected set;}
		public GameObjectManager ObjectManager{ get; protected set;}
		public Scene ()
		{
			GameObjectManager = new GameObjectManager ();
		}

		/// <summary>
		/// Is called when this scene is called to the Current Scene
		/// </summary>
		public void BeginScene(){

		}
		/// <summary>
		/// Is called when this scene is no longer the Current Scene
		/// </summary>
		public void EndScene(){
			
		}

		public void Update(){
			if (isRunning)
			ObjectManager.Update ();
		}

		public void Draw(SpriteBatch spriteBatch){
			ObjectManager.Draw (spriteBatch);
		}

		public void PauseScene(){
			isRunning = false;
		}
		public void PlayScene(){
			isRunning = true;
		}


	}
}

