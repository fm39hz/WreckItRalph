using System;
using GameSystem.Component.Object;
using Godot;

namespace Actor.TargetFelix;
	public partial class Felix : DynamicObject{
		[Export] public float JumpVelocity = -400.0f;
		public override void _PhysicsProcess(double delta){
			base._PhysicsProcess(delta);
			}
		}
