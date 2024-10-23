using Godot;
using System;

public partial class Main : Node2D
{
	[Export]
	public PackedScene PipeScene {get; set;}

	[Export]
	public PackedScene PipeScene2 {get; set;}

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void OnTimeout(){
		Pipe pipe = PipeScene.Instantiate<Pipe>();
		pipe.Position = GetNode<Marker2D>("pipeSpawn").Position;
		Random height = new Random();
		pipe.Position += new Vector2(0,height.Next(-33,33));
		AddChild(pipe);
		GD.Print("spawn pipe");
		
	}

	public void OnTimeout2(){
		Pipe2 pipe2 = PipeScene2.Instantiate<Pipe2>();
		pipe2.Position = GetNode<Marker2D>("pipeSpawn2").Position;
		Random height = new Random();
		pipe2.Position += new Vector2(0,height.Next(-33,33));
		AddChild(pipe2);
		GD.Print("spawn pipe2");
	}
}
