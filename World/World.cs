using Godot;
using System;

// TODO: fullscreen, pause, exit

public class World : Node2D {
  [Signal]
  public delegate void Pause();

  // Called when the node enters the scene tree for the first time.
  public override void _Ready() {
      
  }

  // public override void _Process(float delta) {
  //   if (Input.IsActionPressed("pause")) {
  //     GD.Print("pause sent?");
  //     EmitSignal("Pause");
  //   }
  // }

  public override void _Input(InputEvent e) {
    if (e.IsActionPressed("pause")) {
      GD.Print("pause sent?");
      EmitSignal("Pause");
    }
  }
}
