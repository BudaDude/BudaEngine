using System.Collections.Generic;
using System;
using Microsoft.Xna.Framework.Graphics;

namespace BudaEngine
{
	public class GameObjectManager
	{
		private List<GameObject> gameObjects;

		private List<GameObject> updatedGameObjects;

		private List<DrawableGameObject> drawableGameObjects;

		private bool isUpdating;


		public GameObjectManager(){
			gameObjects = new List<GameObject>();
			updatedGameObjects = new List<GameObject> ();
			drawableGameObjects = new List<DrawableGameObject> ();

		}
		/// <summary>
		/// Add the specified <see cref="BudaEngine.Core.GameObject"/>;
		/// </summary>
		/// <param name="obj">Object.</param>
		public void Add(GameObject obj){
			Console.WriteLine ("Added");
			updatedGameObjects.Add (obj);
		}

		public void Add(DrawableGameObject obj){

			drawableGameObjects.Add (obj);
			updatedGameObjects.Add (obj);
		}


		public void RemoveAll(){
			updatedGameObjects.Clear();
			drawableGameObjects.Clear ();
		}




		public void Update(){
			gameObjects.Clear ();
			gameObjects.AddRange(updatedGameObjects);
			isUpdating = true;
			foreach (GameObject obj in gameObjects) {
				if (obj.Active)
					obj.Update ();
			}
			isUpdating = false;

		}
			

		public void Draw(SpriteBatch spriteBatch ){
			foreach (DrawableGameObject obj in drawableGameObjects) {
				if (obj.Active)
					obj.Draw (spriteBatch);
			}
		}
		//Return first object of Type
//		public T FindGameObject<T>(){
//			foreach (GameObject obj in gameObjects) {
//				if (obj.GetType ().Equals(T))
//					return obj;
//			}
//			return null;
//		}
		//Find object with name and type

	}
}

