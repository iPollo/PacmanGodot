using Godot;
using System;

public partial class pacman : Area2D
{

    // Nodes
    AnimatedSprite2D pacmanSprite;

    // Privates
    [Export]
    private int pacmanSpeed = 200;
    private Vector2 pacmanMoveDirection = Vector2.Zero;

	public override void _Ready(){
        
        // Init Settings
        pacmanSprite = GetNode("AnimatedSprite2D") as AnimatedSprite2D;
        pacmanSprite.Play();
        
        // Default data
        PacmanChangeDirection(Vector2.Right);
	}
    
	public override void _Process(double delta){
        PacmanMove(delta);
	}

    public override void _Input(InputEvent @event){

        if(@event.IsActionPressed("ui_right")) PacmanChangeDirection(Vector2.Right);
        if(@event.IsActionPressed("ui_left")) PacmanChangeDirection(Vector2.Left);
        if(@event.IsActionPressed("ui_down")) PacmanChangeDirection(Vector2.Down);
        if(@event.IsActionPressed("ui_up")) PacmanChangeDirection(Vector2.Up);

    }

    private void PacmanChangeDirection(Vector2 dir){

        // Update move direction and sprite animation        
        pacmanMoveDirection = dir;

        if(pacmanMoveDirection == Vector2.Left){
            pacmanSprite.Animation = "pacman_move_left";
        }
        if(pacmanMoveDirection == Vector2.Right){
            pacmanSprite.Animation = "pacman_move_right";
        }
        if(pacmanMoveDirection == Vector2.Up){
            pacmanSprite.Animation = "pacman_move_up";
        }
        if(pacmanMoveDirection == Vector2.Down){
            pacmanSprite.Animation = "pacman_move_down";
        }

    }

    private void PacmanMove(double deltaTime){
        this.Position += pacmanMoveDirection * pacmanSpeed * (float)deltaTime;
    }

}
