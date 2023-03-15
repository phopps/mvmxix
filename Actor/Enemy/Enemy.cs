using Godot;
using System;
using System.Collections.Generic;

public abstract class Enemy : Actor
{
    public float gravity;
    public bool isAggro;
    public bool isAttacking;
    public Dictionary<string, Vector2> moveDirections;
    public int attackDamage = 10;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(Name + " is ready. (Enemy.cs)");
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
    public abstract void ReceiveDamage();
}
