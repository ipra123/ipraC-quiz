namespace asegment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.femal = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.doorasho = new System.Windows.Forms.ListBox();
            this.submit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.femal);
            this.groupBox1.Controls.Add(this.male);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.age);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(270, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // femal
            // 
            this.femal.AutoSize = true;
            this.femal.Location = new System.Drawing.Point(196, 236);
            this.femal.Name = "femal";
            this.femal.Size = new System.Drawing.Size(74, 21);
            this.femal.TabIndex = 8;
            this.femal.TabStop = true;
            this.femal.Text = "FEMAL";
            this.femal.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(47, 236);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(66, 21);
            this.male.TabIndex = 7;
            this.male.TabStop = true;
            this.male.Text = "MALE";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "DA\'DA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "MAGACA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.Window;
            this.id.Location = new System.Drawing.Point(170, 109);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 22);
            this.id.TabIndex = 3;
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.SystemColors.Window;
            this.age.Location = new System.Drawing.Point(170, 173);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 22);
            this.age.TabIndex = 2;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.Window;
            this.name.Location = new System.Drawing.Point(170, 57);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT INFO";
            // 
            // doorasho
            // 
            this.doorasho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.doorasho.ForeColor = System.Drawing.Color.Black;
            this.doorasho.FormattingEnabled = true;
            this.doorasho.ItemHeight = 30;
            this.doorasho.Items.AddRange(new object[] {
            "C#",
            "C PROGRAMMING",
            "JAVA ",
            "JAVASCRIPT"});
            this.doorasho.Location = new System.Drawing.Point(270, 356);
            this.doorasho.Name = "doorasho";
            this.doorasho.Size = new System.Drawing.Size(273, 154);
            this.doorasho.TabIndex = 1;
            this.doorasho.SelectedIndexChanged += new System.EventHandler(this.course_SelectedIndexChanged);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(279, 528);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(124, 29);
            this.submit.TabIndex = 2;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(617, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(440, 528);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // info
            // 
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.info.Location = new System.Drawing.Point(276, 572);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(520, 131);
            this.info.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(679, 391);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "exitra";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::asegment.Properties.Resources.SEND;
            this.pictureBox1.Location = new System.Drawing.Point(426, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 731);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.doorasho);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton femal;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox doorasho;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

