using System.Drawing;


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
            this.loseButton = new Hearthstone_Counter.NoFocusCueButton();
            this.winButton = new Hearthstone_Counter.NoFocusCueButton();
            this.winCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lostLabel = new System.Windows.Forms.Label();
            this.roguebutton = new Hearthstone_Counter.NoFocusCueButton();
            this.magebutton = new Hearthstone_Counter.NoFocusCueButton();
            this.hunterbutton = new Hearthstone_Counter.NoFocusCueButton();
            this.warlockbutton = new Hearthstone_Counter.NoFocusCueButton();
            this.shamanbutton = new Hearthstone_Counter.NoFocusCueButton();
            this.druidbutton = new Hearthstone_Counter.NoFocusCueButton();
            this.paladinbutton = new Hearthstone_Counter.NoFocusCueButton();
            this.defaultbutton = new Hearthstone_Counter.NoFocusCueButton();
            this.priestbutton = new Hearthstone_Counter.NoFocusCueButton();
            this.warriorbutton = new Hearthstone_Counter.NoFocusCueButton();
            this.resetbutton = new Hearthstone_Counter.NoFocusCueButton();
            this.defwinPlabel = new System.Windows.Forms.Label();
            this.moreWinsButton = new Hearthstone_Counter.NoFocusCueButton();
            this.moreLossesButton = new Hearthstone_Counter.NoFocusCueButton();
            this.SuspendLayout();
            // 
            // loseButton
            // 
            this.loseButton.Location = new System.Drawing.Point(407, 295);
            this.loseButton.Name = "loseButton";
            this.loseButton.Size = new System.Drawing.Size(98, 42);
            this.loseButton.TabIndex = 1;
            this.loseButton.Tag = "";
            this.loseButton.Text = "Lost.";
            this.loseButton.UseVisualStyleBackColor = true;
            this.loseButton.Click += new System.EventHandler(this.loseButton_Click);
            // 
            // winButton
            // 
            this.winButton.CausesValidation = false;
            this.winButton.Location = new System.Drawing.Point(12, 295);
            this.winButton.Name = "winButton";
            this.winButton.Size = new System.Drawing.Size(98, 42);
            this.winButton.TabIndex = 2;
            this.winButton.TabStop = false;
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Won: ";
            // 
            // lostLabel
            // 
            this.lostLabel.AutoSize = true;
            this.lostLabel.BackColor = System.Drawing.Color.Transparent;
            this.lostLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lostLabel.Location = new System.Drawing.Point(404, 102);
            this.lostLabel.Name = "lostLabel";
            this.lostLabel.Size = new System.Drawing.Size(33, 13);
            this.lostLabel.TabIndex = 5;
            this.lostLabel.Text = "Lost: ";
            // 
            // roguebutton
            // 
            this.roguebutton.BackColor = System.Drawing.Color.Transparent;
            this.roguebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roguebutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roguebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roguebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roguebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roguebutton.Image = global::Hearthstone_Counter.Icons.RogueIcon;
            this.roguebutton.Location = new System.Drawing.Point(132, 141);
            this.roguebutton.Name = "roguebutton";
            this.roguebutton.Size = new System.Drawing.Size(54, 57);
            this.roguebutton.TabIndex = 28;
            this.roguebutton.UseVisualStyleBackColor = true;
            this.roguebutton.Click += new System.EventHandler(this.roguebutton_Click);
            // 
            // magebutton
            // 
            this.magebutton.BackColor = System.Drawing.Color.Transparent;
            this.magebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.magebutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.magebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.magebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.magebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.magebutton.Image = global::Hearthstone_Counter.Icons.MageIcon;
            this.magebutton.Location = new System.Drawing.Point(432, 141);
            this.magebutton.Name = "magebutton";
            this.magebutton.Size = new System.Drawing.Size(54, 57);
            this.magebutton.TabIndex = 25;
            this.magebutton.UseVisualStyleBackColor = true;
            this.magebutton.Click += new System.EventHandler(this.magebutton_Click);
            // 
            // hunterbutton
            // 
            this.hunterbutton.BackColor = System.Drawing.Color.Transparent;
            this.hunterbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hunterbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hunterbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hunterbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hunterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hunterbutton.Image = global::Hearthstone_Counter.Icons.hunter_4;
            this.hunterbutton.Location = new System.Drawing.Point(252, 141);
            this.hunterbutton.Name = "hunterbutton";
            this.hunterbutton.Size = new System.Drawing.Size(54, 57);
            this.hunterbutton.TabIndex = 22;
            this.hunterbutton.UseVisualStyleBackColor = true;
            this.hunterbutton.Click += new System.EventHandler(this.hunterbutton_Click);
            // 
            // warlockbutton
            // 
            this.warlockbutton.BackColor = System.Drawing.Color.Transparent;
            this.warlockbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.warlockbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.warlockbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.warlockbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.warlockbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warlockbutton.Image = global::Hearthstone_Counter.Icons.WarlockIcon;
            this.warlockbutton.Location = new System.Drawing.Point(312, 141);
            this.warlockbutton.Name = "warlockbutton";
            this.warlockbutton.Size = new System.Drawing.Size(54, 57);
            this.warlockbutton.TabIndex = 19;
            this.warlockbutton.UseVisualStyleBackColor = true;
            this.warlockbutton.Click += new System.EventHandler(this.warlockbutton_Click);
            // 
            // shamanbutton
            // 
            this.shamanbutton.BackColor = System.Drawing.Color.Transparent;
            this.shamanbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.shamanbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shamanbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.shamanbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.shamanbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shamanbutton.Image = global::Hearthstone_Counter.Icons.ShamanIcon;
            this.shamanbutton.Location = new System.Drawing.Point(12, 204);
            this.shamanbutton.Name = "shamanbutton";
            this.shamanbutton.Size = new System.Drawing.Size(54, 57);
            this.shamanbutton.TabIndex = 16;
            this.shamanbutton.UseVisualStyleBackColor = true;
            this.shamanbutton.Click += new System.EventHandler(this.shamanbutton_Click);
            // 
            // druidbutton
            // 
            this.druidbutton.BackColor = System.Drawing.Color.Transparent;
            this.druidbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.druidbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.druidbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.druidbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.druidbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.druidbutton.Image = global::Hearthstone_Counter.Icons.DruidIcon;
            this.druidbutton.Location = new System.Drawing.Point(72, 204);
            this.druidbutton.Name = "druidbutton";
            this.druidbutton.Size = new System.Drawing.Size(54, 57);
            this.druidbutton.TabIndex = 13;
            this.druidbutton.UseVisualStyleBackColor = true;
            this.druidbutton.Click += new System.EventHandler(this.druidbutton_Click);
            // 
            // paladinbutton
            // 
            this.paladinbutton.BackColor = System.Drawing.Color.Transparent;
            this.paladinbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paladinbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.paladinbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.paladinbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.paladinbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paladinbutton.Image = global::Hearthstone_Counter.Icons.PaladinIcon;
            this.paladinbutton.Location = new System.Drawing.Point(192, 141);
            this.paladinbutton.Name = "paladinbutton";
            this.paladinbutton.Size = new System.Drawing.Size(54, 57);
            this.paladinbutton.TabIndex = 10;
            this.paladinbutton.UseVisualStyleBackColor = true;
            this.paladinbutton.Click += new System.EventHandler(this.paladinbutton_Click);
            // 
            // defaultbutton
            // 
            this.defaultbutton.BackColor = System.Drawing.Color.Transparent;
            this.defaultbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.defaultbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.defaultbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.defaultbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
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
            this.priestbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.priestbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.priestbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.priestbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priestbutton.Image = global::Hearthstone_Counter.Icons.priestIcon;
            this.priestbutton.Location = new System.Drawing.Point(372, 141);
            this.priestbutton.Name = "priestbutton";
            this.priestbutton.Size = new System.Drawing.Size(54, 57);
            this.priestbutton.TabIndex = 6;
            this.priestbutton.UseVisualStyleBackColor = true;
            this.priestbutton.Click += new System.EventHandler(this.priestbutton_Click);
            // 
            // warriorbutton
            // 
            this.warriorbutton.BackColor = System.Drawing.Color.Transparent;
            this.warriorbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.warriorbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.warriorbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.warriorbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.warriorbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warriorbutton.Image = global::Hearthstone_Counter.Icons.WarriorIcon;
            this.warriorbutton.Location = new System.Drawing.Point(72, 141);
            this.warriorbutton.Name = "warriorbutton";
            this.warriorbutton.Size = new System.Drawing.Size(54, 57);
            this.warriorbutton.TabIndex = 31;
            this.warriorbutton.UseVisualStyleBackColor = true;
            this.warriorbutton.Click += new System.EventHandler(this.warriorbutton_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(4, 12);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(106, 34);
            this.resetbutton.TabIndex = 34;
            this.resetbutton.Text = "Reset Score";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // defwinPlabel
            // 
            this.defwinPlabel.AutoSize = true;
            this.defwinPlabel.BackColor = System.Drawing.Color.Transparent;
            this.defwinPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.defwinPlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.defwinPlabel.Location = new System.Drawing.Point(9, 76);
            this.defwinPlabel.Name = "defwinPlabel";
            this.defwinPlabel.Size = new System.Drawing.Size(48, 15);
            this.defwinPlabel.TabIndex = 44;
            this.defwinPlabel.Text = "Win %: ";
            // 
            // moreWinsButton
            // 
            this.moreWinsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreWinsButton.Location = new System.Drawing.Point(116, 295);
            this.moreWinsButton.Name = "moreWinsButton";
            this.moreWinsButton.Size = new System.Drawing.Size(59, 43);
            this.moreWinsButton.TabIndex = 45;
            this.moreWinsButton.Text = "Add More...";
            this.moreWinsButton.UseVisualStyleBackColor = true;
            this.moreWinsButton.Click += new System.EventHandler(this.moreWinsButton_Click);
            // 
            // moreLossesButton
            // 
            this.moreLossesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreLossesButton.Location = new System.Drawing.Point(342, 295);
            this.moreLossesButton.Name = "moreLossesButton";
            this.moreLossesButton.Size = new System.Drawing.Size(59, 43);
            this.moreLossesButton.TabIndex = 46;
            this.moreLossesButton.Tag = "";
            this.moreLossesButton.Text = "Add More...";
            this.moreLossesButton.UseVisualStyleBackColor = true;
            this.moreLossesButton.Click += new System.EventHandler(this.moreLossesButton_Click);
            // 
            // HSCounter
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::Hearthstone_Counter.Background.defaultBG;
            this.ClientSize = new System.Drawing.Size(517, 349);
            this.Controls.Add(this.moreLossesButton);
            this.Controls.Add(this.moreWinsButton);
            this.Controls.Add(this.defwinPlabel);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.warriorbutton);
            this.Controls.Add(this.roguebutton);
            this.Controls.Add(this.magebutton);
            this.Controls.Add(this.hunterbutton);
            this.Controls.Add(this.warlockbutton);
            this.Controls.Add(this.shamanbutton);
            this.Controls.Add(this.druidbutton);
            this.Controls.Add(this.paladinbutton);
            this.Controls.Add(this.defaultbutton);
            this.Controls.Add(this.priestbutton);
            this.Controls.Add(this.lostLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.winCount);
            this.Controls.Add(this.winButton);
            this.Controls.Add(this.loseButton);
            this.Name = "HSCounter";
            this.Text = "Hearthstone GameCounter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HSCounter_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.HSCounter_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label winCount;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lostLabel;
        public System.Windows.Forms.Label defwinPlabel;
        public NoFocusCueButton loseButton;
        public NoFocusCueButton winButton;
        public NoFocusCueButton magebutton;
        public NoFocusCueButton paladinbutton;
        public NoFocusCueButton priestbutton;
        public NoFocusCueButton defaultbutton;
        public NoFocusCueButton druidbutton;
        public NoFocusCueButton shamanbutton;
        public NoFocusCueButton warlockbutton;
        public NoFocusCueButton hunterbutton;
        public NoFocusCueButton roguebutton;
        public NoFocusCueButton warriorbutton;
        public NoFocusCueButton resetbutton;
        private NoFocusCueButton moreWinsButton;
        private NoFocusCueButton moreLossesButton;
    }
}

