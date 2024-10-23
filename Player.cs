using Godot;
using System;
using System.Security.Cryptography;


public partial class Player : CharacterBody2D
{
	public override void _PhysicsProcess(double delta)
	{
		Vector2 mVelocity = Velocity;
		mVelocity += GetGravity() * (float)delta;

		if(Input.IsActionJustPressed("jump")){
			mVelocity.Y = -350;
		}
		
		Velocity = mVelocity;

		MoveAndSlide();
	}		
	public void collided(Area2D area2d){
		QueueFree();
		GetTree().ReloadCurrentScene();
	}
}