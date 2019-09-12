namespace AtividadeAulaMetodos
{
    partial class frmPrincipal
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
            this.exercíciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exerc1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exerc3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exerc4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercíciosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exercíciosToolStripMenuItem
            // 
            this.exercíciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exerc1ToolStripMenuItem,
            this.exercício2ToolStripMenuItem,
            this.exerc3ToolStripMenuItem,
            this.exerc4ToolStripMenuItem});
            this.exercíciosToolStripMenuItem.Name = "exercíciosToolStripMenuItem";
            this.exercíciosToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.exercíciosToolStripMenuItem.Text = "Exercícios";
            // 
            // exerc1ToolStripMenuItem
            // 
            this.exerc1ToolStripMenuItem.Name = "exerc1ToolStripMenuItem";
            this.exerc1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exerc1ToolStripMenuItem.Text = "Exerc. 1";
            this.exerc1ToolStripMenuItem.Click += new System.EventHandler(this.exerc1ToolStripMenuItem_Click);
            // 
            // exercício2ToolStripMenuItem
            // 
            this.exercício2ToolStripMenuItem.Name = "exercício2ToolStripMenuItem";
            this.exercício2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exercício2ToolStripMenuItem.Text = "Exerc. 2";
            this.exercício2ToolStripMenuItem.Click += new System.EventHandler(this.exercício2ToolStripMenuItem_Click);
            // 
            // exerc3ToolStripMenuItem
            // 
            this.exerc3ToolStripMenuItem.Name = "exerc3ToolStripMenuItem";
            this.exerc3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exerc3ToolStripMenuItem.Text = "Exerc. 3";
            this.exerc3ToolStripMenuItem.Click += new System.EventHandler(this.exerc3ToolStripMenuItem_Click);
            // 
            // exerc4ToolStripMenuItem
            // 
            this.exerc4ToolStripMenuItem.Name = "exerc4ToolStripMenuItem";
            this.exerc4ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exerc4ToolStripMenuItem.Text = "Exerc. 4";
            this.exerc4ToolStripMenuItem.Click += new System.EventHandler(this.exerc4ToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 358);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exercíciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exerc1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exerc3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exerc4ToolStripMenuItem;
    }
}

