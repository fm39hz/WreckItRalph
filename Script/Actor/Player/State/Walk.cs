using GameSystem.Component.FiniteStateMachine;

namespace  Actor.Target.Felix;
	public partial class Walk : DynamicState{
		public override void _Ready(){
			base._Ready();
			Object.PlayerInputManager.MovementKeyPressed += this.SetCondition;
			Object.PlayerInputManager.ActionKeyPressed += this.ResetCondition;
			}
		public override void RunningState(double delta){
			base.RunningState(delta);
			Object.Velocity = Object.PlayerInputManager.GetPlayerMovementVector(Object.Velocity) * this.MovingSpeed;
			}
		}
