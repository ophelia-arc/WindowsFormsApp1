namespace WindowsFormsApp1
{
    partial class Form4
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
            this.lblsual = new System.Windows.Forms.Label();
            this.grbvariantlar = new System.Windows.Forms.GroupBox();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.btnkec = new System.Windows.Forms.Button();
            this.prgbar = new System.Windows.Forms.ProgressBar();
            this.grbvariantlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsual
            // 
            this.lblsual.AutoSize = true;
            this.lblsual.Location = new System.Drawing.Point(12, 24);
            this.lblsual.Name = "lblsual";
            this.lblsual.Size = new System.Drawing.Size(35, 13);
            this.lblsual.TabIndex = 0;
            this.lblsual.Text = "label1";
            // 
            // grbvariantlar
            // 
            this.grbvariantlar.Controls.Add(this.rdbD);
            this.grbvariantlar.Controls.Add(this.rdbC);
            this.grbvariantlar.Controls.Add(this.rdbB);
            this.grbvariantlar.Controls.Add(this.rdbA);
            this.grbvariantlar.Location = new System.Drawing.Point(15, 47);
            this.grbvariantlar.Name = "grbvariantlar";
            this.grbvariantlar.Size = new System.Drawing.Size(200, 111);
            this.grbvariantlar.TabIndex = 1;
            this.grbvariantlar.TabStop = false;
            this.grbvariantlar.Text = "Cavab variantlari";
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Location = new System.Drawing.Point(6, 88);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(85, 17);
            this.rdbD.TabIndex = 5;
            this.rdbD.TabStop = true;
            this.rdbD.Text = "radioButton4";
            this.rdbD.UseVisualStyleBackColor = true;
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Location = new System.Drawing.Point(6, 65);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(85, 17);
            this.rdbC.TabIndex = 4;
            this.rdbC.TabStop = true;
            this.rdbC.Text = "radioButton3";
            this.rdbC.UseVisualStyleBackColor = true;
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Location = new System.Drawing.Point(6, 42);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(85, 17);
            this.rdbB.TabIndex = 3;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "radioButton2";
            this.rdbB.UseVisualStyleBackColor = true;
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Location = new System.Drawing.Point(6, 19);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(85, 17);
            this.rdbA.TabIndex = 2;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "radioButton1";
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // btnkec
            // 
            this.btnkec.Location = new System.Drawing.Point(15, 193);
            this.btnkec.Name = "btnkec";
            this.btnkec.Size = new System.Drawing.Size(75, 23);
            this.btnkec.TabIndex = 2;
            this.btnkec.Text = "Novbeti";
            this.btnkec.UseVisualStyleBackColor = true;
            this.btnkec.Click += new System.EventHandler(this.btnkec_Click);
            // 
            // prgbar
            // 
            this.prgbar.Location = new System.Drawing.Point(15, 164);
            this.prgbar.Name = "prgbar";
            this.prgbar.Size = new System.Drawing.Size(200, 23);
            this.prgbar.TabIndex = 3;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prgbar);
            this.Controls.Add(this.btnkec);
            this.Controls.Add(this.grbvariantlar);
            this.Controls.Add(this.lblsual);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.grbvariantlar.ResumeLayout(false);
            this.grbvariantlar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsual;
        private System.Windows.Forms.GroupBox grbvariantlar;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.RadioButton rdbD;
        private System.Windows.Forms.RadioButton rdbC;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.Button btnkec;
        private System.Windows.Forms.ProgressBar prgbar;
    }
}