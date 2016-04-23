using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using BudaEngine;

namespace BudaEngine
{
	public abstract class GameObject
	{
		public string ID{ get; protected set;}
		public bool Active;
		public ComponentManager Components{ get; protected set;}

		public GameObject(){
			Components = new ComponentManager ();
			Components.GetComponent<Transform> ();
		}

		public virtual void Update(){
			Components.Update ();
		}

	}
}

