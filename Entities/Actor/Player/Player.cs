using Godot;
using System;

// TODO: player movement, user input

public class Player : KinematicBody2D
{
    [Export] float moveSpeed = 100;
    [Export] float gravity = 2000;
    Vector2 velocity = Vector2.Zero;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//
//  }
}
