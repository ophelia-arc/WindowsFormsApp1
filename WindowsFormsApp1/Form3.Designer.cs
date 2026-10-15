namespace WindowsFormsApp1
{
    partial class Form3
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btntopla = new System.Windows.Forms.Button();
            this.btncix = new System.Windows.Forms.Button();
            this.btnvur = new System.Windows.Forms.Button();
            this.btnbol = new System.Windows.Forms.Button();
            this.lblnetice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(23, 25);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(143, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(23, 51);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(143, 20);
            this.txtB.TabIndex = 1;
            // 
            // btntopla
            // 
            this.btntopla.Location = new System.Drawing.Point(23, 78);
            this.btntopla.Name = "btntopla";
            this.btntopla.Size = new System.Drawing.Size(21, 23);
            this.btntopla.TabIndex = 2;
            this.btntopla.Text = "+";
            this.btntopla.UseVisualStyleBackColor = true;
            this.btntopla.Click += new System.EventHandler(this.btntopla_Click);
            // 
            // btncix
            // 
            this.btncix.Location = new System.Drawing.Point(50, 78);
            this.btncix.Name = "btncix";
            this.btncix.Size = new System.Drawing.Size(21, 23);
            this.btncix.TabIndex = 3;
            this.btncix.Text = "-";
            this.btncix.UseVisualStyleBackColor = true;
            this.btncix.Click += new System.EventHandler(this.btncix_Click);
            // 
            // btnvur
            // 
            this.btnvur.Location = new System.Drawing.Point(77, 78);
            this.btnvur.Name = "btnvur";
            this.btnvur.Size = new System.Drawing.Size(21, 23);
            this.btnvur.TabIndex = 4;
            this.btnvur.Text = "×";
            this.btnvur.UseVisualStyleBackColor = true;
            this.btnvur.Click += new System.EventHandler(this.btnvur_Click);
            // 
            // btnbol
            // 
            this.btnbol.Location = new System.Drawing.Point(104, 78);
            this.btnbol.Name = "btnbol";
            this.btnbol.Size = new System.Drawing.Size(21, 23);
            this.btnbol.TabIndex = 5;
            this.btnbol.Text = "÷";
            this.btnbol.UseVisualStyleBackColor = true;
            this.btnbol.Click += new System.EventHandler(this.btnbol_Click);
            // 
            // lblnetice
            // 
            this.lblnetice.AutoSize = true;
            this.lblnetice.Location = new System.Drawing.Point(20, 116);
            this.lblnetice.Name = "lblnetice";
            this.lblnetice.Size = new System.Drawing.Size(41, 13);
            this.lblnetice.TabIndex = 6;
            this.lblnetice.Text = "Netice:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 242);
            this.Controls.Add(this.lblnetice);
            this.Controls.Add(this.btnbol);
            this.Controls.Add(this.btnvur);
            this.Controls.Add(this.btncix);
            this.Controls.Add(this.btntopla);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btntopla;
        private System.Windows.Forms.Button btncix;
        private System.Windows.Forms.Button btnvur;
        private System.Windows.Forms.Button btnbol;
        private System.Windows.Forms.Label lblnetice;
    }
}