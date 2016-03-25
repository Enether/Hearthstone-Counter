namespace Hearthstone_Counter
{
    partial class AddWins
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addWinsBox = new System.Windows.Forms.TextBox();
            this.MoreWinsTxtLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addWinsBox
            // 
            this.addWinsBox.Location = new System.Drawing.Point(74, 43);
            this.addWinsBox.Name = "addWinsBox";
            this.addWinsBox.Size = new System.Drawing.Size(74, 20);
            this.addWinsBox.TabIndex = 0;
            // 
            // MoreWinsTxtLabel
            // 
            this.MoreWinsTxtLabel.AutoSize = true;
            this.MoreWinsTxtLabel.Location = new System.Drawing.Point(25, 9);
            this.MoreWinsTxtLabel.Name = "MoreWinsTxtLabel";
            this.MoreWinsTxtLabel.Size = new System.Drawing.Size(179, 13);
            this.MoreWinsTxtLabel.TabIndex = 1;
            this.MoreWinsTxtLabel.Text = "Add the amount of wins below (0-99)";
            // 
            // AddWins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 75);
            this.ControlBox = false;
            this.Controls.Add(this.MoreWinsTxtLabel);
            this.Controls.Add(this.addWinsBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddWins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add More Wins";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addWinsBox;
        private System.Windows.Forms.Label MoreWinsTxtLabel;
    }
}