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
			ObjectManager = new GameObjectManager ();
		}

		/// <summary>
		/// Is called when this scene is called to the Current Scene
		/// </summary>
		public virtual void BeginScene(){

		}
		/// <summary>
		/// Is called when this scene is no longer the Current Scene
		/// </summary>
		public virtual void EndScene(){
			ObjectManager.RemoveAll ();
		}

		public virtual void Update(){
			if (isRunning)
			ObjectManager.Update ();
		}

		public virtual void Draw(SpriteBatch spriteBatch){
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

