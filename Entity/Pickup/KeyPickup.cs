using Godot;
using System;

public class KeyPickup : Area2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    [Export] public Vector2 doorPos;
    [Export] public NodePath levelMap;
    private TileMap mapRef;
    private bool isPickedUp;
    private AudioStreamPlayer aud_open;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        mapRef = (TileMap) GetNodeOrNull(levelMap);
        // GD.Print(mapRef);
        aud_open = GetNode<AudioStreamPlayer>("DoorOpen");
    }

    public bool _on_KeyPickup_body_entered(Node body){
      // GD.Print(body);
      if(!this.isPickedUp) {
        if(body.Name == "Sneak2") { //FIXME - work with any of the player modes.
          GD.Print("found player");
          mapRef.SetCell((int)doorPos.x, (int)doorPos.y, -1);
          this.Visible = false;
          this.isPickedUp = true;
          aud_open.Play();
          return true;
        }
      }
      return false;
    }


}
