using System;
using Godot;

namespace GameSystem.Data.Global;
    public partial class Metadata : Node{
		/// <summary>
		/// Trả về giá trị bằng fps * delta
		/// </summary>
		/// <returns>1 khi fps đạt ngưỡng lý tưởng</returns>
        public double RelativeResponseTime { get; private set; }
        public float Gravity { get; set; }
        public override void _Ready(){
            this.ProcessMode = ProcessModeEnum.Always;
            this.Gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();
            }
        public override void _PhysicsProcess(double delta){
            this.RelativeResponseTime = Performance.GetMonitor(Performance.Monitor.TimeFps) * delta;
            }
        }   