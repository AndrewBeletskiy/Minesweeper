namespace Saper.Boundary
{
    partial class RecordTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordTableForm));
            this.labelEasy = new System.Windows.Forms.Label();
            this.labelMedium = new System.Windows.Forms.Label();
            this.labelProfessional = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEasy
            // 
            this.labelEasy.AutoSize = true;
            this.labelEasy.Location = new System.Drawing.Point(12, 9);
            this.labelEasy.Name = "labelEasy";
            this.labelEasy.Size = new System.Drawing.Size(44, 13);
            this.labelEasy.TabIndex = 0;
            this.labelEasy.Text = "Легкий";
            // 
            // labelMedium
            // 
            this.labelMedium.AutoSize = true;
            this.labelMedium.Location = new System.Drawing.Point(12, 35);
            this.labelMedium.Name = "labelMedium";
            this.labelMedium.Size = new System.Drawing.Size(50, 13);
            this.labelMedium.TabIndex = 1;
            this.labelMedium.Text = "Средний";
            // 
            // labelProfessional
            // 
            this.labelProfessional.AutoSize = true;
            this.labelProfessional.Location = new System.Drawing.Point(12, 67);
            this.labelProfessional.Name = "labelProfessional";
            this.labelProfessional.Size = new System.Drawing.Size(54, 13);
            this.labelProfessional.TabIndex = 2;
            this.labelProfessional.Text = "Тяжелый";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Обнулить рекорды";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RecordTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(191, 135);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelProfessional);
            this.Controls.Add(this.labelMedium);
            this.Controls.Add(this.labelEasy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecordTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Рекорды";
            this.Load += new System.EventHandler(this.RecordTableForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEasy;
        private System.Windows.Forms.Label labelMedium;
        private System.Windows.Forms.Label labelProfessional;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}