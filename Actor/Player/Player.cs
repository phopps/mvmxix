using System.Collections.Generic;
using Godot;

// TODO: player movement, user input

public class Player : Actor
{
    // Player variables can be adjusted live in the Godot Editor while game is running
    [Export] public float moveSpeed = 250;
    [Export] public float gravity = 2000;
    [Export] public float jumpSpeed = 650;
    // public int jumpsRemaining = 2;

    // Player switching
    public bool isActivePlayer = false;


    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print("(player ready)");

    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {

    }

    // Called 60 times per second, independent of framerate.
    // 'delta' is the elapsed time since '_PhysicsProcess' was last called.
    public override void _PhysicsProcess(float delta)
    {
        // reset horizontal velocity
        velocity.x = 0;

        // set horizontal velocity
        if (Input.IsActionPressed("right"))
        {
            velocity.x = velocity.x + moveSpeed;
        }
        if (Input.IsActionPressed("left"))
        {
            velocity.x = velocity.x - moveSpeed;
        }

        // apply gravity
        velocity.y = velocity.y + gravity * delta;

        // jump on next frame
        if (Input.IsActionJustPressed("jump"))
        {
            // check if player is on the floor
            if (IsOnFloor())
            {
                // jumpsRemaining--;

                // negative y values are up
                velocity.y = -jumpSpeed;
            }
        }

        // move player ('MoveAndSlide' automatically uses 'delta' in calculations)
        velocity = MoveAndSlide(velocity, Vector2.Up);
    }
}
