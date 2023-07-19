using System;
using Godot;
using Actor.TargetFelix;

namespace GameSystem.Component.Manager;
	public partial class InputManager : Node{
		[Signal] public delegate void MovementKeyPressedEventHandler(bool IsPressed);
		[Signal] public delegate void ActionKeyPressedEventHandler();
		[Signal] public delegate void JumpKeyPressedEventHandler();
		private Felix CurrentPlayer { get; set; }
		private float Gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();
		public override void _Ready(){
			try{
				CurrentPlayer = GetOwner<Felix>();
				}
			catch(NullReferenceException InputMustInPlayer){
				GD.Print("InputManager phải được đặt trong Player");
				throw InputMustInPlayer;
				}
			}
		public override void _Input(InputEvent @event){
			if (@event is InputEventKey keyEscape){
				if (keyEscape.IsPressed() && keyEscape.Keycode == Key.Escape){
					GetTree().Quit();
					}
				}
			}
		public override void _PhysicsProcess(double delta){
			var _left = Input.IsActionPressed("ui_left");
			var _right = Input.IsActionPressed("ui_right");
				if (Input.IsActionJustPressed("ui_action")){
					EmitSignal(SignalName.ActionKeyPressed);
					CurrentPlayer.CanMove = false;
					}
				if (CurrentPlayer.CanMove){
					if (_left || _right){
						EmitSignal(SignalName.MovementKeyPressed, true);
						}
					else if (!_left && !_right){
						EmitSignal(SignalName.MovementKeyPressed, false);
						}
					if (Input.IsActionJustPressed("ui_up")){
						EmitSignal(SignalName.JumpKeyPressed);
						}
					}
			}
		public Vector2 HorizontalVector(Vector2 inputVector){
			if (CurrentPlayer.CanMove){
				inputVector.X = Input.GetAxis("ui_left", "ui_right");
				}
			return inputVector;
			}
		public Vector2 VerticalVector(Vector2 inputVector){
			if (CurrentPlayer.CanMove){
				inputVector.Y = 1;
				}
			return inputVector;
			}
		}
