using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbidden_Island.BusinessLayer
{
    internal class Board : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();
        public List<Player> Players { get; private set; }
        public Player CurrentPlayer { get; private set; }
        public int CurrentPlayerIndex { get; private set; }
        public int ActionsLeft { get; private set; } = 3;
        public int Floodmeter { get; private set; } = 0;
        public List<IslandTile> Tiles { get; private set; }

        public Board()
        {
            Players = new List<Player>();
            Tiles = new List<IslandTile>();
        }

        public void SetupBoard(List<string> playerNames)
        {
            foreach (var name in playerNames)
            {
                var player = new Player(name);
                Players.Add(player);
                AssignRole(player);
                player.DrawInitialTreasureCards();
            }
            CurrentPlayer = Players[0];
            InitializeTiles();
            NotifyObservers();
        }

        private void AssignRole(Player player)
        {
            // Assign a role to the player (e.g., Explorer, Pilot, etc.)
        }

        private void InitializeTiles()
        {
            // Initialize island tiles with their initial states
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

        public void MovePlayer(MoveDirection direction)
        {
            if (ActionsLeft > 0)
            {
                CurrentPlayer.Move(direction, this);
                ActionsLeft--;
                NotifyObservers();
            }
        }

        public void DrainFlood(IslandTile tile)
        {
            if (ActionsLeft > 0 && !tile.Flooded)
            {
                tile.DryUp();
                ActionsLeft--;
                NotifyObservers();
            }
        }

        public void CollectTreasure()
        {
            if (ActionsLeft > 0 && CurrentPlayer.CanCollectTreasure(this))
            {
                CurrentPlayer.CollectTreasure();
                ActionsLeft--;
                NotifyObservers();
            }
        }

        public void GiveTreasureCard(Player recipient)
        {
            if (ActionsLeft > 0 && CurrentPlayer.CanGiveTreasureCard(recipient))
            {
                CurrentPlayer.GiveTreasureCard(recipient);
                ActionsLeft--;
                NotifyObservers();
            }
        }

        public void EndTurn()
        {
            ActionsLeft = 3;
            CurrentPlayerIndex = (CurrentPlayerIndex + 1) % Players.Count;
            CurrentPlayer = Players[CurrentPlayerIndex];
            DrawFloodCards();
            NotifyObservers();
        }

        private void DrawFloodCards()
        {
            // Implement flood card drawing logic
        }

        public bool CheckWinCondition()
        {
            // Implement win condition logic
            return false;
        }

        public bool CheckLossCondition()
        {
            // Implement loss condition logic
            return false;
        }
    }
}