namespace Hearthstone_Counter
{
    partial class AddLosses
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
            this.MoreLossesLabel = new System.Windows.Forms.Label();
            this.addLossesBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MoreLossesLabel
            // 
            this.MoreLossesLabel.AutoSize = true;
            this.MoreLossesLabel.Location = new System.Drawing.Point(15, 9);
            this.MoreLossesLabel.Name = "MoreLossesLabel";
            this.MoreLossesLabel.Size = new System.Drawing.Size(187, 13);
            this.MoreLossesLabel.TabIndex = 2;
            this.MoreLossesLabel.Text = "Add the amount of losses below (0-99)";
            // 
            // addLossesBox
            // 
            this.addLossesBox.Location = new System.Drawing.Point(73, 43);
            this.addLossesBox.Name = "addLossesBox";
            this.addLossesBox.Size = new System.Drawing.Size(74, 20);
            this.addLossesBox.TabIndex = 3;
            // 
            // AddLosses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 75);
            this.ControlBox = false;
            this.Controls.Add(this.addLossesBox);
            this.Controls.Add(this.MoreLossesLabel);
            this.Name = "AddLosses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add More Losses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MoreLossesLabel;
        private System.Windows.Forms.TextBox addLossesBox;
    }
}