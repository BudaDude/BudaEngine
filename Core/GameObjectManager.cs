using System.Collections.Generic;
using System;
using Microsoft.Xna.Framework.Graphics;

namespace BudaEngine.Core
{
	public class GameObjectManager
	{
		private List<GameObject> gameObjects;

		public GameObjectManager(){
			gameObjects = new List<GameObject>();
		}
		public void Add(GameObject obj){
			gameObjects.Add (obj);
		}



		public void Update(){
			foreach (GameObject obj in gameObjects) {
				if (obj.Active)
					obj.Update ();
			}
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

