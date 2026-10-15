using System;

namespace WindowsFormsApp1
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblyas = new System.Windows.Forms.Label();
            this.cmbkurs = new System.Windows.Forms.ComboBox();
            this.nmryas = new System.Windows.Forms.NumericUpDown();
            this.lblkurs = new System.Windows.Forms.Label();
            this.rq = new System.Windows.Forms.RadioButton();
            this.rk = new System.Windows.Forms.RadioButton();
            this.lblist = new System.Windows.Forms.ListBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.lblelave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmryas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(22, 29);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(121, 20);
            this.txtname.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(19, 9);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(91, 16);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Telebenin adi";
            // 
            // lblyas
            // 
            this.lblyas.AutoSize = true;
            this.lblyas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyas.Location = new System.Drawing.Point(22, 56);
            this.lblyas.Name = "lblyas";
            this.lblyas.Size = new System.Drawing.Size(28, 16);
            this.lblyas.TabIndex = 3;
            this.lblyas.Text = "Yas";
            // 
            // cmbkurs
            // 
            this.cmbkurs.FormattingEnabled = true;
            this.cmbkurs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            ""});
            this.cmbkurs.Location = new System.Drawing.Point(22, 118);
            this.cmbkurs.Name = "cmbkurs";
            this.cmbkurs.Size = new System.Drawing.Size(121, 21);
            this.cmbkurs.TabIndex = 4;
            // 
            // nmryas
            // 
            this.nmryas.Location = new System.Drawing.Point(22, 73);
            this.nmryas.Name = "nmryas";
            this.nmryas.Size = new System.Drawing.Size(120, 20);
            this.nmryas.TabIndex = 5;
            // 
            // lblkurs
            // 
            this.lblkurs.AutoSize = true;
            this.lblkurs.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkurs.Location = new System.Drawing.Point(19, 102);
            this.lblkurs.Name = "lblkurs";
            this.lblkurs.Size = new System.Drawing.Size(34, 16);
            this.lblkurs.TabIndex = 6;
            this.lblkurs.Text = "Kurs";
            // 
            // rq
            // 
            this.rq.AutoSize = true;
            this.rq.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rq.Location = new System.Drawing.Point(22, 146);
            this.rq.Name = "rq";
            this.rq.Size = new System.Drawing.Size(57, 18);
            this.rq.TabIndex = 7;
            this.rq.TabStop = true;
            this.rq.Text = "Qadin";
            this.rq.UseVisualStyleBackColor = true;
            // 
            // rk
            // 
            this.rk.AutoSize = true;
            this.rk.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rk.Location = new System.Drawing.Point(85, 146);
            this.rk.Name = "rk";
            this.rk.Size = new System.Drawing.Size(42, 18);
            this.rk.TabIndex = 8;
            this.rk.TabStop = true;
            this.rk.Text = "Kisi";
            this.rk.UseVisualStyleBackColor = true;
            // 
            // lblist
            // 
            this.lblist.FormattingEnabled = true;
            this.lblist.Location = new System.Drawing.Point(318, 12);
            this.lblist.Name = "lblist";
            this.lblist.Size = new System.Drawing.Size(368, 225);
            this.lblist.TabIndex = 9;
            this.lblist.Click += new System.EventHandler(this.lblist_SelectedIndexChanged);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(22, 183);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(120, 23);
            this.btnsil.TabIndex = 10;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(22, 212);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(120, 23);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "Elave et";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_click);
            // 
            // lblelave
            // 
            this.lblelave.AutoSize = true;
            this.lblelave.Location = new System.Drawing.Point(318, 254);
            this.lblelave.Name = "lblelave";
            this.lblelave.Size = new System.Drawing.Size(0, 13);
            this.lblelave.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblelave);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.lblist);
            this.Controls.Add(this.rk);
            this.Controls.Add(this.rq);
            this.Controls.Add(this.lblkurs);
            this.Controls.Add(this.nmryas);
            this.Controls.Add(this.cmbkurs);
            this.Controls.Add(this.lblyas);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtname);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmryas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblyas;
        private System.Windows.Forms.ComboBox cmbkurs;
        private System.Windows.Forms.NumericUpDown nmryas;
        private System.Windows.Forms.Label lblkurs;
        private System.Windows.Forms.RadioButton rq;
        private System.Windows.Forms.RadioButton rk;
        private System.Windows.Forms.ListBox lblist;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblelave;
    }
}

