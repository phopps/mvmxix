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

  // Called when the node enters the scene tree for the first time.
  public override void _Ready() {
    player = (Node2D) GetNode("Sneak");
    cam = (MainCam) GetNode("MainCam");
    // cam.setTarget(player);
    Position2D spawn = (Position2D) GetNodeOrNull(playerSpawn);
    player.Position = spawn.Position;
  }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
