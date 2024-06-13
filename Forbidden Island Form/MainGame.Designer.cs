namespace Forbidden_Island
{
    partial class MainGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblActionCount = new System.Windows.Forms.Label();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.lblFloodMeter = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDeflood = new System.Windows.Forms.Button();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblActionCount
            // 
            this.lblActionCount.AutoSize = true;
            this.lblActionCount.Location = new System.Drawing.Point(12, 9);
            this.lblActionCount.Name = "lblActionCount";
            this.lblActionCount.Size = new System.Drawing.Size(77, 15);
            this.lblActionCount.TabIndex = 0;
            this.lblActionCount.Text = "Action Count";
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(12, 34);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(85, 15);
            this.lblCurrentPlayer.TabIndex = 1;
            this.lblCurrentPlayer.Text = "Current Player";
            // 
            // lblFloodMeter
            // 
            this.lblFloodMeter.AutoSize = true;
            this.lblFloodMeter.Location = new System.Drawing.Point(12, 59);
            this.lblFloodMeter.Name = "lblFloodMeter";
            this.lblFloodMeter.Size = new System.Drawing.Size(72, 15);
            this.lblFloodMeter.TabIndex = 2;
            this.lblFloodMeter.Text = "Flood Meter";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(12, 84);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(61, 15);
            this.lblInventory.TabIndex = 3;
            this.lblInventory.Text = "Inventory";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(100, 150);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.DirectionalButton_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(100, 200);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.DirectionalButton_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(50, 175);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.DirectionalButton_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(150, 175);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 7;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.DirectionalButton_Click);
            // 
            // btnDeflood
            // 
            this.btnDeflood.Location = new System.Drawing.Point(12, 125);
            this.btnDeflood.Name = "btnDeflood";
            this.btnDeflood.Size = new System.Drawing.Size(75, 23);
            this.btnDeflood.TabIndex = 8;
            this.btnDeflood.Text = "Deflood";
            this.btnDeflood.UseVisualStyleBackColor = true;
            this.btnDeflood.Click += new System.EventHandler(this.btnDeflood_Click);
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Location = new System.Drawing.Point(12, 175);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(75, 23);
            this.btnEndTurn.TabIndex = 9;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.btnDeflood);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblFloodMeter);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.lblActionCount);
            this.Name = "MainGame";
            this.Text = "Forbidden Island";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblActionCount;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.Label lblFloodMeter;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDeflood;
        private System.Windows.Forms.Button btnEndTurn;
    }
}
