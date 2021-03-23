namespace WindowsFormsApp2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.darts5 = new System.Windows.Forms.PictureBox();
            this.darts4 = new System.Windows.Forms.PictureBox();
            this.darts3 = new System.Windows.Forms.PictureBox();
            this.darts2 = new System.Windows.Forms.PictureBox();
            this.darts1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.darts5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darts4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darts3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darts2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darts1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Удачи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(586, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Счет: 0";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Rockwell Nova Cond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(590, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Меню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell Nova Cond", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Кликните по мишени";
            // 
            // darts5
            // 
            this.darts5.Image = global::WindowsFormsApp2.Properties.Resources.dartsj;
            this.darts5.Location = new System.Drawing.Point(666, 101);
            this.darts5.Name = "darts5";
            this.darts5.Size = new System.Drawing.Size(15, 33);
            this.darts5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.darts5.TabIndex = 16;
            this.darts5.TabStop = false;
            // 
            // darts4
            // 
            this.darts4.Image = global::WindowsFormsApp2.Properties.Resources.dartsj;
            this.darts4.Location = new System.Drawing.Point(645, 101);
            this.darts4.Name = "darts4";
            this.darts4.Size = new System.Drawing.Size(15, 33);
            this.darts4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.darts4.TabIndex = 15;
            this.darts4.TabStop = false;
            // 
            // darts3
            // 
            this.darts3.Image = global::WindowsFormsApp2.Properties.Resources.dartsj;
            this.darts3.Location = new System.Drawing.Point(624, 101);
            this.darts3.Name = "darts3";
            this.darts3.Size = new System.Drawing.Size(15, 33);
            this.darts3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.darts3.TabIndex = 14;
            this.darts3.TabStop = false;
            // 
            // darts2
            // 
            this.darts2.Image = global::WindowsFormsApp2.Properties.Resources.dartsj;
            this.darts2.Location = new System.Drawing.Point(604, 101);
            this.darts2.Name = "darts2";
            this.darts2.Size = new System.Drawing.Size(14, 33);
            this.darts2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.darts2.TabIndex = 13;
            this.darts2.TabStop = false;
            // 
            // darts1
            // 
            this.darts1.Image = global::WindowsFormsApp2.Properties.Resources.dartsj;
            this.darts1.Location = new System.Drawing.Point(583, 101);
            this.darts1.Name = "darts1";
            this.darts1.Size = new System.Drawing.Size(15, 33);
            this.darts1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.darts1.TabIndex = 12;
            this.darts1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp2.Properties.Resources.left;
            this.pictureBox3.Location = new System.Drawing.Point(77, 434);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.down;
            this.pictureBox2.Location = new System.Drawing.Point(135, 469);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(150, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell Nova Cond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(589, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Заново";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.darts5);
            this.Controls.Add(this.darts4);
            this.Controls.Add(this.darts3);
            this.Controls.Add(this.darts2);
            this.Controls.Add(this.darts1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Игра";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.darts5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darts4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darts3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darts2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darts1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox darts1;
        private System.Windows.Forms.PictureBox darts2;
        private System.Windows.Forms.PictureBox darts3;
        private System.Windows.Forms.PictureBox darts4;
        private System.Windows.Forms.PictureBox darts5;
        private System.Windows.Forms.Button button1;
    }
}