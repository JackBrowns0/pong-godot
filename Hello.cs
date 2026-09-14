using Godot;
using System;

public partial class Hello : Node
{
    private int counter = 0;
    private string playerName = "Ralfs";
	private Vector2 spawnPosition = new Vector2(640, 360);

    public override void _Ready()
    {
        GD.Print(counter = 0);
        GD.Print(playerName = "Ralfs");
        GD.Print(spawnPosition = new Vector2(640, 360));
        SayHello();
    }

    public void SayHello()
    {
        counter++;
        GD.Print("Sveiciens Nr. ", counter, " spēlētājam ", playerName);
    }
}
