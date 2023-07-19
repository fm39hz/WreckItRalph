using GameSystem.Component.FiniteStateMachine;

namespace  Actor.TargetFelix;
	public partial class Idle : DynamicState{
		public override void _Ready(){
			base._Ready();
			var _inputManager = Object.PlayerInputManager;
			_inputManager.MovementKeyPressed += this.SetCondition;
			_inputManager.ActionKeyPressed += this.ResetCondition;
			_inputManager.JumpKeyPressed += this.ResetCondition;
			}
		public override void SetCondition(bool condition){
			if (!this.IsInitialized){
				return;
				}
			Condition = !condition;
			}
		}
