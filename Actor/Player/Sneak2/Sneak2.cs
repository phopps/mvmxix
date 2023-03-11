using Godot;

public class Sneak2 : KinematicBody2D
{
    [Export] public string name;
    [Export] public int health;
    [Export] public float gravity;
    [Export] public float moveSpeed;
    [Export] public float jumpSpeed;
    [Export] public Vector2 velocity;
    [Export] public int jumpsUsed;
    [Export] public int jumpsRemaining;
    [Export] public bool isActivePlayer;
    [Export] public bool justJumped;
    [Export] public Sprite sprite;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(Name + " is ready. (Sneak2.cs)");
    }

    // Called 60 times per second independent of framerate, delta is time since physics process called.
    public override void _PhysicsProcess(float delta)
    {
        // Reset horizontal velocity
        velocity.x = 0;

        // Get user input for horizontal movement
        if (Input.IsActionPressed("right")) { velocity.x += moveSpeed; }
        if (Input.IsActionPressed("left")) { velocity.x -= moveSpeed; }

        // Apply gravity
        velocity.y += gravity * delta;

        // Get user input for vertical movement
        if (Input.IsActionPressed("up")) { }
        if (Input.IsActionPressed("down")) { }

        // Jump on next frame
        if (Input.IsActionJustPressed("jump"))
        {
            // Check if player is on the floor
            if (IsOnFloor())
            {
                // Increment jump counters
                jumpsUsed++;
                jumpsRemaining--;
                justJumped = true;

                // Negative y values are up
                velocity.y = -jumpSpeed;
            }
        }

        // Move the player
        velocity = MoveAndSlide(velocity, Vector2.Up);

        // Flip sprite to match direction player is moving
        sprite = GetNode<Sprite>("Sprite");

        if (velocity.x > 0)
        {
            // Player is moving right
            sprite.FlipH = false;
        }
        else if (velocity.x < 0)
        {
            // Player is moving left
            sprite.FlipH = true;
        }
        else
        {
            // Player is not moving
            // Play idle animation here if it doesn't effect physics or controls
        }
    }
}
