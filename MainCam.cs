using Godot;

public class MainCam : Camera2D
{
    [Export] public NodePath target;
    [Export] public float align_time = 0.2f;
    [Export] public Vector2 screen_size = new Vector2(720, 480);
    private Node2D Target;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(Name + " is ready. (MainCam.cs)");
        Target = (Node2D)GetNodeOrNull(target);
        MakeCurrent();
    }

    // public override void _Process(float delta) {

    //   SceneTreeTween t = CreateTween().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Quint);
    //   t.TweenProperty(this, "offset", desired_position(), align_time);
    // }

    public override void _PhysicsProcess(float delta)
    {
        // if (! IsInstanceValid(Target)) {
        //   Godot.Collections.Array targets = GetTree().GetNodesInGroup("Player");
        //   if (targets != null) {
        //     Target = targets[0];
        //   }
        // }
        // if (! IsInstanceValid(Target)) {
        //   return;
        // }
        SceneTreeTween t = CreateTween().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Quint);
        t.TweenProperty(this, "offset", desired_position(), align_time);
        // Position = desired_position();
        // GD.Print(GetCameraScreenCenter());
    }

    private Vector2 desired_position()
    {
        // Vector2 v = Target.Position;
        // GD.Print(v);
        Vector2 output = (Target.Position / screen_size).Floor() * screen_size + screen_size / 2;
        // GD.Print(output);
        return output;
    }

    public void setTarget(Node2D target)
    {
        Target = target;
    }
}