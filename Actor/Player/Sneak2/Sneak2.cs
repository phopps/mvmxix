using Godot;

public class Sneak2 : KinematicBody2D
{
    [Export] public bool isActivePlayer = true;
    [Export] public string name;
    [Export] public int maxHealth = 50;
    private int health;
    [Export] public float gravity = 3000;
    [Export] public float acceleration = 300;
    [Export] public float maxMoveSpeed = 300;
    [Export] public float friction = 100;
    [Export] public float frictionDeadZone = 0.01f;
    [Export] public float jumpSpeed = 450;
    [Export] public Vector2 velocity;
    [Export] public int jumpsUsed = 0;
    [Export] public int jumpsRemaining = 2;
    [Export] public int maxJumpsRemaining = 2;
    [Export] public bool justJumped;
    private Sprite sprite;
    private bool hasTripleJump = false;
    private AudioStreamPlayer aud_step;
    private AudioStreamPlayer aud_landing;
    private bool wasOnFloorLastFrame = false;
    private float timeSinceLastLanding = 0.0f;
    private bool playerUsedJump = false;
    private Area2D attackHitbox;
    private AnimationPlayer anim;
    private AnimationPlayer iframesAnim;
    [Export] public float iframes = 1.0f;
    private float timeUntilVuln = 0.0f;
    private bool isDead = false;
    private bool isDashing = false;
    private float dashDuration = 0.5f;
    private float dashTimer = 0.0f;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(Name + " is ready. (Sneak2.cs)");

        health = maxHealth;

        // Flip sprite to match direction player is moving
        sprite = GetNode<Sprite>("Sprite");

