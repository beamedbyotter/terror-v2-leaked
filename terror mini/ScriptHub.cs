// @woahotter on tiktok

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace E_Ware
{
  public class ScriptHub : Form
  {
    private IContainer components = (IContainer) null;
    private Button close;

    public ScriptHub() => this.InitializeComponent();

    private void close_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.close = new Button();
      this.SuspendLayout();
      this.close.BackColor = Color.FromArgb(10, 10, 10);
      this.close.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.close.ForeColor = Color.White;
      this.close.Location = new Point(760, 12);
      this.close.Name = "close";
      this.close.Size = new Size(28, 23);
      this.close.TabIndex = 2;
      this.close.Text = "X";
      this.close.UseVisualStyleBackColor = false;
      this.close.Click += new EventHandler(this.close_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(20, 20, 20);
      this.ClientSize = new Size(800, 450);
      this.Controls.Add((Control) this.close);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (ScriptHub);
      this.Text = nameof (ScriptHub);
      this.ResumeLayout(false);
    }
  }
}
