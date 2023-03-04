using Godot;

public class HUD : CanvasLayer
{
    private bool isPaused = false;
    private AnimationPlayer anim;
    private Label menuOpt1;
    private Label menuOpt2;
    private Label menuOpt3;
    private Button menuOpt4;
    private int currentSelect = 1;
    private int menuOptCount = 4;
    private Color c_black = new Color(0, 0, 0, 1);
    private Color c_red = new Color(1, 0, 0, 1);
    private Color c_white = new Color(1, 1, 1, 1);

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        anim = GetNode<AnimationPlayer>("AnimationPlayer");
        anim.PlayBackwards("pause");
        menuOpt1 = GetNode<Label>("MenuBox/ColorRect/MenuOpt1");
        menuOpt2 = GetNode<Label>("MenuBox/ColorRect/MenuOpt2");
        menuOpt3 = GetNode<Label>("MenuBox/ColorRect/MenuOpt3");
        menuOpt4 = GetNode<Button>("MenuBox/ColorRect/MenuOpt4");
        menuOpt1.Modulate = c_red;
    }

    public void onPause()
    {
        // Signal received to pause or unpause game.
        GD.Print("onPause received.");
        if (isPaused)
        {
            // Unpause game and return to normal.
            isPaused = false;
            anim.PlayBackwards("pause");
        }
        else
        {
            // Pause game.
            isPaused = true;
            anim.Play("pause");
        }
    }

    public bool isGamePaused()
    {
        return isPaused;
    }

    public override void _Process(float delta)
    {
        // Handle persistent menu inputs when paused.
        if (isPaused)
        {

        }
    }

    public override void _Input(InputEvent e)
    {
        // Handle individual menu inputs when paused.
        if (isPaused)
        {
            if (e.IsActionPressed("ui_down"))
            {
                menuDown();
            }
            else if (e.IsActionPressed("ui_up"))
            {
                menuUp();
            }
            else if (e.IsActionPressed("ui_select"))
            {
                if (currentSelect == 4)
                {
                    onTestButton(true);
                }
                else
                {
                    GD.Print("pressed 'select' on menu option:");
                    GD.Print(currentSelect);
                }
            }
        }
    }

    private void menuDown()
    {
        // Move the menu option down.
        GD.Print("menu down.");
        currentSelect++;
        if (currentSelect > menuOptCount)
        {
            currentSelect = 1;
        }
        colorMenuOpts();
    }

    private void menuUp()
    {
        // Move the menu option up.
        GD.Print("menu up.");
        currentSelect--;
        if (currentSelect < 1)
        {
            currentSelect = menuOptCount;
        }
        colorMenuOpts();
    }

    private void colorMenuOpts()
    {
        menuOpt1.Modulate = c_black;
        menuOpt2.Modulate = c_black;
        menuOpt3.Modulate = c_black;
        menuOpt4.Modulate = c_white;
        switch (currentSelect)
        {
            case 1:
                menuOpt1.Modulate = c_red;
                break;
            case 2:
                menuOpt2.Modulate = c_red;
                break;
            case 3:
                menuOpt3.Modulate = c_red;
                break;
            case 4:
                menuOpt4.Modulate = c_red;
                break;
            default:
                break;
        }
    }

    public void onTestButton(bool fromKeyboard = false)
    {
        GD.Print("Test button clicked or selected.");
        if (fromKeyboard)
        {
            GD.Print("input came from the keyboard!");
        }
    }

    private void _on_MenuOpt4_pressed()
    {
        onTestButton();
    }

    public bool updateMap(Vector2 mapTile)
    {
        // Given a Vector2 (x,y) of the map tile visited, add it to the display.
        GD.Print("HUD.updateMap - mapTile:");
        GD.Print(mapTile);
        return false;
    }

    public bool centerMap(Vector2 mapCenter)
    {
        // Update the map display to center on a given tile position (usually the current).
        GD.Print("HUD.centerMap - mapCenter:");
        GD.Print(mapCenter);
        return false;
    }
}
