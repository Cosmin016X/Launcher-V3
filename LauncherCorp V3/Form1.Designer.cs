
namespace LauncherCorp_V3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.faowiejfawoijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.awdwadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adwawdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adwawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faowiejfawoijToolStripMenuItem,
            this.startToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(54, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // faowiejfawoijToolStripMenuItem
            // 
            this.faowiejfawoijToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wdaToolStripMenuItem,
            this.awdwadToolStripMenuItem,
            this.adwawdToolStripMenuItem,
            this.adwawToolStripMenuItem,
            this.donacionesToolStripMenuItem});
            this.faowiejfawoijToolStripMenuItem.Name = "faowiejfawoijToolStripMenuItem";
            this.faowiejfawoijToolStripMenuItem.Size = new System.Drawing.Size(41, 19);
            this.faowiejfawoijToolStripMenuItem.Text = "Inicio";
            this.faowiejfawoijToolStripMenuItem.Click += new System.EventHandler(this.faowiejfawoijToolStripMenuItem_Click);
            // 
            // wdaToolStripMenuItem
            // 
            this.wdaToolStripMenuItem.Name = "wdaToolStripMenuItem";
            this.wdaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wdaToolStripMenuItem.Text = "Discord";
            this.wdaToolStripMenuItem.Click += new System.EventHandler(this.wdaToolStripMenuItem_Click);
            // 
            // awdwadToolStripMenuItem
            // 
            this.awdwadToolStripMenuItem.Name = "awdwadToolStripMenuItem";
            this.awdwadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.awdwadToolStripMenuItem.Text = "FireWeb";
            // 
            // adwawdToolStripMenuItem
            // 
            this.adwawdToolStripMenuItem.Name = "adwawdToolStripMenuItem";
            this.adwawdToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adwawdToolStripMenuItem.Text = "Normativa";
            this.adwawdToolStripMenuItem.Click += new System.EventHandler(this.adwawdToolStripMenuItem_Click);
            // 
            // adwawToolStripMenuItem
            // 
            this.adwawToolStripMenuItem.Name = "adwawToolStripMenuItem";
            this.adwawToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adwawToolStripMenuItem.Text = "FireList";
            this.adwawToolStripMenuItem.Click += new System.EventHandler(this.adwawToolStripMenuItem_Click);
            // 
            // donacionesToolStripMenuItem
            // 
            this.donacionesToolStripMenuItem.Name = "donacionesToolStripMenuItem";
            this.donacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.donacionesToolStripMenuItem.Text = "Donaciones";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(41, 19);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.connectToolStripMenuItem.Text = "Connect 25.92.101.88:30120";
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.menuStrip1);
            this.panelLogo.Location = new System.Drawing.Point(12, 12);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(52, 48);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.panelLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(850, 550);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FireLauncher V3";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem faowiejfawoijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem awdwadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adwawdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adwawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
    }
}

