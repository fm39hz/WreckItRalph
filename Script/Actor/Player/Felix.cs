using System;
using GameSystem.Component.Object;
using GameSystem.Data.Global;
using Godot;

namespace Actor.TargetFelix;
	public partial class Felix : DynamicObject{
		[Export] public float JumpVelocity = -400.0f;

		public override void _PhysicsProcess(double delta){
			base._PhysicsProcess(delta);
			var _gravity = GetNode<Metadata>("/root/Metadata").Gravity;
			if (!this.IsOnFloor() && this.CanMove){
				var _velocity = new Vector2(this.Velocity.X, Convert.ToSingle(_gravity * delta));
				this.Velocity = _velocity;
				}
			}
		}
