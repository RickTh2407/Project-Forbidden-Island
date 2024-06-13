using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Forbidden_Island.BusinessLayer;

namespace Forbidden_Island
{
    public partial class MainGame : Form, IObserver
    {
        private GameController controller;
        private Game game;

        public MainGame()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            controller = GameController.Instance;
            List<string> playerNames = new List<string> { "Player 1", "Player 2" }; // Example names
            controller.StartGame(playerNames);
            game = controller.Game;
            game.Board.RegisterObserver(this);
            UpdateUI();
        }

        public void Update()
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            lblActionCount.Text = $"Actions: {game.Board.ActionsLeft}";
            lblCurrentPlayer.Text = $"Current Player: {game.Board.CurrentPlayer.Name}";
            lblFloodMeter.Text = $"Flood Meter: {game.Board.Floodmeter}";
            lblInventory.Text = $"Inventory: {string.Join(", ", game.Board.CurrentPlayer.Inventory)}";
        }

        private void DirectionalButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MoveDirection direction;

            if (btn == btnUp) direction = MoveDirection.Up;
            else if (btn == btnDown) direction = MoveDirection.Down;
            else if (btn == btnLeft) direction = MoveDirection.Left;
            else if (btn == btnRight) direction = MoveDirection.Right;
            else return;

            game.Board.MovePlayer(direction);
        }

        private void btnDeflood_Click(object sender, EventArgs e)
        {
            // Example of deflooding a specific tile (for simplicity)
            var tileToDeflood = game.Board.Tiles[0]; // Change as needed
            game.Board.DrainFlood(tileToDeflood);
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            game.Board.EndTurn();
        }
    }
}
