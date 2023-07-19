using System;
using GameSystem.Component.Object;
using Godot;

namespace Actor.TargetFelix;
	public partial class Felix : DynamicObject{
		[Export] public float JumpVelocity = -400.0f;
		private float Gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

		public override void _PhysicsProcess(double delta){
			base._PhysicsProcess(delta);
			if (!this.IsOnFloor() && this.CanMove){
				var _velocity = new Vector2(this.Velocity.X, Convert.ToSingle(Gravity * delta));
				this.Velocity = _velocity;
				}
			}
		}
