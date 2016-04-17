using System;
using BudaEngine;
using Microsoft.Xna.Framework;


namespace BudaEngine
{
	public class Transform : Component
	{
		/// <summary>
		/// The position.
		/// </summary>
		public Vector2 Position;
		/// <summary>
		/// The rotation.
		/// </summary>
		public float Rotation;
		/// <summary>
		/// The scale.
		/// </summary>
		public Vector2 Scale;
		/// <summary>
		/// The velocity.
		/// </summary>
		public Vector2 Velocity;

		/// <summary>
		/// Initializes a new instance of the <see cref="BudaEngine.Transform"/> class.
		/// </summary>
		public Transform ()
		{
			Position = Vector2.Zero;
			Rotation = 0;
			Scale = Vector2.One;
			Velocity = Vector2.Zero;
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="BudaEngine.Transform"/> class.
		/// </summary>
		/// <param name="position">Position.</param>
		/// <param name="rotation">Rotation.</param>
		/// <param name="scale">Scale.</param>
		public Transform (Vector2 position, float rotation,Vector2 scale)
		{
			Position = position;
			Rotation = rotation;
			Scale = scale;
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="BudaEngine.Transform"/> class.
		/// </summary>
		/// <param name="position">Position.</param>
		/// <param name="rotation">Rotation.</param>
		/// <param name="scale">Scale.</param>
		/// <param name="velocity">Velocity.</param>
		public Transform (Vector2 position, float rotation,Vector2 scale, Vector2 velocity)
		{
			Position = position;
			Rotation = rotation;
			Scale = scale;
			Velocity = velocity;
		}

		#region implemented abstract members of Component
		public override void Update ()
		{
			Position += Velocity;
		}
		#endregion
	}
}

