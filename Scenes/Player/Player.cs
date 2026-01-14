using Godot;
using System;

public partial class Player : CharacterBody2D
{
	public const string GroupName = "player";

	private enum PlayerState { Idle, Hurt, Fly }

	 private float _speed = 300f;
	 private float _rotationspeed = 150.0f;
	 private bool _invincible = false; 

	[Export] private Sprite2D _sprite;


	public override void _Ready()
	{
	}

	public override void _PhysicsProcess(double delta)
	{
	}

	private void GetInput()
	{
		
	}
}
