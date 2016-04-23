using System.Collections.Generic;

namespace BudaEngine
{
	public class ComponentManager
	{
		private List<Component> components;
		private List<Component> updatedComponents;
		private bool isUpdating;
		public ComponentManager ()
		{
			components = new List<Component> ();
			updatedComponents = new List<Component> ();
		}

		public Component AddComponent(Component com){
			if (isUpdating) {
				
				updatedComponents.Add (com);
			} else {
				components.Add (com);
			}

			return com;
		}

		public Component GetComponent<T>(){
			foreach (Component com in updatedComponents) {

				if (com.GetType () == typeof(T)) {
					return com;
				}
			}
			return null;
		}
		public bool RemoveComponent<T>(){
			foreach (Component com in updatedComponents) {

				if (com.GetType () == typeof(T)) {
					updatedComponents.Remove (com);
					return true;
				}
			}
			return false;
		}

		public void Update(){
			updatedComponents = components;
			isUpdating = true;
			foreach (Component c in components) {
				c.Update ();
			}

			isUpdating = false;
			components = updatedComponents;
		}


			

		public void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch){
			foreach (Component c in components) {
				c.Draw (spriteBatch);
			}

		}


	}
}

