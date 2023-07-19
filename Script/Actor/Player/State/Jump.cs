using GameSystem.Component.FiniteStateMachine;

namespace  Actor.Target.Felix;
	public partial class Jump : DynamicState{
		public override void _Ready(){
			base._Ready();
			Object.PlayerInputManager.JumpKeyPressed += this.SetCondition;
			}
        public void SetCondition(){
            this.SetCondition(true);
            }
		public override void RunningState(double delta){
			base.RunningState(delta);
				if (Object.IsOnFloor()){
					Object.Velocity = Object.PlayerInputManager.GetPlayerMovementVector(Object.Velocity) * this.MovingSpeed;
					}
				if (!Object.IsOnFloor()){
					
					}
				else {
					this.ResetCondition();
					}
            }
		}
