using System;

namespace FlappyBird
{
	static class ScoreManager
	{
		public static int Score{ get; private set;}


		public static void AddScore(){
			Score++;
		}

		public static void ResetScore(){
			Score=0;
		}
	}
}

