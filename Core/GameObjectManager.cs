using System.Collections.Generic;
using System;
using Microsoft.Xna.Framework.Graphics;

namespace BudaEngine.Core
{
	public class GameObjectManager
	{
		private List<GameObject> gameObjects;

		private List<GameObject> objectsToAdd;
		private List<GameObject> objectsToRemove;

		private bool isUpdating;


		public GameObjectManager(){
			gameObjects = new List<GameObject>();
			objectsToAdd = new List<GameObject> ();
			objectsToRemove = new List<GameObject> ();
		}
		/// <summary>
		/// Add the specified <see cref="BudaEngine.Core.GameObject"/>;
		/// </summary>
		/// <param name="obj">Object.</param>
		public void Add(GameObject obj){
			objectsToAdd.Add (obj);
		}

		public void RemoveAll(){
			objectsToRemove.AddRange(gameObjects);
		}




		public void Update(){
			isUpdating = true;
			foreach (GameObject obj in gameObjects) {
				if (obj.Active)
					obj.Update ();
			}
			isUpdating = false;
			UpdateList ();
		}

		private void UpdateList(){
			gameObjects.AddRange (objectsToAdd);
			objectsToAdd.Clear ();

			foreach (GameObject obj in objectsToRemove) {
				gameObjects.Remove (obj);
			}
			objectsToRemove.Clear();
		}

		public void Draw(SpriteBatch spriteBatch ){
			foreach (GameObject obj in gameObjects) {
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

