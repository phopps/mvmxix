using Godot;
using System;

public class TestLevel : Node2D
{
  // Declare member variables here. Examples:
  // private int a = 2;
  // private string b = "text";
  private Node2D player;
  private MainCam cam;
  [Export] public NodePath playerSpawn;
  private Position2D spawn;

  // Called when the node enters the scene tree for the first time.
  public override void _Ready() {
    player = (Node2D) GetNode("Sneak2");
    cam = (MainCam) GetNode("MainCam");
    // cam.setTarget(player);
    spawn = (Position2D) GetNodeOrNull(playerSpawn);
    player.Position = spawn.Position;
  }

  public override void _Input(InputEvent @event) {
    if (@event.IsActionPressed("respawn")) {
      Respawn();
    }
  }

  public void Respawn() {
    GD.Print("Respawn Character");
    player.Position = spawn.Position;
    //reset player health
  }

  public void UpdateSpawn(NodePath target) {
    spawn = (Position2D) GetNodeOrNull(target);
  }

  public void _on_KillPlane_body_entered(Node body) {
    if (body is Sneak2) { //FIXME - work for all players if we get player switching
      Respawn();
    }
  }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
