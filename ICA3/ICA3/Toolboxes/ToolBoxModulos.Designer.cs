﻿namespace ICA3.Toolboxes
{
    partial class ToolBoxModulos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBoxModulos));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.agregarAFavoritosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarDeFavoritosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.HideSelection = false;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.ImageList1;
            this.treeView1.Indent = 19;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(343, 608);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desconectarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.agregarAFavoritosToolStripMenuItem1,
            this.quitarDeFavoritosToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(208, 82);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(207, 6);
            // 
            // agregarAFavoritosToolStripMenuItem1
            // 
            this.agregarAFavoritosToolStripMenuItem1.Name = "agregarAFavoritosToolStripMenuItem1";
            this.agregarAFavoritosToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.agregarAFavoritosToolStripMenuItem1.Text = "Agregar a Favoritos";
            this.agregarAFavoritosToolStripMenuItem1.Click += new System.EventHandler(this.agregarAFavoritosToolStripMenuItem1_Click);
            // 
            // quitarDeFavoritosToolStripMenuItem1
            // 
            this.quitarDeFavoritosToolStripMenuItem1.Name = "quitarDeFavoritosToolStripMenuItem1";
            this.quitarDeFavoritosToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.quitarDeFavoritosToolStripMenuItem1.Text = "Quitar de Favoritos";
            this.quitarDeFavoritosToolStripMenuItem1.Click += new System.EventHandler(this.quitarDeFavoritosToolStripMenuItem1_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "db16.ico");
            this.ImageList1.Images.SetKeyName(1, "db16_d.ico");
            this.ImageList1.Images.SetKeyName(2, "Refrescar.ico");
            // 
            // ToolBoxModulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 608);
            this.Controls.Add(this.treeView1);
            this.Name = "ToolBoxModulos";
            this.TabPageContextMenuStrip = this.contextMenuStrip1;
            this.Text = "Explorador de sistemas";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        internal System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarAFavoritosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitarDeFavoritosToolStripMenuItem1;
    }
}