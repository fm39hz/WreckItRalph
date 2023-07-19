using Godot;
using GameSystem.Utility.Direction;
using System.Collections.Generic;

namespace GameSystem.Data.Instance;
	public class DirectionData{
		public Dictionary<int, Vector2> DirectionContainer { get; private set; }
		public int AsNumber { get; private set; }
		public Vector2 AsVector { get; private set; }
		public DirectionData(){
			DirectionContainer = new(8){
				{ 0, Vector2.Left },
				{ 1, Vector2.Right }
				};
			}
		public void SetDirection(int input){
			this.AsNumber = input;
			this.AsVector = DirectionConverter.ToDirection(input);
			}
		public void SetDirection(Vector2 input){
			this.AsVector = input;
			this.AsNumber = DirectionConverter.ToDirection(input);
			}
		}
