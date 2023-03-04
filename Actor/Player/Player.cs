using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
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

    private Sprite _sprite;
    private string _name;




    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(this.Name + " is ready. (Player.cs)");
    }

    // Called 60 times per second, independent of framerate.
    // 'delta' is the elapsed time since '_PhysicsProcess' was last called.
    public override void _PhysicsProcess(float delta)
    {
        // Reset horizontal velocity
        velocity.x = 0;

        // Set horizontal velocity
        if (Input.IsActionPressed("right"))
        {
            velocity.x = velocity.x + moveSpeed;
        }
        if (Input.IsActionPressed("left"))
        {
            velocity.x = velocity.x - moveSpeed;
        }

        // Apply gravity
        velocity.y = velocity.y + gravity * delta;

        // Jump on next frame
        if (Input.IsActionJustPressed("jump"))
        {
            // Check if player is on the floor
            if (IsOnFloor())
            {
                // jumpsRemaining--;

                // Negative y values are up
                velocity.y = -jumpSpeed;
            }
        }

        // Move player ('MoveAndSlide' automatically uses 'delta' in calculations)
        velocity = MoveAndSlide(velocity, Vector2.Up);

        FlipSprite();
    }

    public void FlipSprite()
    {
        _sprite = GetNode<Sprite>("Sprite");
        // Flip sprite to match direction player is moving
        if (velocity.x > 0)
        {
            // Player is moving right
            _sprite.FlipH = false;
        }
        else if (velocity.x < 0)
        {
            // Player is moving left
            _sprite.FlipH = true;
        }
        else
        {
            // Player is not moving
            // Play idle animation here if it doesn't effect physics or controls
        }
    }
}
