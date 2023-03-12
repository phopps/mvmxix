using Godot;

// TODO: Air jump (double jump), wall jump, coyote time, jump buffer, jump cutoff, attack, special, interact, damage

public class Player : Actor
{
    // Player variables can be adjusted live in the Godot Editor while game is running
    // [Export] public float gravity = 0;
    [Export] public float jumpSpeed = 0;
    [Export] public int jumpsUsed = 0;
    [Export] public int jumpsRemaining = 2;
    [Export] public bool isActivePlayer = false;
    [Export] public bool justJumped = false;

    public Sprite _sprite;
    // private string _name;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(Name + " is ready. (Player.cs)");
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

        // Get user input for vertical movement
        GetVerticalInput(delta);

        // Jump on next frame
        Jump();

        // Move the player
        Move();

        // Flip sprite to match direction player is moving
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

    // Adjust physics to match each unique character movement style
    public virtual void AdjustMovementSpeeds() { }

    // Get user input for left and right player movement
    public void GetHorizontalInput()
    {
        // Get user input to set horizontal velocity
        if (Input.IsActionPressed("right")) { velocity.x += moveSpeed; }
        if (Input.IsActionPressed("left")) { velocity.x -= moveSpeed; }
    }

    // Get user input for up and down player movement
    public virtual void GetVerticalInput(float delta)
    {
        // Apply gravity
        velocity.y += gravity * delta;

        // Get user input
        if (Input.IsActionPressed("up")) { }
        if (Input.IsActionPressed("down")) { }
    }

    // Jump and air jump abilities
    public virtual void Jump()
    {
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
    }

    // Move the player
    public virtual void Move()
    {
        // Automatically uses delta in calculations
        velocity = MoveAndSlide(velocity, Vector2.Up);
    }

    // Attack enemies within range, but not obstacles
    public virtual void Attack()
    {
        // Should be same (remove virtual) or similar for all characters
        // Adjust attack strength per character
        // Shared variables, timers, signals, etc.
    }

    // Unique special ability for each character
    public virtual void Special()
    {
        // Override this method for each character
        // Heavy does Thump, Sneak does Dash, Tiny does Launch (superjump)
        // Shared variables, timers, signals, etc.
    }

    // Player can interact with items on map such as switches and gates
    public void Interact()
    {
        // Should be same for all characters, no override needed
        // Shared variables, timers, signals, etc.
    }
}
