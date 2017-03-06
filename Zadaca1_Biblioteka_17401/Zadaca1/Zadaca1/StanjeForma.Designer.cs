namespace NSBiblioteka {
    partial class StanjeForma {
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
            this.groupBoxZaduzeno = new System.Windows.Forms.GroupBox();
            this.groupBoxNezaduzeno = new System.Windows.Forms.GroupBox();
            this.treeViewZaduzenja = new System.Windows.Forms.TreeView();
            this.listBoxSlobodno = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pređiNaČlanoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pređiNaKnjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandujSveNodoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skupiSveNodoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxZaduzeno.SuspendLayout();
            this.groupBoxNezaduzeno.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxZaduzeno
            // 
            this.groupBoxZaduzeno.Controls.Add(this.treeViewZaduzenja);
            this.groupBoxZaduzeno.Location = new System.Drawing.Point(13, 33);
            this.groupBoxZaduzeno.Name = "groupBoxZaduzeno";
            this.groupBoxZaduzeno.Size = new System.Drawing.Size(246, 494);
            this.groupBoxZaduzeno.TabIndex = 0;
            this.groupBoxZaduzeno.TabStop = false;
            this.groupBoxZaduzeno.Text = "groupBoxZaduzeno";
            // 
            // groupBoxNezaduzeno
            // 
            this.groupBoxNezaduzeno.Controls.Add(this.listBoxSlobodno);
            this.groupBoxNezaduzeno.Location = new System.Drawing.Point(266, 33);
            this.groupBoxNezaduzeno.Name = "groupBoxNezaduzeno";
            this.groupBoxNezaduzeno.Size = new System.Drawing.Size(367, 494);
            this.groupBoxNezaduzeno.TabIndex = 1;
            this.groupBoxNezaduzeno.TabStop = false;
            this.groupBoxNezaduzeno.Text = "groupBox2";
            // 
            // treeViewZaduzenja
            // 
            this.treeViewZaduzenja.Location = new System.Drawing.Point(7, 20);
            this.treeViewZaduzenja.Name = "treeViewZaduzenja";
            this.treeViewZaduzenja.Size = new System.Drawing.Size(233, 488);
            this.treeViewZaduzenja.TabIndex = 0;
            // 
            // listBoxSlobodno
            // 
            this.listBoxSlobodno.FormattingEnabled = true;
            this.listBoxSlobodno.Location = new System.Drawing.Point(7, 20);
            this.listBoxSlobodno.Name = "listBoxSlobodno";
            this.listBoxSlobodno.Size = new System.Drawing.Size(350, 485);
            this.listBoxSlobodno.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pređiNaČlanoveToolStripMenuItem,
            this.pređiNaKnjigeToolStripMenuItem,
            this.expandujSveNodoveToolStripMenuItem,
            this.skupiSveNodoveToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem1.Text = "Opcije";
            // 
            // pređiNaČlanoveToolStripMenuItem
            // 
            this.pređiNaČlanoveToolStripMenuItem.Name = "pređiNaČlanoveToolStripMenuItem";
            this.pređiNaČlanoveToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.pređiNaČlanoveToolStripMenuItem.Text = "Pređi na članove";
            this.pređiNaČlanoveToolStripMenuItem.Click += new System.EventHandler(this.pređiNaČlanoveToolStripMenuItem_Click);
            // 
            // pređiNaKnjigeToolStripMenuItem
            // 
            this.pređiNaKnjigeToolStripMenuItem.Name = "pređiNaKnjigeToolStripMenuItem";
            this.pređiNaKnjigeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.pređiNaKnjigeToolStripMenuItem.Text = "Pređi na knjige";
            this.pređiNaKnjigeToolStripMenuItem.Click += new System.EventHandler(this.pređiNaKnjigeToolStripMenuItem_Click);
            // 
            // expandujSveNodoveToolStripMenuItem
            // 
            this.expandujSveNodoveToolStripMenuItem.Name = "expandujSveNodoveToolStripMenuItem";
            this.expandujSveNodoveToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.expandujSveNodoveToolStripMenuItem.Text = "Proširi sve nodove";
            this.expandujSveNodoveToolStripMenuItem.Click += new System.EventHandler(this.expandujSveNodoveToolStripMenuItem_Click);
            // 
            // skupiSveNodoveToolStripMenuItem
            // 
            this.skupiSveNodoveToolStripMenuItem.Name = "skupiSveNodoveToolStripMenuItem";
            this.skupiSveNodoveToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.skupiSveNodoveToolStripMenuItem.Text = "Skupi sve nodove";
            this.skupiSveNodoveToolStripMenuItem.Click += new System.EventHandler(this.skupiSveNodoveToolStripMenuItem_Click);
            // 
            // StanjeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 539);
            this.Controls.Add(this.groupBoxNezaduzeno);
            this.Controls.Add(this.groupBoxZaduzeno);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StanjeForma";
            this.Text = "Stanje";
            this.groupBoxZaduzeno.ResumeLayout(false);
            this.groupBoxNezaduzeno.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxZaduzeno;
        private System.Windows.Forms.GroupBox groupBoxNezaduzeno;
        private System.Windows.Forms.TreeView treeViewZaduzenja;
        private System.Windows.Forms.ListBox listBoxSlobodno;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pređiNaČlanoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pređiNaKnjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandujSveNodoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem skupiSveNodoveToolStripMenuItem;
    }
}