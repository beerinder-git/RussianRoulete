namespace RussianRoulete
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
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SpinBtn = new System.Windows.Forms.Button();
            this.ShootBtn = new System.Windows.Forms.Button();
            this.ShAwayBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(625, 63);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(99, 54);
            this.LoadBtn.TabIndex = 0;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // SpinBtn
            // 
            this.SpinBtn.Location = new System.Drawing.Point(625, 160);
            this.SpinBtn.Name = "SpinBtn";
            this.SpinBtn.Size = new System.Drawing.Size(99, 54);
            this.SpinBtn.TabIndex = 1;
            this.SpinBtn.Text = "Spin";
            this.SpinBtn.UseVisualStyleBackColor = true;
            this.SpinBtn.Click += new System.EventHandler(this.SpinBtn_Click);
            // 
            // ShootBtn
            // 
            this.ShootBtn.Location = new System.Drawing.Point(625, 259);
            this.ShootBtn.Name = "ShootBtn";
            this.ShootBtn.Size = new System.Drawing.Size(99, 54);
            this.ShootBtn.TabIndex = 2;
            this.ShootBtn.Text = "Shoot";
            this.ShootBtn.UseVisualStyleBackColor = true;
            this.ShootBtn.Click += new System.EventHandler(this.ShootBtn_Click);
            // 
            // ShAwayBtn
            // 
            this.ShAwayBtn.Location = new System.Drawing.Point(625, 360);
            this.ShAwayBtn.Name = "ShAwayBtn";
            this.ShAwayBtn.Size = new System.Drawing.Size(99, 54);
            this.ShAwayBtn.TabIndex = 3;
            this.ShAwayBtn.Text = "Shoot Away";
            this.ShAwayBtn.UseVisualStyleBackColor = true;
            this.ShAwayBtn.Click += new System.EventHandler(this.ShAwayBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShAwayBtn);
            this.Controls.Add(this.ShootBtn);
            this.Controls.Add(this.SpinBtn);
            this.Controls.Add(this.LoadBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button SpinBtn;
        private System.Windows.Forms.Button ShootBtn;
        private System.Windows.Forms.Button ShAwayBtn;
    }
}

