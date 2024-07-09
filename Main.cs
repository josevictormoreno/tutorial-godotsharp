using Godot;

namespace Firepot
{
    public partial class Main : Node
    {
        [Export] 
        public PackedScene MobScene { get; set; }

        private int _score;

        public void GameOver()
        {
            GetNode<Timer>("MobTimer").Stop();
            GetNode<Timer>("ScoreTimer").Stop();
        }

        public void NewGame()
        {
            _score = 0;
            Player player = GetNode<Player>("Player");
            Marker2D startPosition = GetNode<Marker2D>("StartPosition");
            player.Start(startPosition.Position);
            
            GetNode<Timer>("StartTimer").Start();
        }

        public void OnScoreTimerTimeout()
        {
            _score++;
        }

        public void OnStartTimerTimeout()
        {
            GetNode<Timer>("MobTimer").Start();
            GetNode<Timer>("ScoreTimer").Start();
        }
    }
    
}