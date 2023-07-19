using GameSystem.Component.FiniteStateMachine;
using Godot;

namespace  Actor.Target.Felix;
	public partial class Walk : DynamicState{
		public override void _Ready(){
			base._Ready();
			Object.PlayerInputManager.MovementKeyPressed += this.SetCondition;
			Object.PlayerInputManager.ActionKeyPressed += this.ResetCondition;
			Object.PlayerInputManager.JumpKeyPressed += this.ResetCondition;
			}
		public override void RunningState(double delta){
			base.RunningState(delta);
			Object.Velocity = Object.PlayerInputManager.HorizontalVector(Object.Velocity) * this.MovingSpeed;
			}
		}
