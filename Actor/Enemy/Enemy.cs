using Godot;
using System;
using System.Collections.Generic;

public class Enemy : Actor
{
    public float gravity;
    public bool isAggro;
    public bool isAttacking;
    public Dictionary<string, Vector2> moveDirections;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        EnemyHealth();
    }
    public void EnemyHealth()
    {
        if (health <= 0)
            QueueFree();
    }
}
