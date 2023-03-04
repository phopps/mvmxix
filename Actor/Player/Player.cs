using Godot;

public class Player : Actor
{
    // Player variables can be adjusted live in the Godot Editor while game is running
    [Export] public float gravity = 0;
    [Export] public float jumpSpeed = 0;
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

        // Adjust movement for different characters
        AdjustMovementSpeeds();

        // Get user input for horizontal movement
        GetHorizontalInput();

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

    public virtual void AdjustMovementSpeeds()
    {
        // Set horizontal velocity
        if (Input.IsActionPressed("right"))
        {
            velocity.x += moveSpeed;
        }
        if (Input.IsActionPressed("left"))
        {
            velocity.x -= moveSpeed;
        }
    }

    public void GetHorizontalInput()
    {
        // Set horizontal velocity
        if (Input.IsActionPressed("right"))
        {
            this.velocity.x += this.moveSpeed;
        }
        if (Input.IsActionPressed("left"))
        {
            this.velocity.x -= this.moveSpeed;
        }
    }

    // Jump and air jump abilities
    public virtual void Jump()
    {
        // Increment jump counters
        jumpsUsed++;
        jumpsRemaining--;
        justJumped = true;

        // Negative y values are up
        velocity.y = -jumpSpeed;
    }
}
