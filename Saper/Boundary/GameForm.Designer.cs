namespace Saper.Boundary
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьУровеньСложностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаРекордовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bombsLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bombPicture = new System.Windows.Forms.PictureBox();
            this.timerPicture = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bombPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.выбратьУровеньСложностиToolStripMenuItem,
            this.таблицаРекордовToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("новаяИграToolStripMenuItem.Image")));
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.новаяИграToolStripMenuItem_Click);
            // 
            // выбратьУровеньСложностиToolStripMenuItem
            // 
            this.выбратьУровеньСложностиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выбратьУровеньСложностиToolStripMenuItem.Image")));
            this.выбратьУровеньСложностиToolStripMenuItem.Name = "выбратьУровеньСложностиToolStripMenuItem";
            this.выбратьУровеньСложностиToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.выбратьУровеньСложностиToolStripMenuItem.Text = "Сложность";
            this.выбратьУровеньСложностиToolStripMenuItem.Click += new System.EventHandler(this.выбратьУровеньСложностиToolStripMenuItem_Click);
            // 
            // таблицаРекордовToolStripMenuItem
            // 
            this.таблицаРекордовToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("таблицаРекордовToolStripMenuItem.Image")));
            this.таблицаРекордовToolStripMenuItem.Name = "таблицаРекордовToolStripMenuItem";
            this.таблицаРекордовToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.таблицаРекордовToolStripMenuItem.Text = "Таблица рекордов";
            this.таблицаРекордовToolStripMenuItem.Click += new System.EventHandler(this.таблицаРекордовToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выйтиToolStripMenuItem.Image")));
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 330;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Время:";
            // 
            // bombsLabel
            // 
            this.bombsLabel.AutoSize = true;
            this.bombsLabel.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bombsLabel.Location = new System.Drawing.Point(150, 27);
            this.bombsLabel.Name = "bombsLabel";
            this.bombsLabel.Size = new System.Drawing.Size(61, 27);
            this.bombsLabel.TabIndex = 2;
            this.bombsLabel.Text = "Бомб:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "editbomb.png");
            // 
            // bombPicture
            // 
            this.bombPicture.Image = ((System.Drawing.Image)(resources.GetObject("bombPicture.Image")));
            this.bombPicture.Location = new System.Drawing.Point(124, 30);
            this.bombPicture.Name = "bombPicture";
            this.bombPicture.Size = new System.Drawing.Size(20, 20);
            this.bombPicture.TabIndex = 3;
            this.bombPicture.TabStop = false;
            // 
            // timerPicture
            // 
            this.timerPicture.Image = ((System.Drawing.Image)(resources.GetObject("timerPicture.Image")));
            this.timerPicture.Location = new System.Drawing.Point(12, 30);
            this.timerPicture.Name = "timerPicture";
            this.timerPicture.Size = new System.Drawing.Size(20, 20);
            this.timerPicture.TabIndex = 4;
            this.timerPicture.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.timerPicture);
            this.Controls.Add(this.bombPicture);
            this.Controls.Add(this.bombsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сапер";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bombPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьУровеньСложностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаРекордовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bombsLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox bombPicture;
        private System.Windows.Forms.PictureBox timerPicture;
    }
}

