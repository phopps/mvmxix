using Godot;
using System;

public class MainMenu : CanvasLayer {
  
  private AnimationPlayer anim;

  // Called when the node enters the scene tree for the first time.
  public override void _Ready() {
    anim = GetNode<AnimationPlayer>("AnimationPlayer");
  }

  public void _on_AnimationPlayer_animation_finished(string animation) {
    //animation done, load game level.
    GD.Print("load main level.");
    this.Hide();
  }

  public void _on_StartButton_pressed() {
    //press go.
    anim.Play("StartGame");
  }

}
