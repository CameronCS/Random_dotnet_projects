namespace GeoDashClone {
    partial class GeoDashClone {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.TCMenus = new System.Windows.Forms.TabControl();
            this.TPMain = new System.Windows.Forms.TabPage();
            this.MMExitButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.TPLevels = new System.Windows.Forms.TabPage();
            this.PrevLevel = new System.Windows.Forms.Button();
            this.NextLevel = new System.Windows.Forms.Button();
            this.LevelsBack = new System.Windows.Forms.Button();
            this.TCMenus.SuspendLayout();
            this.TPMain.SuspendLayout();
            this.TPLevels.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCMenus
            // 
            this.TCMenus.Controls.Add(this.TPMain);
            this.TCMenus.Controls.Add(this.TPLevels);
            this.TCMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCMenus.Location = new System.Drawing.Point(0, 0);
            this.TCMenus.Name = "TCMenus";
            this.TCMenus.SelectedIndex = 0;
            this.TCMenus.Size = new System.Drawing.Size(1349, 714);
            this.TCMenus.TabIndex = 0;
            // 
            // TPMain
            // 
            this.TPMain.Controls.Add(this.MMExitButton);
            this.TPMain.Controls.Add(this.PlayButton);
            this.TPMain.Location = new System.Drawing.Point(4, 29);
            this.TPMain.Name = "TPMain";
            this.TPMain.Padding = new System.Windows.Forms.Padding(3);
            this.TPMain.Size = new System.Drawing.Size(1341, 681);
            this.TPMain.TabIndex = 0;
            this.TPMain.Text = "TPMain";
            this.TPMain.UseVisualStyleBackColor = true;
            // 
            // MMExitButton
            // 
            this.MMExitButton.Location = new System.Drawing.Point(3, 0);
            this.MMExitButton.Name = "MMExitButton";
            this.MMExitButton.Size = new System.Drawing.Size(40, 40);
            this.MMExitButton.TabIndex = 1;
            this.MMExitButton.Text = "X";
            this.MMExitButton.UseVisualStyleBackColor = true;
            this.MMExitButton.Click += new System.EventHandler(this.MMExitButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(556, 262);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(241, 131);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // TPLevels
            // 
            this.TPLevels.Controls.Add(this.PrevLevel);
            this.TPLevels.Controls.Add(this.NextLevel);
            this.TPLevels.Controls.Add(this.LevelsBack);
            this.TPLevels.Location = new System.Drawing.Point(4, 29);
            this.TPLevels.Name = "TPLevels";
            this.TPLevels.Padding = new System.Windows.Forms.Padding(3);
            this.TPLevels.Size = new System.Drawing.Size(1341, 681);
            this.TPLevels.TabIndex = 1;
            this.TPLevels.Text = "TPLevels";
            this.TPLevels.UseVisualStyleBackColor = true;
            // 
            // PrevLevel
            // 
            this.PrevLevel.Location = new System.Drawing.Point(28, 349);
            this.PrevLevel.Name = "PrevLevel";
            this.PrevLevel.Size = new System.Drawing.Size(30, 50);
            this.PrevLevel.TabIndex = 1;
            this.PrevLevel.Text = "<";
            this.PrevLevel.UseVisualStyleBackColor = true;
            // 
            // NextLevel
            // 
            this.NextLevel.Location = new System.Drawing.Point(1281, 349);
            this.NextLevel.Name = "NextLevel";
            this.NextLevel.Size = new System.Drawing.Size(30, 50);
            this.NextLevel.TabIndex = 1;
            this.NextLevel.Text = ">";
            this.NextLevel.UseVisualStyleBackColor = true;
            // 
            // LevelsBack
            // 
            this.LevelsBack.Location = new System.Drawing.Point(8, 6);
            this.LevelsBack.Name = "LevelsBack";
            this.LevelsBack.Size = new System.Drawing.Size(60, 30);
            this.LevelsBack.TabIndex = 0;
            this.LevelsBack.Text = "<Back";
            this.LevelsBack.UseVisualStyleBackColor = true;
            this.LevelsBack.Click += new System.EventHandler(this.LevelsBack_Click);
            // 
            // GeoDashClone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 714);
            this.Controls.Add(this.TCMenus);
            this.Name = "GeoDashClone";
            this.Text = "Geo Dash Clone";
            this.Load += new System.EventHandler(this.GeoDashClone_Load);
            this.TCMenus.ResumeLayout(false);
            this.TPMain.ResumeLayout(false);
            this.TPLevels.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TCMenus;
        private TabPage TPMain;
        private TabPage TPLevels;
        private Button PlayButton;
        private Button MMExitButton;
        private Button LevelsBack;
        private Button PrevLevel;
        private Button NextLevel;
    }
}