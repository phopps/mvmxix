using Godot;

public class Sneak2 : KinematicBody2D
{
    [Export] public bool isActivePlayer = true;
    [Export] public string name;
    [Export] public int health;
    // [Export] public int maxHealth;
    [Export] public float gravity = 3000;
    [Export] public float moveSpeed = 300;
    // [Export] public float maxMoveSpeed = 300;
    [Export] public float jumpSpeed = 450;
    [Export] public Vector2 velocity;
    [Export] public int jumpsUsed = 0;
    [Export] public int jumpsRemaining = 2;
    [Export] public int maxJumpsRemaining = 2;
    [Export] public bool justJumped;
    [Export] public Sprite sprite;
    // private bool hasTripleJump = false;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(Name + " is ready. (Sneak2.cs)");

        // Flip sprite to match direction player is moving
        sprite = GetNode<Sprite>("Sprite");
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
            // Reset jump counters if player is on floor
            if (IsOnFloor())
            {
                jumpsRemaining = maxJumpsRemaining;
                jumpsUsed = 0;
            }

            // Jump if player has jumps remaining
            if (jumpsRemaining >= jumpsUsed)
            {
                Jump();
            }
        }

        // Move the player
        velocity = MoveAndSlide(velocity, Vector2.Up);

        // Check which direction player is moving horizontally
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

    public void Jump()
    {
        // Increment jump counters
        jumpsUsed++;
        jumpsRemaining--;
        // justJumped = true;

        // Negative y values are up
        velocity.y = -jumpSpeed;
    }


    public bool _on_Area2D_area_entered(Node body)
    {
        GD.Print(body);
        // if (body is PowerupPickup)
        // {
        //     PowerupPickup target = (PowerupPickup)body; //FIXME - breaks if the target is not PowerupPickup. Need to make this check safely.
        //     if (target.GetWhichPowerup() == "TripleJump")
        //     {
        //         GD.Print("found triplejump");
        //         this.hasTripleJump = true;
        //         return true;
        //     }
        // }
        // if(!this.isPickedUp) {
        //   if(body.Name == "Sneak2") {
        //     GD.Print("found player");
        //     mapRef.SetCell((int)doorPos.x, (int)doorPos.y, -1);
        //     this.Visible = false;
        //     this.isPickedUp = true;
        //     return true;
        //   }
        // }
        return false;
    }
}
