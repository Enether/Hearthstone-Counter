namespace Hearthstone_Counter
{
    partial class HSCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HSCounter));
            this.loseButton = new System.Windows.Forms.Button();
            this.winButton = new System.Windows.Forms.Button();
            this.winCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lostLabel = new System.Windows.Forms.Label();
            this.priestWinButton = new System.Windows.Forms.Button();
            this.priestLoseButton = new System.Windows.Forms.Button();
            this.defaultbutton = new System.Windows.Forms.Button();
            this.priestbutton = new System.Windows.Forms.Button();
            this.paladinbutton = new System.Windows.Forms.Button();
            this.paladinWinButton = new System.Windows.Forms.Button();
            this.paladinLoseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loseButton
            // 
            this.loseButton.Location = new System.Drawing.Point(407, 295);
            this.loseButton.Name = "loseButton";
            this.loseButton.Size = new System.Drawing.Size(98, 42);
            this.loseButton.TabIndex = 1;
            this.loseButton.Text = "Lost.";
            this.loseButton.UseVisualStyleBackColor = true;
            this.loseButton.Click += new System.EventHandler(this.loseButton_Click);
            // 
            // winButton
            // 
            this.winButton.Location = new System.Drawing.Point(12, 295);
            this.winButton.Name = "winButton";
            this.winButton.Size = new System.Drawing.Size(98, 42);
            this.winButton.TabIndex = 2;
            this.winButton.Text = "Won!";
            this.winButton.UseVisualStyleBackColor = true;
            this.winButton.Click += new System.EventHandler(this.winButton_Click);
            // 
            // winCount
            // 
            this.winCount.AutoSize = true;
            this.winCount.Location = new System.Drawing.Point(24, 91);
            this.winCount.Name = "winCount";
            this.winCount.Size = new System.Drawing.Size(0, 13);
            this.winCount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Won: ";
            // 
            // lostLabel
            // 
            this.lostLabel.AutoSize = true;
            this.lostLabel.Location = new System.Drawing.Point(404, 102);
            this.lostLabel.Name = "lostLabel";
            this.lostLabel.Size = new System.Drawing.Size(33, 13);
            this.lostLabel.TabIndex = 5;
            this.lostLabel.Text = "Lost: ";
            // 
            // priestWinButton
            // 
            this.priestWinButton.Location = new System.Drawing.Point(12, 295);
            this.priestWinButton.Name = "priestWinButton";
            this.priestWinButton.Size = new System.Drawing.Size(98, 42);
            this.priestWinButton.TabIndex = 7;
            this.priestWinButton.Text = "Won!";
            this.priestWinButton.UseVisualStyleBackColor = true;
            this.priestWinButton.Click += new System.EventHandler(this.priestWinButton_Click);
            // 
            // priestLoseButton
            // 
            this.priestLoseButton.Location = new System.Drawing.Point(407, 295);
            this.priestLoseButton.Name = "priestLoseButton";
            this.priestLoseButton.Size = new System.Drawing.Size(98, 42);
            this.priestLoseButton.TabIndex = 8;
            this.priestLoseButton.Text = "Lost.";
            this.priestLoseButton.UseVisualStyleBackColor = true;
            this.priestLoseButton.Click += new System.EventHandler(this.priestLoseButton_Click);
            // 
            // defaultbutton
            // 
            this.defaultbutton.BackColor = System.Drawing.Color.Transparent;
            this.defaultbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.defaultbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.defaultbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultbutton.Image = global::Hearthstone_Counter.Icons.DefaultIcon;
            this.defaultbutton.Location = new System.Drawing.Point(12, 141);
            this.defaultbutton.Name = "defaultbutton";
            this.defaultbutton.Size = new System.Drawing.Size(54, 57);
            this.defaultbutton.TabIndex = 9;
            this.defaultbutton.UseVisualStyleBackColor = true;
            this.defaultbutton.Click += new System.EventHandler(this.defaultbutton_Click);
            // 
            // priestbutton
            // 
            this.priestbutton.BackColor = System.Drawing.Color.Transparent;
            this.priestbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.priestbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.priestbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priestbutton.Image = ((System.Drawing.Image)(resources.GetObject("priestbutton.Image")));
            this.priestbutton.Location = new System.Drawing.Point(72, 141);
            this.priestbutton.Name = "priestbutton";
            this.priestbutton.Size = new System.Drawing.Size(54, 57);
            this.priestbutton.TabIndex = 6;
            this.priestbutton.UseVisualStyleBackColor = true;
            this.priestbutton.Click += new System.EventHandler(this.priestbutton_Click);
            // 
            // paladinbutton
            // 
            this.paladinbutton.BackColor = System.Drawing.Color.Transparent;
            this.paladinbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paladinbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.paladinbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paladinbutton.Image = global::Hearthstone_Counter.Icons.PaladinIcon;
            this.paladinbutton.Location = new System.Drawing.Point(132, 141);
            this.paladinbutton.Name = "paladinbutton";
            this.paladinbutton.Size = new System.Drawing.Size(54, 57);
            this.paladinbutton.TabIndex = 10;
            this.paladinbutton.UseVisualStyleBackColor = true;
            this.paladinbutton.Click += new System.EventHandler(this.paladinbutton_Click);
            // 
            // paladinWinButton
            // 
            this.paladinWinButton.Location = new System.Drawing.Point(12, 295);
            this.paladinWinButton.Name = "paladinWinButton";
            this.paladinWinButton.Size = new System.Drawing.Size(98, 42);
            this.paladinWinButton.TabIndex = 11;
            this.paladinWinButton.Text = "Won!";
            this.paladinWinButton.UseVisualStyleBackColor = true;
            this.paladinWinButton.Click += new System.EventHandler(this.paladinWinButton_Click);
            // 
            // paladinLoseButton
            // 
            this.paladinLoseButton.Location = new System.Drawing.Point(407, 295);
            this.paladinLoseButton.Name = "paladinLoseButton";
            this.paladinLoseButton.Size = new System.Drawing.Size(98, 42);
            this.paladinLoseButton.TabIndex = 12;
            this.paladinLoseButton.Text = "Lost.";
            this.paladinLoseButton.UseVisualStyleBackColor = true;
            this.paladinLoseButton.Click += new System.EventHandler(this.paladinLoseButton_Click);
            // 
            // HSCounter
            // 
            this.ClientSize = new System.Drawing.Size(517, 349);
            this.Controls.Add(this.paladinLoseButton);
            this.Controls.Add(this.paladinWinButton);
            this.Controls.Add(this.paladinbutton);
            this.Controls.Add(this.defaultbutton);
            this.Controls.Add(this.priestLoseButton);
            this.Controls.Add(this.priestWinButton);
            this.Controls.Add(this.priestbutton);
            this.Controls.Add(this.lostLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.winCount);
            this.Controls.Add(this.winButton);
            this.Controls.Add(this.loseButton);
            this.Name = "HSCounter";
            this.Text = "Hearthstone GameCounter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label winCount;
        private System.Windows.Forms.Button priestbutton;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lostLabel;
        public System.Windows.Forms.Button loseButton;
        public System.Windows.Forms.Button winButton;
        public System.Windows.Forms.Button priestWinButton;
        public System.Windows.Forms.Button priestLoseButton;
        private System.Windows.Forms.Button defaultbutton;
        private System.Windows.Forms.Button paladinbutton;
        public System.Windows.Forms.Button paladinWinButton;
        public System.Windows.Forms.Button paladinLoseButton;
    }
}

