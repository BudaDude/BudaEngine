using System.Collections.Generic;
using BudaDude.Core;

namespace BudaDude
{
	public class World
	{
		List<GameObject> worldObjects;
		public World ()
		{
			worldObjects = new List<GameObject> ();
		}

		public GameObject FindGameObject(string name){
			foreach (GameObject obj in worldObjects) {
				if (obj.Name == name) {
					return obj;
				}
			}
			return null;

		}
	}
}

