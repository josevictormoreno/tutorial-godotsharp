using System;
using Godot;

namespace Firepot
{
    public partial class Mob : RigidBody2D
    {
        public override void _Ready()
        {
            AnimatedSprite2D animatedSprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
            string[] mobTypes = animatedSprite2D.SpriteFrames.GetAnimationNames();
            animatedSprite2D.Play(mobTypes[GD.Randi() % mobTypes.Length]);
        }

        private void _OnScreenExited()
        {
           GD.Print("saiu da tela notification!");
           QueueFree(); 
        }
    }
}