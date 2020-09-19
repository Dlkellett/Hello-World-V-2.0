namespace Hello_World_V_2._0
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
            this.helloButton1 = new System.Windows.Forms.Button();
            this.helloButton2 = new System.Windows.Forms.Button();
            this.helloButton3 = new System.Windows.Forms.Button();
            this.helloCheckBox1 = new System.Windows.Forms.CheckBox();
            this.helloWorldText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloButton1
            // 
            this.helloButton1.BackColor = System.Drawing.Color.Red;
            this.helloButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloButton1.Location = new System.Drawing.Point(301, 38);
            this.helloButton1.Name = "helloButton1";
            this.helloButton1.Size = new System.Drawing.Size(171, 108);
            this.helloButton1.TabIndex = 0;
            this.helloButton1.UseVisualStyleBackColor = false;
            this.helloButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // helloButton2
            // 
            this.helloButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.helloButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloButton2.ForeColor = System.Drawing.Color.Purple;
            this.helloButton2.Location = new System.Drawing.Point(510, 176);
            this.helloButton2.Name = "helloButton2";
            this.helloButton2.Size = new System.Drawing.Size(240, 223);
            this.helloButton2.TabIndex = 1;
            this.helloButton2.UseVisualStyleBackColor = false;
            this.helloButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // helloButton3
            // 
            this.helloButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.helloButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloButton3.ForeColor = System.Drawing.Color.Blue;
            this.helloButton3.Location = new System.Drawing.Point(12, 197);
            this.helloButton3.Name = "helloButton3";
            this.helloButton3.Size = new System.Drawing.Size(460, 78);
            this.helloButton3.TabIndex = 2;
            this.helloButton3.UseVisualStyleBackColor = false;
            this.helloButton3.Click += new System.EventHandler(this.button3_Click);
            // 
            // helloCheckBox1
            // 
            this.helloCheckBox1.AutoSize = true;
            this.helloCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloCheckBox1.Location = new System.Drawing.Point(510, 77);
            this.helloCheckBox1.Name = "helloCheckBox1";
            this.helloCheckBox1.Size = new System.Drawing.Size(233, 28);
            this.helloCheckBox1.TabIndex = 3;
            this.helloCheckBox1.Text = "Check me to say \"hello\".";
            this.helloCheckBox1.UseVisualStyleBackColor = true;
            this.helloCheckBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // helloWorldText
            // 
            this.helloWorldText.AutoSize = true;
            this.helloWorldText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.helloWorldText.Location = new System.Drawing.Point(84, 366);
            this.helloWorldText.Name = "helloWorldText";
            this.helloWorldText.Size = new System.Drawing.Size(0, 33);
            this.helloWorldText.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.helloWorldText);
            this.Controls.Add(this.helloCheckBox1);
            this.Controls.Add(this.helloButton3);
            this.Controls.Add(this.helloButton2);
            this.Controls.Add(this.helloButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button helloButton1;
        private System.Windows.Forms.Button helloButton2;
        private System.Windows.Forms.Button helloButton3;
        private System.Windows.Forms.CheckBox helloCheckBox1;
        private System.Windows.Forms.Label helloWorldText;
    }
}

