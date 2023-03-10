using Godot;
using System;

public class MainCam : Camera2D {
  // Declare member variables here. Examples:
  // private int a = 2;
  // private string b = "text";
  [Export] public NodePath target;
  [Export] public float align_time = 0.2f;
  [Export] public Vector2 screen_size = new Vector2(720,480);
  private Node2D Target;

  // Called when the node enters the scene tree for the first time.
  public override void _Ready() {
    Target = (Node2D) GetNodeOrNull(target);
    this.MakeCurrent();
  }

  // public override void _Process(float delta) {

  //   SceneTreeTween t = CreateTween().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Quint);
  //   t.TweenProperty(this, "offset", desired_position(), align_time);
  // }

  public override void _PhysicsProcess(float delta) {
    // if (! IsInstanceValid(Target)) {
    //   Godot.Collections.Array targets = GetTree().GetNodesInGroup("Player");
    //   if (targets != null) {
    //     Target = targets[0];
    //   }
    // }
    // if (! IsInstanceValid(Target)) {
    //   return;
    // }
    SceneTreeTween t = CreateTween().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Quint);
    t.TweenProperty(this, "offset", desired_position(), align_time);
    // this.Position = desired_position();
    // GD.Print(this.GetCameraScreenCenter());
  }

  private Vector2 desired_position() {
    // Vector2 v = Target.Position;
    // GD.Print(v);
    Vector2 output = (Target.Position / screen_size).Floor() * screen_size + screen_size/2;
    // GD.Print(output);
    return output;
  }

  public void setTarget(Node2D target) {
    Target = target;
  }
}

/**
private void Something(float test, out float something) {
  something = result;
}

Something (0.5, storage);

*/