        aud_step = GetNode<AudioStreamPlayer>("Footstep");
        aud_landing = GetNode<AudioStreamPlayer>("JumpLanding");
        attackHitbox = GetNode<Area2D>("AttackHitbox");
        anim = GetNode<AnimationPlayer>("AnimationPlayer");
        iframesAnim = GetNode<AnimationPlayer>("IframesAnimation");
    }

    // Called 60 times per second independent of framerate, delta is time since physics process called.
    public override void _PhysicsProcess(float delta)
    {
        // Reset horizontal velocity
        velocity.x = 0;

        // Get user input for horizontal movement
        if (!isDead)
        {
            if (Input.IsActionPressed("right")) { velocity.x += maxMoveSpeed; }
            if (Input.IsActionPressed("left")) { velocity.x -= maxMoveSpeed; }
        }

        // Different approach
        // if (Input.IsActionPressed("right")) {
        //   if(velocity.x < 0) {
        //     velocity.x += acceleration * delta * 2;
        //   } else {
        //     velocity.x += acceleration * delta;
        //   }
        //   if (velocity.x > maxMoveSpeed) {
        //     velocity.x = maxMoveSpeed;
        //   }
        // } 
        // if (Input.IsActionPressed("left")) {
        //   if(velocity.x > 0) {
        //     velocity.x -= acceleration * delta * 2;
        //   } else {
        //     velocity.x -= acceleration * delta;
        //   }
        //   if (velocity.x < maxMoveSpeed*-1) {
        //     velocity.x = maxMoveSpeed*-1;
        //   }
        // }
        // if( !Input.IsActionPressed("left") && !Input.IsActionPressed("right")) {
        //   //no input, slow towards zero
        //   if (velocity.x > frictionDeadZone) {
        //     velocity.x -= friction * delta;
        //   } else if (velocity.x < frictionDeadZone*-1) {
        //     velocity.x += friction * delta;
        //   } else {
        //     velocity.x = 0;
        //   }
        // }

        // Apply gravity
        if(!isDashing) {
          velocity.y += gravity * delta;
        }

        // Get user input for vertical movement
        if (Input.IsActionPressed("up")) { }
        if (Input.IsActionPressed("down")) { }


        // if (Input.IsActionPressed("attack")) {
        //   AttackInput();
        // }

        // Jump on next frame
        if (!isDead)
        {
            if (Input.IsActionJustPressed("jump"))
            {
                // Jump if player has jumps remaining
                if (jumpsRemaining >= jumpsUsed)
                {
                    Jump();
                }
            }
        }
        // Reset jump counters if player is on floor
        if (IsOnFloor())
        {
            // GD.Print("on the ground.");
            jumpsRemaining = maxJumpsRemaining;
            jumpsUsed = 0;
            if (!wasOnFloorLastFrame)
            {
                // GD.Print("======== Just landed!!!! =======");
                //play landing
                if (playerUsedJump)
                {
                    aud_landing.Play();
                    // GD.Print("set playerUsedJump to false");
                    playerUsedJump = false;
                }
                wasOnFloorLastFrame = true;
                // timeSinceLastLanding = 0.0f;
            }
        }
        else
        {
            // GD.Print("in the air?");
            wasOnFloorLastFrame = false;
        }
        // timeSinceLastLanding += delta;

        // Move the player
        velocity = MoveAndSlide(velocity, Vector2.Up);

        if (velocity.x != 0 && !aud_step.Playing && IsOnFloor())
        {
            aud_step.Play();
        }

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

        //handle iframes
        if (timeUntilVuln > 0)
        {
            timeUntilVuln -= delta;
        }
    }

    public void Dash() {
      if(dashTimer > 0 || isDashing == true) {
        return;
      } else {
        //dash in a direction
        isDashing = true;
        dashTimer = dashDuration;
      }
    }

    public override void _Input(InputEvent @event)
    {
        if (@event.IsActionPressed("attack"))
        {
            AttackInput();
        }

        if (@event.IsActionPressed("respawn"))
        {
            isDead = false;
        }
    }

    public void AttackInput()
    {
        //this is when the user triggers the event
        // GD.Print("Attackinput called");
        //flip necessary things horizontal.
        if (sprite.FlipH)
        {
            anim.Play("AttackLeft");
        }
        else
        {
            anim.Play("AttackRight");
        }
    }

    public void CheckAttackTargets()
    {
        //triggered when the animation has an active hitbox, should we deal damage to targets?

        Godot.Collections.Array targets = attackHitbox.GetOverlappingBodies();

        foreach (PhysicsBody2D body in targets)
        {
            if (body is Enemy enemy)
            {
                enemy.ReceiveDamage();
            }
            else
            {
                // GD.Print("Found other bodies that were not enemies");
                // GD.Print(body);
            }
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
        // GD.Print("set playerUsedJump to true");
        playerUsedJump = true;
    }

    public bool _on_Area2D_area_entered(Node body)
    {
        GD.Print(body);
        if (body is PowerupPickup target)
        {
            if (target.GetWhichPowerup() == "TripleJump")
            {
                GD.Print("found triplejump");
                hasTripleJump = true;
                return true;
            }
            else if (target.GetWhichPowerup() == "CaveSpawn")
            {
                GD.Print("reset spawn point to cave");
                Node parent = GetParent();
                if (parent is TestLevel level)
                {
                    level.UpdateSpawn("CaveSpawn");
                }
                return true;
            }
        }

        return false;
    }

    public bool _on_ItemCollectHitbox_body_entered(Node body)
    {
        if (body is Enemy enemy)
        {
            GD.Print("incoming body is enemy");
            ReceiveDamage(enemy.attackDamage);
        }
        return false;
    }

    public bool ReceiveDamage(int amount)
    {
        GD.Print("Sneak receive damage: " + amount);
        if (timeUntilVuln > 0)
        {
            GD.Print("still in iframes");
            return true;
        }
        else
        {
            health -= amount;
            if (health <= 0)
            {
                GD.Print("GAME OVER!");
                //remove player control.
                iframesAnim.Play("Dead");
                isDead = true;

                return false;
            }
            else
            {
                timeUntilVuln = iframes;
                //play flashing iframes animation
                iframesAnim.Play("Blinking");
                return true;
            }
        }
    }

    public void _on_IframesAnimation_animation_finished(string which)
    {
        GD.Print("iframes animation finished: " + which);
        if (which == "Dead")
        {
            Node parent = GetParent();
            if (parent is TestLevel level)
            {
                level.UpdateSpawn("PlayerSpawn");
                level.Respawn();
                isDead = false;
                health = maxHealth;
            }
        }
    }
}
