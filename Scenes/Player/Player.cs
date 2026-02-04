using Godot;
using System;
// Signed: {_Outcast 0-}

public partial class Player : CharacterBody2D
{
	public const string GroupName = "player";

	private enum PlayerState { Idle, Hurt, Fly }

	 private float _speed = 150.0f;
	 private float _rotationSpeed = 1.5f;
	 private float _rotationDirection;
	 private bool _invincible = false; 

	[Export] private Sprite2D _sprite;


	public override void _Ready()
	{
	}

	public override void _PhysicsProcess(double delta)
	{
		GetInput();
		Rotation += _rotationDirection * _rotationSpeed * (float)delta;
		MoveAndSlide();
	}

	private void GetInput()
	{
		Vector2 inputDirection = Input.GetVector("left", "right", "up", "down");
		Velocity = inputDirection * _speed;
	}
}
