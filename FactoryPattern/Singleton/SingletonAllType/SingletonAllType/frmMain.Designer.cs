namespace SingletonAllType
{
    partial class frmMain
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
            this.btn_Version_01 = new System.Windows.Forms.Button();
            this.btn_Version_02 = new System.Windows.Forms.Button();
            this.btn_Version_03 = new System.Windows.Forms.Button();
            this.btn_Version_04 = new System.Windows.Forms.Button();
            this.btn_Version_05 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Version_01
            // 
            this.btn_Version_01.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Version_01.BackColor = System.Drawing.Color.White;
            this.btn_Version_01.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Version_01.FlatAppearance.BorderSize = 3;
            this.btn_Version_01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Version_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Version_01.ForeColor = System.Drawing.Color.Green;
            this.btn_Version_01.Location = new System.Drawing.Point(28, 21);
            this.btn_Version_01.Name = "btn_Version_01";
            this.btn_Version_01.Size = new System.Drawing.Size(633, 92);
            this.btn_Version_01.TabIndex = 4;
            this.btn_Version_01.Text = "First version – not thread-safe";
            this.btn_Version_01.UseVisualStyleBackColor = false;
            this.btn_Version_01.Click += new System.EventHandler(this.btn_Version_01_Click);
            // 
            // btn_Version_02
            // 
            this.btn_Version_02.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Version_02.BackColor = System.Drawing.Color.White;
            this.btn_Version_02.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Version_02.FlatAppearance.BorderSize = 3;
            this.btn_Version_02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Version_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Version_02.ForeColor = System.Drawing.Color.Green;
            this.btn_Version_02.Location = new System.Drawing.Point(29, 126);
            this.btn_Version_02.Name = "btn_Version_02";
            this.btn_Version_02.Size = new System.Drawing.Size(633, 92);
            this.btn_Version_02.TabIndex = 5;
            this.btn_Version_02.Text = "Second version – simple thread safety";
            this.btn_Version_02.UseVisualStyleBackColor = false;
            this.btn_Version_02.Click += new System.EventHandler(this.btn_Version_02_Click);
            // 
            // btn_Version_03
            // 
            this.btn_Version_03.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Version_03.BackColor = System.Drawing.Color.White;
            this.btn_Version_03.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Version_03.FlatAppearance.BorderSize = 3;
            this.btn_Version_03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Version_03.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Version_03.ForeColor = System.Drawing.Color.Green;
            this.btn_Version_03.Location = new System.Drawing.Point(29, 231);
            this.btn_Version_03.Name = "btn_Version_03";
            this.btn_Version_03.Size = new System.Drawing.Size(633, 92);
            this.btn_Version_03.TabIndex = 6;
            this.btn_Version_03.Text = "Third version – attempted thread-safety using double-check locking";
            this.btn_Version_03.UseVisualStyleBackColor = false;
            this.btn_Version_03.Click += new System.EventHandler(this.btn_Version_03_Click);
            // 
            // btn_Version_04
            // 
            this.btn_Version_04.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Version_04.BackColor = System.Drawing.Color.White;
            this.btn_Version_04.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Version_04.FlatAppearance.BorderSize = 3;
            this.btn_Version_04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Version_04.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Version_04.ForeColor = System.Drawing.Color.Green;
            this.btn_Version_04.Location = new System.Drawing.Point(29, 336);
            this.btn_Version_04.Name = "btn_Version_04";
            this.btn_Version_04.Size = new System.Drawing.Size(633, 92);
            this.btn_Version_04.TabIndex = 7;
            this.btn_Version_04.Text = "Fourth version – not quite as lazy, but thread-safe without using locks";
            this.btn_Version_04.UseVisualStyleBackColor = false;
            this.btn_Version_04.Click += new System.EventHandler(this.btn_Version_04_Click);
            // 
            // btn_Version_05
            // 
            this.btn_Version_05.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Version_05.BackColor = System.Drawing.Color.White;
            this.btn_Version_05.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Version_05.FlatAppearance.BorderSize = 3;
            this.btn_Version_05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Version_05.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Version_05.ForeColor = System.Drawing.Color.Green;
            this.btn_Version_05.Location = new System.Drawing.Point(29, 441);
            this.btn_Version_05.Name = "btn_Version_05";
            this.btn_Version_05.Size = new System.Drawing.Size(633, 92);
            this.btn_Version_05.TabIndex = 8;
            this.btn_Version_05.Text = "Fifth version – fully lazy instantiation";
            this.btn_Version_05.UseVisualStyleBackColor = false;
            this.btn_Version_05.Click += new System.EventHandler(this.btn_Version_05_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(691, 554);
            this.Controls.Add(this.btn_Version_05);
            this.Controls.Add(this.btn_Version_04);
            this.Controls.Add(this.btn_Version_03);
            this.Controls.Add(this.btn_Version_02);
            this.Controls.Add(this.btn_Version_01);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Singleton Pattern";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Version_01;
        private System.Windows.Forms.Button btn_Version_02;
        private System.Windows.Forms.Button btn_Version_03;
        private System.Windows.Forms.Button btn_Version_04;
        private System.Windows.Forms.Button btn_Version_05;
    }
}

