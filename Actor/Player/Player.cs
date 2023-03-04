using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Godot;

public class Player : Actor
{
    // Player variables can be adjusted live in the Godot Editor while game is running
    [Export] public new float moveSpeed = 250;
    [Export] public float gravity = 2000;
    [Export] public float jumpSpeed = 650;
    [Export] public int jumpsUsed = 0;
    [Export] public int jumpsRemaining = 2;
    [Export] public bool isActivePlayer = false;
    [Export] public bool justJumped = false;

    private Sprite _sprite;
    private string _name;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(this.Name + " is ready. (Player.cs)");
    }

    // Called 60 times per second independent of framerate, delta is time since physics process called.
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
                Jump();
            }
        }

        // Move player ('MoveAndSlide' automatically uses 'delta' in calculations)
        velocity = MoveAndSlide(velocity, Vector2.Up);

        FlipSprite();
    }

    // Flip sprite to match direction player is moving
    public void FlipSprite()
    {
        _sprite = GetNode<Sprite>("Sprite");

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

    // Jump and air jump abilities
    public void Jump()
    {
        justJumped = true;
        jumpsUsed++;
        jumpsRemaining--;

        // Negative y values are up
        velocity.y = -jumpSpeed;
    }
}
