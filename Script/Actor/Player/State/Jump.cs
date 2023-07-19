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
					for (int i = 0 ; i < 100; i++){
						Object.Velocity += Object.PlayerInputManager.VerticalVector(Object.Velocity) * this.MovingSpeed;
						}
					}
				this.ResetCondition();
            }
		}
