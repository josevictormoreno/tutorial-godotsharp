using Godot;

namespace Firepot
{
    public partial class Main : Node
    {
        [Export] 
        public PackedScene MobScene { get; set; }

        private int _score;
    }
}