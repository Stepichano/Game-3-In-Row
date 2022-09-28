namespace WinFormsApp1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
      this.label1 = new System.Windows.Forms.Label();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.label1.Location = new System.Drawing.Point(-6, 58);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(1212, 632);
      this.label1.TabIndex = 0;
      this.label1.Text = resources.GetString("label1.Text");
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
      this.menuStrip1.Size = new System.Drawing.Size(1200, 35);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToMenuToolStripMenuItem});
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 29);
      this.toolStripMenuItem1.Text = "File";
      // 
      // exitToMenuToolStripMenuItem
      // 
      this.exitToMenuToolStripMenuItem.Name = "exitToMenuToolStripMenuItem";
      this.exitToMenuToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
      this.exitToMenuToolStripMenuItem.Text = "Exit to Menu";
      this.exitToMenuToolStripMenuItem.Click += new System.EventHandler(this.exitToMenuToolStripMenuItem_Click);
      // 
      // Form3
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1200, 684);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "Form3";
      this.Text = "Help";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem exitToMenuToolStripMenuItem;
    }
}