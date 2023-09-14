namespace Clase05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            opcion1ToolStripMenuItem = new ToolStripMenuItem();
            opcion1ToolStripMenuItem1 = new ToolStripMenuItem();
            opcion2ToolStripMenuItem1 = new ToolStripMenuItem();
            opcion3ToolStripMenuItem1 = new ToolStripMenuItem();
            opcion2ToolStripMenuItem = new ToolStripMenuItem();
            opciòn1ToolStripMenuItem = new ToolStripMenuItem();
            opciòn2ToolStripMenuItem = new ToolStripMenuItem();
            opcion3ToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextual1ToolStripMenuItem = new ToolStripMenuItem();
            contextual2ToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcion1ToolStripMenuItem, opcion2ToolStripMenuItem, opcion3ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // opcion1ToolStripMenuItem
            // 
            opcion1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { opcion1ToolStripMenuItem1, opcion2ToolStripMenuItem1, opcion3ToolStripMenuItem1 });
            opcion1ToolStripMenuItem.Name = "opcion1ToolStripMenuItem";
            opcion1ToolStripMenuItem.Size = new Size(59, 20);
            opcion1ToolStripMenuItem.Text = "Menù 1";
            opcion1ToolStripMenuItem.Click += opcion1ToolStripMenuItem_Click;
            // 
            // opcion1ToolStripMenuItem1
            // 
            opcion1ToolStripMenuItem1.Name = "opcion1ToolStripMenuItem1";
            opcion1ToolStripMenuItem1.Size = new Size(122, 22);
            opcion1ToolStripMenuItem1.Text = "Opcion 1";
            // 
            // opcion2ToolStripMenuItem1
            // 
            opcion2ToolStripMenuItem1.Name = "opcion2ToolStripMenuItem1";
            opcion2ToolStripMenuItem1.Size = new Size(122, 22);
            opcion2ToolStripMenuItem1.Text = "Opcion 2";
            // 
            // opcion3ToolStripMenuItem1
            // 
            opcion3ToolStripMenuItem1.Name = "opcion3ToolStripMenuItem1";
            opcion3ToolStripMenuItem1.Size = new Size(122, 22);
            opcion3ToolStripMenuItem1.Text = "Opcion 3";
            // 
            // opcion2ToolStripMenuItem
            // 
            opcion2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { opciòn1ToolStripMenuItem, opciòn2ToolStripMenuItem });
            opcion2ToolStripMenuItem.Name = "opcion2ToolStripMenuItem";
            opcion2ToolStripMenuItem.Size = new Size(59, 20);
            opcion2ToolStripMenuItem.Text = "Menù 2";
            // 
            // opciòn1ToolStripMenuItem
            // 
            opciòn1ToolStripMenuItem.Name = "opciòn1ToolStripMenuItem";
            opciòn1ToolStripMenuItem.Size = new Size(122, 22);
            opciòn1ToolStripMenuItem.Text = "Opciòn 1";
            // 
            // opciòn2ToolStripMenuItem
            // 
            opciòn2ToolStripMenuItem.Name = "opciòn2ToolStripMenuItem";
            opciòn2ToolStripMenuItem.Size = new Size(122, 22);
            opciòn2ToolStripMenuItem.Text = "Opciòn 2";
            // 
            // opcion3ToolStripMenuItem
            // 
            opcion3ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            opcion3ToolStripMenuItem.Name = "opcion3ToolStripMenuItem";
            opcion3ToolStripMenuItem.Size = new Size(59, 20);
            opcion3ToolStripMenuItem.Text = "Menù 3";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { contextual1ToolStripMenuItem, contextual2ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 70);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // contextual1ToolStripMenuItem
            // 
            contextual1ToolStripMenuItem.Name = "contextual1ToolStripMenuItem";
            contextual1ToolStripMenuItem.Size = new Size(180, 22);
            contextual1ToolStripMenuItem.Text = "Contextual 1";
            contextual1ToolStripMenuItem.Click += contextual1ToolStripMenuItem_Click;
            // 
            // contextual2ToolStripMenuItem
            // 
            contextual2ToolStripMenuItem.Name = "contextual2ToolStripMenuItem";
            contextual2ToolStripMenuItem.Size = new Size(180, 22);
            contextual2ToolStripMenuItem.Text = "Contextual 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 218);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcion1ToolStripMenuItem;
        private ToolStripMenuItem opcion2ToolStripMenuItem;
        private ToolStripMenuItem opcion3ToolStripMenuItem;
        private ToolStripMenuItem opcion1ToolStripMenuItem1;
        private ToolStripMenuItem opcion2ToolStripMenuItem1;
        private ToolStripMenuItem opcion3ToolStripMenuItem1;
        private ToolStripMenuItem opciòn1ToolStripMenuItem;
        private ToolStripMenuItem opciòn2ToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem contextual1ToolStripMenuItem;
        private ToolStripMenuItem contextual2ToolStripMenuItem;
        private Label label1;
    }
}