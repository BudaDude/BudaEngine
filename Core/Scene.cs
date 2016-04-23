using System;
using BudaEngine;
using Microsoft.Xna.Framework.Graphics;

namespace BudaEngine
{
	public class Scene
	{
		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="BudaEngine.Core.Scene"/> is running.
		/// </summary>
		/// <value><c>true</c> if is running; otherwise, <c>false</c>.</value>
		public bool isRunning{ get; protected set;}
		/// <summary>
		/// Gets the object manager.
		/// </summary>
		/// <value>The object manager.</value>
		public GameObjectManager Objects{ get; private set;}

		public Scene ()
		{
			Objects = new GameObjectManager ();
		}

		/// <summary>
		/// Is called when this scene is called to the Current Scene
		/// Use this to declare variables that should could be reset
		/// </summary>
		public virtual void BeginScene(){

		}
		/// <summary>
		/// Is called when this scene is no longer the Current Scene
		/// </summary>
		public virtual void EndScene(){
			Objects.RemoveAll ();
		}

		/// <summary>
		/// Updates each active Object in the scene
		/// </summary>
		public virtual void Update(){
			if (isRunning)
			Objects.Update ();
		}

		public virtual void Draw(SpriteBatch spriteBatch){
			Objects.Draw (spriteBatch);
		}
		/// <summary>
		/// Pauses the scene from updating
		/// </summary>
		public void PauseScene(){
			isRunning = false;
		}
		/// <summary>
		/// Plays the scene.
		/// </summary>
		public void PlayScene(){
			isRunning = true;
		}


	}
}

