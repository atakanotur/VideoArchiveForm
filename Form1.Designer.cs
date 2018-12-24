namespace VideoArchiveForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.categories = new System.Windows.Forms.ComboBox();
            this.films = new System.Windows.Forms.ComboBox();
            this.playbt = new System.Windows.Forms.Button();
            this.pausebt = new System.Windows.Forms.Button();
            this.stopbt = new System.Windows.Forms.Button();
            this.exitbt = new System.Windows.Forms.Button();
            this.addbt = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // categories
            // 
            this.categories.FormattingEnabled = true;
            this.categories.Items.AddRange(new object[] {
            "Action",
            "Comedy",
            "Horror",
            "Romantic"});
            this.categories.Location = new System.Drawing.Point(56, 45);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(154, 33);
            this.categories.TabIndex = 0;
            this.categories.SelectedIndexChanged += new System.EventHandler(this.categories_SelectedIndexChanged);
            // 
            // films
            // 
            this.films.FormattingEnabled = true;
            this.films.Location = new System.Drawing.Point(274, 45);
            this.films.Name = "films";
            this.films.Size = new System.Drawing.Size(154, 33);
            this.films.TabIndex = 1;
            this.films.SelectedIndexChanged += new System.EventHandler(this.films_SelectedIndexChanged);
            // 
            // playbt
            // 
            this.playbt.Location = new System.Drawing.Point(700, 13);
            this.playbt.Name = "playbt";
            this.playbt.Size = new System.Drawing.Size(148, 80);
            this.playbt.TabIndex = 4;
            this.playbt.Text = "Play";
            this.playbt.UseVisualStyleBackColor = true;
            this.playbt.Click += new System.EventHandler(this.playbt_Click);
            // 
            // pausebt
            // 
            this.pausebt.Location = new System.Drawing.Point(700, 110);
            this.pausebt.Name = "pausebt";
            this.pausebt.Size = new System.Drawing.Size(148, 80);
            this.pausebt.TabIndex = 5;
            this.pausebt.Text = "Pause";
            this.pausebt.UseVisualStyleBackColor = true;
            this.pausebt.Click += new System.EventHandler(this.pausebt_Click);
            // 
            // stopbt
            // 
            this.stopbt.Location = new System.Drawing.Point(700, 209);
            this.stopbt.Name = "stopbt";
            this.stopbt.Size = new System.Drawing.Size(148, 80);
            this.stopbt.TabIndex = 6;
            this.stopbt.Text = "Stop";
            this.stopbt.UseVisualStyleBackColor = true;
            this.stopbt.Click += new System.EventHandler(this.stopbt_Click);
            // 
            // exitbt
            // 
            this.exitbt.Location = new System.Drawing.Point(700, 353);
            this.exitbt.Name = "exitbt";
            this.exitbt.Size = new System.Drawing.Size(148, 116);
            this.exitbt.TabIndex = 7;
            this.exitbt.Text = "Exit";
            this.exitbt.UseVisualStyleBackColor = true;
            this.exitbt.Click += new System.EventHandler(this.exitbt_Click);
            // 
            // addbt
            // 
            this.addbt.Location = new System.Drawing.Point(502, 13);
            this.addbt.Name = "addbt";
            this.addbt.Size = new System.Drawing.Size(168, 65);
            this.addbt.TabIndex = 8;
            this.addbt.Text = "Add Film";
            this.addbt.UseVisualStyleBackColor = true;
            this.addbt.Click += new System.EventHandler(this.addbt_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 84);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(658, 385);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Films";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addbt);
            this.Controls.Add(this.exitbt);
            this.Controls.Add(this.stopbt);
            this.Controls.Add(this.pausebt);
            this.Controls.Add(this.playbt);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.films);
            this.Controls.Add(this.categories);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Video Archive";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categories;
        private System.Windows.Forms.ComboBox films;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button playbt;
        private System.Windows.Forms.Button pausebt;
        private System.Windows.Forms.Button stopbt;
        private System.Windows.Forms.Button exitbt;
        private System.Windows.Forms.Button addbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

