using System.Collections.Generic;
using System;
using BudaEngine.Core;
using Microsoft.Xna.Framework.Graphics;

namespace BudaEngine.Core
{
	static class SceneManager
	{
		public static Scene CurrentScene{ get; private set;}
		private static Dictionary<string,Scene> Scenes = new Dictionary<string, Scene>();

		/// <summary>
		/// Adds the scene.
		/// </summary>
		/// <param name="key">Key.</param>
		/// <param name="value">Value.</param>
		public static void AddScene (string key, Scene value){
			Scenes.Add (key, value);
		}


		/// <summary>
		/// Removes the scene.
		/// </summary>
		/// <returns><c>true</c>, if scene was removed, <c>false</c> otherwise.</returns>
		/// <param name="key">Key.</param>
		public static bool RemoveScene(string key){
			return Scenes.Remove (key);
		}

		/// <summary>
		/// Changes the scene.
		/// </summary>
		/// <returns><c>true</c>, if scene was changed, <c>false</c> otherwise.</returns>
		/// <param name="sceneName">Scene name.</param>
		public static bool ChangeScene(string sceneName){

			try{
				if (CurrentScene != null){
					Scene lastScene = CurrentScene;
					CurrentScene = Scenes[sceneName];
					lastScene.EndScene();
				}else{
					CurrentScene = Scenes[sceneName];
				}
				CurrentScene.BeginScene();
				CurrentScene.PlayScene();
				return true;
			}catch(KeyNotFoundException e){
				Console.Write ("The key '{0}' was not found, current scene will not change.\n{1}", sceneName,e);
				return false;
			}
		}
		/// <summary>
		/// Calls PauseScene,EndScene,BeginScene,and PlayScene;
		/// </summary>
		public static void ResetScene(){
			CurrentScene.PauseScene ();
			CurrentScene.EndScene();
			CurrentScene.BeginScene();
			CurrentScene.PlayScene();
		}
		/// <summary>
		/// Update current scene.
		/// </summary>
		public static void Update(){
			if (CurrentScene != null) {
				CurrentScene.Update ();
			}
		}
		/// <summary>
		/// Calls Draw on Current Scene
		/// </summary>
		/// <param name="spriteBatch">Sprite batch.</param>
		public static void Draw(SpriteBatch spriteBatch){
			if (CurrentScene != null) {
				CurrentScene.Draw (spriteBatch);
			}
		}
	}
}

