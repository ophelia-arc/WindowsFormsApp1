namespace WindowsFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menufayl = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saxlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cixisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sriftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rengToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbkod = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblcount = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menufayl,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menufayl
            // 
            this.menufayl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.acToolStripMenuItem,
            this.saxlaToolStripMenuItem,
            this.cixisToolStripMenuItem});
            this.menufayl.Name = "menufayl";
            this.menufayl.Size = new System.Drawing.Size(40, 20);
            this.menufayl.Text = "Fayl";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.yeniToolStripMenuItem.Text = "Yeni";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // acToolStripMenuItem
            // 
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.acToolStripMenuItem.Text = "Ac";
            this.acToolStripMenuItem.Click += new System.EventHandler(this.acToolStripMenuItem_Click);
            // 
            // saxlaToolStripMenuItem
            // 
            this.saxlaToolStripMenuItem.Name = "saxlaToolStripMenuItem";
            this.saxlaToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.saxlaToolStripMenuItem.Text = "Saxla";
            this.saxlaToolStripMenuItem.Click += new System.EventHandler(this.saxlaToolStripMenuItem_Click);
            // 
            // cixisToolStripMenuItem
            // 
            this.cixisToolStripMenuItem.Name = "cixisToolStripMenuItem";
            this.cixisToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.cixisToolStripMenuItem.Text = "Cixis";
            this.cixisToolStripMenuItem.Click += new System.EventHandler(this.cixisToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sriftToolStripMenuItem,
            this.rengToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // sriftToolStripMenuItem
            // 
            this.sriftToolStripMenuItem.Name = "sriftToolStripMenuItem";
            this.sriftToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.sriftToolStripMenuItem.Text = "Srift";
            this.sriftToolStripMenuItem.Click += new System.EventHandler(this.sriftToolStripMenuItem_Click);
            // 
            // rengToolStripMenuItem
            // 
            this.rengToolStripMenuItem.Name = "rengToolStripMenuItem";
            this.rengToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.rengToolStripMenuItem.Text = "Reng";
            this.rengToolStripMenuItem.Click += new System.EventHandler(this.rengToolStripMenuItem_Click);
            // 
            // rtbkod
            // 
            this.rtbkod.BackColor = System.Drawing.Color.White;
            this.rtbkod.Location = new System.Drawing.Point(13, 28);
            this.rtbkod.Name = "rtbkod";
            this.rtbkod.Size = new System.Drawing.Size(775, 410);
            this.rtbkod.TabIndex = 1;
            this.rtbkod.Text = "";
            this.rtbkod.TextChanged += new System.EventHandler(this.rtbkod_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblcount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
           
            // 
            // lblcount
            // 
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(66, 17);
            this.lblcount.Text = "Simvol sayı";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rtbkod);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menufayl;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saxlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cixisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sriftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rengToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbkod;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblcount;
    }
}