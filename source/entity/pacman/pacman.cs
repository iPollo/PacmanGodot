using Godot;
using System;

public partial class pacman : Area2D
{

    [Export]
    private int pacmanSpeed = 100;
    private Vector2 pacmanMoveDirection;

    // Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        pacmanMoveDirection.X = 1;
        pacmanMoveDirection.Y = 0;
	}
    

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
        if(Input.IsActionJustPressed("move_right")){
            
        }
        else if(Input.IsActionJustPressed("move_left")){

        }
        else if(Input.IsActionJustPressed("move_down")){

        }
        else if(Input.IsActionJustPressed("move_up")){

        }


	}

    
    private void processInput(){
        
        // VERIFICAR se HÁ COLISÃO
        if(checkCollisions()){
            
        }

        // SE NÃO HOUVER COLISÃO MUDAR A DIREÇÃO
        // SE HOUVER MANTER O BOTÃO COMO PRÓXIMO MOVIMENTO

    }

    private bool checkCollisions(){
        return false;
    }

    private void pacmanChangeDirection(){



    }

    private void pacmanMove(){

    }

}
