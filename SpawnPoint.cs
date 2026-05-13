using Godot;

public partial class SpawnPoint : Node2D
{
    [Export] public PackedScene Npc;       // assign your sprite scene in the Inspector
    [Export] public float MinInterval = 3.0f;
    [Export] public float MaxInterval = 7.0f;

    private Timer _timer;

    public override void _Ready()
    {
        _timer = new Timer();
        AddChild(_timer);
        _timer.OneShot = false;                     // we manually restart with a new random time each cycle
        _timer.Timeout += OnTimerTimeout;
        StartTimer();
    }

    private void StartTimer()
    {
        float interval = (float)GD.RandRange(MinInterval, MaxInterval);
        _timer.WaitTime = interval;
        _timer.Start();
    }

    private void OnTimerTimeout()
    {
        SpawnSprite();
        StartTimer();                              // restart with a new random interval
    }

    private void SpawnSprite()
    {
        if (Npc == null)
        {
            GD.PrintErr("SpawnPoint: No scene assigned!");
            return;
        }

        Node2D instance = Npc.Instantiate<Node2D>();
        GetParent().AddChild(instance);            // spawn into parent so it isn't tied to this node
        instance.GlobalPosition = GlobalPosition; // spawn at this node's position
    }
}
