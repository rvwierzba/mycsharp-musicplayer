namespace MyCsharpMusicPlayer
{
    partial class MyCsharpMusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCsharpMusicPlayer));
            TopPanel = new Panel();
            minimizeBtn = new PictureBox();
            closeBtn = new PictureBox();
            lblLogo = new Label();
            listBoxSongs = new ListBox();
            btnSelectSongs = new Button();
            lblFooter = new Label();
            linkLabel = new LinkLabel();
            vlcPlayer = new LibVLCSharp.WinForms.VideoView();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minimizeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vlcPlayer).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.Plum;
            TopPanel.Controls.Add(minimizeBtn);
            TopPanel.Controls.Add(closeBtn);
            TopPanel.Controls.Add(lblLogo);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(800, 49);
            TopPanel.TabIndex = 0;
            // 
            // minimizeBtn
            // 
            minimizeBtn.Image = (Image)resources.GetObject("minimizeBtn.Image");
            minimizeBtn.Location = new Point(683, 3);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(54, 46);
            minimizeBtn.TabIndex = 2;
            minimizeBtn.TabStop = false;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Image = (Image)resources.GetObject("closeBtn.Image");
            closeBtn.Location = new Point(743, 3);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(45, 43);
            closeBtn.TabIndex = 1;
            closeBtn.TabStop = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogo.Location = new Point(18, 13);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(181, 22);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "My Csharp Music Player";
            // 
            // listBoxSongs
            // 
            listBoxSongs.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.Location = new Point(555, 65);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.Size = new Size(233, 304);
            listBoxSongs.TabIndex = 1;
            listBoxSongs.SelectedIndexChanged += listBoxSongs_SelectedIndexChanged;
            // 
            // btnSelectSongs
            // 
            btnSelectSongs.BackColor = Color.LimeGreen;
            btnSelectSongs.FlatStyle = FlatStyle.Flat;
            btnSelectSongs.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectSongs.ForeColor = Color.White;
            btnSelectSongs.Location = new Point(555, 375);
            btnSelectSongs.Name = "btnSelectSongs";
            btnSelectSongs.Size = new Size(233, 63);
            btnSelectSongs.TabIndex = 2;
            btnSelectSongs.Text = "Selecionar Músicas";
            btnSelectSongs.UseVisualStyleBackColor = false;
            btnSelectSongs.Click += btnSelectSongs_Click;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFooter.Location = new Point(171, 441);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(139, 20);
            lblFooter.TabIndex = 4;
            lblFooter.Text = "Desenvolvido por: ";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel.Location = new Point(306, 441);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(127, 20);
            linkLabel.TabIndex = 5;
            linkLabel.TabStop = true;
            linkLabel.Text = "Rafael V. Wierzba";
            linkLabel.LinkClicked += linkLabel_LinkClicked;
            // 
            // vlcPlayer
            // 
            vlcPlayer.BackColor = Color.Black;
            vlcPlayer.Location = new Point(12, 65);
            vlcPlayer.MediaPlayer = null;
            vlcPlayer.Name = "vlcPlayer";
            vlcPlayer.Size = new Size(537, 373);
            vlcPlayer.TabIndex = 6;
            // 
            // MyCsharpMusicPlayer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 468);
            Controls.Add(vlcPlayer);
            Controls.Add(linkLabel);
            Controls.Add(lblFooter);
            Controls.Add(btnSelectSongs);
            Controls.Add(listBoxSongs);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MyCsharpMusicPlayer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Csharp Music Player";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minimizeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)vlcPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Label lblLogo;
        private PictureBox closeBtn;
        private PictureBox minimizeBtn;
        private ListBox listBoxSongs;
        private Button btnSelectSongs;
        private Label lblFooter;
        private LinkLabel linkLabel;
        private LibVLCSharp.WinForms.VideoView vlcPlayer;
    }
}
