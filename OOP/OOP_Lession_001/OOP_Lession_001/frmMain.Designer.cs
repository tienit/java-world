namespace OOP_Lession_001
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
            this.btn_Dogs = new System.Windows.Forms.Button();
            this.btn_Cats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Dogs
            // 
            this.btn_Dogs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Dogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dogs.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btn_Dogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Dogs.Location = new System.Drawing.Point(28, 29);
            this.btn_Dogs.Name = "btn_Dogs";
            this.btn_Dogs.Size = new System.Drawing.Size(377, 82);
            this.btn_Dogs.TabIndex = 0;
            this.btn_Dogs.Text = "Dogs";
            this.btn_Dogs.UseVisualStyleBackColor = true;
            // 
            // btn_Cats
            // 
            this.btn_Cats.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Cats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cats.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btn_Cats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Cats.Location = new System.Drawing.Point(489, 29);
            this.btn_Cats.Name = "btn_Cats";
            this.btn_Cats.Size = new System.Drawing.Size(377, 82);
            this.btn_Cats.TabIndex = 1;
            this.btn_Cats.Text = "Cats";
            this.btn_Cats.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 463);
            this.Controls.Add(this.btn_Cats);
            this.Controls.Add(this.btn_Dogs);
            this.Name = "frmMain";
            this.Text = "OOP - Object Oriented Programming";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Dogs;
        private System.Windows.Forms.Button btn_Cats;
    }
}

