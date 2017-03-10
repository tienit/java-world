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
            this.btn_Birds = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_Dogs_Inheritance = new System.Windows.Forms.RichTextBox();
            this.rtb_Cats_Inheritance = new System.Windows.Forms.RichTextBox();
            this.rtb_Birds_Inheritance = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Dogs_Runnable = new System.Windows.Forms.TextBox();
            this.txt_Cats_Runnable = new System.Windows.Forms.TextBox();
            this.txt_Birds_Runnable = new System.Windows.Forms.TextBox();
            this.txt_Birds_Flyable = new System.Windows.Forms.TextBox();
            this.txt_Cats_Flyable = new System.Windows.Forms.TextBox();
            this.txt_Dogs_Flyable = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Birds_Climbable = new System.Windows.Forms.TextBox();
            this.txt_Cats_Climbable = new System.Windows.Forms.TextBox();
            this.txt_Dogs_Climbable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Birds_Eatable = new System.Windows.Forms.TextBox();
            this.txt_Cats_Eatable = new System.Windows.Forms.TextBox();
            this.txt_Dogs_Eatable = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtb_Plane_Inheritance = new System.Windows.Forms.RichTextBox();
            this.btn_Plane = new System.Windows.Forms.Button();
            this.txt_Plane_Eatable = new System.Windows.Forms.TextBox();
            this.txt_Plane_Climbable = new System.Windows.Forms.TextBox();
            this.txt_Plane_Flyable = new System.Windows.Forms.TextBox();
            this.txt_Plane_Runnable = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Dogs
            // 
            this.btn_Dogs.BackColor = System.Drawing.Color.Silver;
            this.btn_Dogs.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Dogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dogs.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btn_Dogs.ForeColor = System.Drawing.Color.Red;
            this.btn_Dogs.Location = new System.Drawing.Point(198, 12);
            this.btn_Dogs.Name = "btn_Dogs";
            this.btn_Dogs.Size = new System.Drawing.Size(232, 82);
            this.btn_Dogs.TabIndex = 0;
            this.btn_Dogs.Text = "Dogs";
            this.btn_Dogs.UseVisualStyleBackColor = false;
            this.btn_Dogs.Click += new System.EventHandler(this.btn_Dogs_Click);
            // 
            // btn_Cats
            // 
            this.btn_Cats.BackColor = System.Drawing.Color.Silver;
            this.btn_Cats.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Cats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cats.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btn_Cats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Cats.Location = new System.Drawing.Point(436, 12);
            this.btn_Cats.Name = "btn_Cats";
            this.btn_Cats.Size = new System.Drawing.Size(232, 82);
            this.btn_Cats.TabIndex = 1;
            this.btn_Cats.Text = "Cats";
            this.btn_Cats.UseVisualStyleBackColor = false;
            this.btn_Cats.Click += new System.EventHandler(this.btn_Cats_Click);
            // 
            // btn_Birds
            // 
            this.btn_Birds.BackColor = System.Drawing.Color.Silver;
            this.btn_Birds.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Birds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Birds.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btn_Birds.ForeColor = System.Drawing.Color.Green;
            this.btn_Birds.Location = new System.Drawing.Point(674, 12);
            this.btn_Birds.Name = "btn_Birds";
            this.btn_Birds.Size = new System.Drawing.Size(232, 82);
            this.btn_Birds.TabIndex = 2;
            this.btn_Birds.Text = "Birds";
            this.btn_Birds.UseVisualStyleBackColor = false;
            this.btn_Birds.Click += new System.EventHandler(this.btn_Birds_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(18, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inheritance (Is-a)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtb_Dogs_Inheritance
            // 
            this.rtb_Dogs_Inheritance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Dogs_Inheritance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtb_Dogs_Inheritance.ForeColor = System.Drawing.Color.Red;
            this.rtb_Dogs_Inheritance.Location = new System.Drawing.Point(198, 202);
            this.rtb_Dogs_Inheritance.Name = "rtb_Dogs_Inheritance";
            this.rtb_Dogs_Inheritance.ReadOnly = true;
            this.rtb_Dogs_Inheritance.Size = new System.Drawing.Size(232, 185);
            this.rtb_Dogs_Inheritance.TabIndex = 4;
            this.rtb_Dogs_Inheritance.Text = "";
            // 
            // rtb_Cats_Inheritance
            // 
            this.rtb_Cats_Inheritance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Cats_Inheritance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtb_Cats_Inheritance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rtb_Cats_Inheritance.Location = new System.Drawing.Point(436, 202);
            this.rtb_Cats_Inheritance.Name = "rtb_Cats_Inheritance";
            this.rtb_Cats_Inheritance.ReadOnly = true;
            this.rtb_Cats_Inheritance.Size = new System.Drawing.Size(232, 185);
            this.rtb_Cats_Inheritance.TabIndex = 5;
            this.rtb_Cats_Inheritance.Text = "";
            // 
            // rtb_Birds_Inheritance
            // 
            this.rtb_Birds_Inheritance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Birds_Inheritance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtb_Birds_Inheritance.ForeColor = System.Drawing.Color.Green;
            this.rtb_Birds_Inheritance.Location = new System.Drawing.Point(674, 202);
            this.rtb_Birds_Inheritance.Name = "rtb_Birds_Inheritance";
            this.rtb_Birds_Inheritance.ReadOnly = true;
            this.rtb_Birds_Inheritance.Size = new System.Drawing.Size(232, 185);
            this.rtb_Birds_Inheritance.TabIndex = 6;
            this.rtb_Birds_Inheritance.Text = "";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(17, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "IRunnable";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Dogs_Runnable
            // 
            this.txt_Dogs_Runnable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Dogs_Runnable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Dogs_Runnable.ForeColor = System.Drawing.Color.Red;
            this.txt_Dogs_Runnable.Location = new System.Drawing.Point(198, 453);
            this.txt_Dogs_Runnable.Multiline = true;
            this.txt_Dogs_Runnable.Name = "txt_Dogs_Runnable";
            this.txt_Dogs_Runnable.Size = new System.Drawing.Size(232, 54);
            this.txt_Dogs_Runnable.TabIndex = 8;
            // 
            // txt_Cats_Runnable
            // 
            this.txt_Cats_Runnable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Cats_Runnable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Cats_Runnable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_Cats_Runnable.Location = new System.Drawing.Point(436, 453);
            this.txt_Cats_Runnable.Multiline = true;
            this.txt_Cats_Runnable.Name = "txt_Cats_Runnable";
            this.txt_Cats_Runnable.Size = new System.Drawing.Size(232, 54);
            this.txt_Cats_Runnable.TabIndex = 9;
            // 
            // txt_Birds_Runnable
            // 
            this.txt_Birds_Runnable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Birds_Runnable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Birds_Runnable.ForeColor = System.Drawing.Color.Green;
            this.txt_Birds_Runnable.Location = new System.Drawing.Point(674, 453);
            this.txt_Birds_Runnable.Multiline = true;
            this.txt_Birds_Runnable.Name = "txt_Birds_Runnable";
            this.txt_Birds_Runnable.Size = new System.Drawing.Size(232, 54);
            this.txt_Birds_Runnable.TabIndex = 10;
            // 
            // txt_Birds_Flyable
            // 
            this.txt_Birds_Flyable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Birds_Flyable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Birds_Flyable.ForeColor = System.Drawing.Color.Green;
            this.txt_Birds_Flyable.Location = new System.Drawing.Point(674, 520);
            this.txt_Birds_Flyable.Multiline = true;
            this.txt_Birds_Flyable.Name = "txt_Birds_Flyable";
            this.txt_Birds_Flyable.Size = new System.Drawing.Size(232, 54);
            this.txt_Birds_Flyable.TabIndex = 14;
            // 
            // txt_Cats_Flyable
            // 
            this.txt_Cats_Flyable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Cats_Flyable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Cats_Flyable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_Cats_Flyable.Location = new System.Drawing.Point(436, 520);
            this.txt_Cats_Flyable.Multiline = true;
            this.txt_Cats_Flyable.Name = "txt_Cats_Flyable";
            this.txt_Cats_Flyable.Size = new System.Drawing.Size(232, 54);
            this.txt_Cats_Flyable.TabIndex = 13;
            // 
            // txt_Dogs_Flyable
            // 
            this.txt_Dogs_Flyable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Dogs_Flyable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Dogs_Flyable.ForeColor = System.Drawing.Color.Red;
            this.txt_Dogs_Flyable.Location = new System.Drawing.Point(198, 520);
            this.txt_Dogs_Flyable.Multiline = true;
            this.txt_Dogs_Flyable.Name = "txt_Dogs_Flyable";
            this.txt_Dogs_Flyable.Size = new System.Drawing.Size(232, 54);
            this.txt_Dogs_Flyable.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.Location = new System.Drawing.Point(17, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "IFlyable";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Birds_Climbable
            // 
            this.txt_Birds_Climbable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Birds_Climbable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Birds_Climbable.ForeColor = System.Drawing.Color.Green;
            this.txt_Birds_Climbable.Location = new System.Drawing.Point(674, 587);
            this.txt_Birds_Climbable.Multiline = true;
            this.txt_Birds_Climbable.Name = "txt_Birds_Climbable";
            this.txt_Birds_Climbable.Size = new System.Drawing.Size(232, 54);
            this.txt_Birds_Climbable.TabIndex = 18;
            // 
            // txt_Cats_Climbable
            // 
            this.txt_Cats_Climbable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Cats_Climbable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Cats_Climbable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_Cats_Climbable.Location = new System.Drawing.Point(436, 587);
            this.txt_Cats_Climbable.Multiline = true;
            this.txt_Cats_Climbable.Name = "txt_Cats_Climbable";
            this.txt_Cats_Climbable.Size = new System.Drawing.Size(232, 54);
            this.txt_Cats_Climbable.TabIndex = 17;
            // 
            // txt_Dogs_Climbable
            // 
            this.txt_Dogs_Climbable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Dogs_Climbable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Dogs_Climbable.ForeColor = System.Drawing.Color.Red;
            this.txt_Dogs_Climbable.Location = new System.Drawing.Point(198, 587);
            this.txt_Dogs_Climbable.Multiline = true;
            this.txt_Dogs_Climbable.Name = "txt_Dogs_Climbable";
            this.txt_Dogs_Climbable.Size = new System.Drawing.Size(232, 54);
            this.txt_Dogs_Climbable.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.Location = new System.Drawing.Point(17, 596);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "IClimbable";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Birds_Eatable
            // 
            this.txt_Birds_Eatable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Birds_Eatable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Birds_Eatable.ForeColor = System.Drawing.Color.Green;
            this.txt_Birds_Eatable.Location = new System.Drawing.Point(675, 654);
            this.txt_Birds_Eatable.Multiline = true;
            this.txt_Birds_Eatable.Name = "txt_Birds_Eatable";
            this.txt_Birds_Eatable.Size = new System.Drawing.Size(232, 54);
            this.txt_Birds_Eatable.TabIndex = 22;
            // 
            // txt_Cats_Eatable
            // 
            this.txt_Cats_Eatable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Cats_Eatable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Cats_Eatable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_Cats_Eatable.Location = new System.Drawing.Point(437, 654);
            this.txt_Cats_Eatable.Multiline = true;
            this.txt_Cats_Eatable.Name = "txt_Cats_Eatable";
            this.txt_Cats_Eatable.Size = new System.Drawing.Size(232, 54);
            this.txt_Cats_Eatable.TabIndex = 21;
            // 
            // txt_Dogs_Eatable
            // 
            this.txt_Dogs_Eatable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Dogs_Eatable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Dogs_Eatable.ForeColor = System.Drawing.Color.Red;
            this.txt_Dogs_Eatable.Location = new System.Drawing.Point(199, 654);
            this.txt_Dogs_Eatable.Multiline = true;
            this.txt_Dogs_Eatable.Name = "txt_Dogs_Eatable";
            this.txt_Dogs_Eatable.Size = new System.Drawing.Size(232, 54);
            this.txt_Dogs_Eatable.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label5.Location = new System.Drawing.Point(22, 661);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "IEatable";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Aqua;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label6.Location = new System.Drawing.Point(18, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(472, 30);
            this.label6.TabIndex = 23;
            this.label6.Text = "Implement (Can-do)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label7.Location = new System.Drawing.Point(194, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 30);
            this.label7.TabIndex = 24;
            this.label7.Text = "AbstractAnimal";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtb_Plane_Inheritance
            // 
            this.rtb_Plane_Inheritance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Plane_Inheritance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Plane_Inheritance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtb_Plane_Inheritance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rtb_Plane_Inheritance.Location = new System.Drawing.Point(942, 202);
            this.rtb_Plane_Inheritance.Name = "rtb_Plane_Inheritance";
            this.rtb_Plane_Inheritance.ReadOnly = true;
            this.rtb_Plane_Inheritance.Size = new System.Drawing.Size(232, 185);
            this.rtb_Plane_Inheritance.TabIndex = 25;
            this.rtb_Plane_Inheritance.Text = "";
            // 
            // btn_Plane
            // 
            this.btn_Plane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Plane.BackColor = System.Drawing.Color.Silver;
            this.btn_Plane.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Plane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Plane.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btn_Plane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Plane.Location = new System.Drawing.Point(942, 12);
            this.btn_Plane.Name = "btn_Plane";
            this.btn_Plane.Size = new System.Drawing.Size(232, 82);
            this.btn_Plane.TabIndex = 26;
            this.btn_Plane.Text = "Plane";
            this.btn_Plane.UseVisualStyleBackColor = false;
            this.btn_Plane.Click += new System.EventHandler(this.btn_Plane_Click);
            // 
            // txt_Plane_Eatable
            // 
            this.txt_Plane_Eatable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Plane_Eatable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Plane_Eatable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Plane_Eatable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_Plane_Eatable.Location = new System.Drawing.Point(943, 654);
            this.txt_Plane_Eatable.Multiline = true;
            this.txt_Plane_Eatable.Name = "txt_Plane_Eatable";
            this.txt_Plane_Eatable.Size = new System.Drawing.Size(232, 54);
            this.txt_Plane_Eatable.TabIndex = 30;
            // 
            // txt_Plane_Climbable
            // 
            this.txt_Plane_Climbable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Plane_Climbable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Plane_Climbable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Plane_Climbable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_Plane_Climbable.Location = new System.Drawing.Point(942, 587);
            this.txt_Plane_Climbable.Multiline = true;
            this.txt_Plane_Climbable.Name = "txt_Plane_Climbable";
            this.txt_Plane_Climbable.Size = new System.Drawing.Size(232, 54);
            this.txt_Plane_Climbable.TabIndex = 29;
            // 
            // txt_Plane_Flyable
            // 
            this.txt_Plane_Flyable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Plane_Flyable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Plane_Flyable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Plane_Flyable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_Plane_Flyable.Location = new System.Drawing.Point(942, 520);
            this.txt_Plane_Flyable.Multiline = true;
            this.txt_Plane_Flyable.Name = "txt_Plane_Flyable";
            this.txt_Plane_Flyable.Size = new System.Drawing.Size(232, 54);
            this.txt_Plane_Flyable.TabIndex = 28;
            // 
            // txt_Plane_Runnable
            // 
            this.txt_Plane_Runnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Plane_Runnable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Plane_Runnable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Plane_Runnable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_Plane_Runnable.Location = new System.Drawing.Point(942, 453);
            this.txt_Plane_Runnable.Multiline = true;
            this.txt_Plane_Runnable.Name = "txt_Plane_Runnable";
            this.txt_Plane_Runnable.Size = new System.Drawing.Size(232, 54);
            this.txt_Plane_Runnable.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label8.Location = new System.Drawing.Point(937, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 30);
            this.label8.TabIndex = 31;
            this.label8.Text = "AbstractVehicle";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1186, 718);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Plane_Eatable);
            this.Controls.Add(this.txt_Plane_Climbable);
            this.Controls.Add(this.txt_Plane_Flyable);
            this.Controls.Add(this.txt_Plane_Runnable);
            this.Controls.Add(this.btn_Plane);
            this.Controls.Add(this.rtb_Plane_Inheritance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Birds_Eatable);
            this.Controls.Add(this.txt_Cats_Eatable);
            this.Controls.Add(this.txt_Dogs_Eatable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Birds_Climbable);
            this.Controls.Add(this.txt_Cats_Climbable);
            this.Controls.Add(this.txt_Dogs_Climbable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Birds_Flyable);
            this.Controls.Add(this.txt_Cats_Flyable);
            this.Controls.Add(this.txt_Dogs_Flyable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Birds_Runnable);
            this.Controls.Add(this.txt_Cats_Runnable);
            this.Controls.Add(this.txt_Dogs_Runnable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtb_Birds_Inheritance);
            this.Controls.Add(this.rtb_Cats_Inheritance);
            this.Controls.Add(this.rtb_Dogs_Inheritance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Birds);
            this.Controls.Add(this.btn_Cats);
            this.Controls.Add(this.btn_Dogs);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OOP - Object Oriented Programming";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Dogs;
        private System.Windows.Forms.Button btn_Cats;
        private System.Windows.Forms.Button btn_Birds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_Dogs_Inheritance;
        private System.Windows.Forms.RichTextBox rtb_Cats_Inheritance;
        private System.Windows.Forms.RichTextBox rtb_Birds_Inheritance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Dogs_Runnable;
        private System.Windows.Forms.TextBox txt_Cats_Runnable;
        private System.Windows.Forms.TextBox txt_Birds_Runnable;
        private System.Windows.Forms.TextBox txt_Birds_Flyable;
        private System.Windows.Forms.TextBox txt_Cats_Flyable;
        private System.Windows.Forms.TextBox txt_Dogs_Flyable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Birds_Climbable;
        private System.Windows.Forms.TextBox txt_Cats_Climbable;
        private System.Windows.Forms.TextBox txt_Dogs_Climbable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Birds_Eatable;
        private System.Windows.Forms.TextBox txt_Cats_Eatable;
        private System.Windows.Forms.TextBox txt_Dogs_Eatable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtb_Plane_Inheritance;
        private System.Windows.Forms.Button btn_Plane;
        private System.Windows.Forms.TextBox txt_Plane_Eatable;
        private System.Windows.Forms.TextBox txt_Plane_Climbable;
        private System.Windows.Forms.TextBox txt_Plane_Flyable;
        private System.Windows.Forms.TextBox txt_Plane_Runnable;
        private System.Windows.Forms.Label label8;
    }
}

