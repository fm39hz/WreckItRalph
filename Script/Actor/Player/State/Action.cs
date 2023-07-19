using GameSystem.Component.FiniteStateMachine;

namespace  Actor.TargetFelix;
	public partial class Action : DynamicState{
		public override void _Ready(){
			base._Ready();
			Object.PlayerInputManager.ActionKeyPressed += this.SetCondition;
			Object.Sheet.AnimationFinished += this.ResetCondition;
			}
		public void SetCondition(){
			base.SetCondition(true);
			}
		public override void ResetCondition(){
			base.ResetCondition();
			Object.CanMove = true;
			}
		public override void RunningState(double delta){
			base.RunningState(delta);
			}
		}
