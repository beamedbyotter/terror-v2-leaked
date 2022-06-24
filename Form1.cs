// beemed by otta

using FastColoredTextBoxNS;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WeAreDevs_API;

namespace E_Ware
{
  public class Form1 : Form
  {
    private Point lastPoint;
    private ExploitAPI module = new ExploitAPI();
    private IContainer components = (IContainer) null;
    private Panel panel1;
    private Label name;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button close;
    private FastColoredTextBox fastColoredTextBox1;
    private ListBox listBox1;
    private Button button8;

    public Form1() => this.InitializeComponent();

    private void button2_Click(object sender, EventArgs e) => this.module.LaunchExploit();

    private void close_Click(object sender, EventArgs e) => Application.Exit();

    private void button7_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

    private void Form1_Load(object sender, EventArgs e)
    {
      this.listBox1.Items.Clear();
      Functions.PopulateListBox(this.listBox1, "./Scripts", "*.txt");
      Functions.PopulateListBox(this.listBox1, "./Scripts", "*.lua");
    }

    private void button1_Click(object sender, EventArgs e) => this.module.SendLuaScript(this.fastColoredTextBox1.Text);

    private void button6_Click(object sender, EventArgs e) => this.fastColoredTextBox1.Clear();

    private void panel1_MouseDown(object sender, MouseEventArgs e) => this.lastPoint = new Point(e.X, e.Y);

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.Left += e.X - this.lastPoint.X;
      this.Top += e.Y - this.lastPoint.Y;
    }

    private void button5_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      openFileDialog.Title = "Open";
      this.fastColoredTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
    }

    private void button4_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      using (Stream stream = (Stream) File.Open(saveFileDialog.FileName, FileMode.CreateNew))
      {
        using (StreamWriter streamWriter = new StreamWriter(stream))
          streamWriter.Write(this.fastColoredTextBox1.Text);
      }
    }

    private void button3_Click(object sender, EventArgs e) => new ScriptHub().Show();

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e) => this.fastColoredTextBox1.Text = File.ReadAllText(string.Format("./Scripts/{0}", this.listBox1.SelectedItem));

    private void button8_Click(object sender, EventArgs e)
    {
      this.listBox1.Items.Clear();
      Functions.PopulateListBox(this.listBox1, "./Scripts", "*.txt");
      Functions.PopulateListBox(this.listBox1, "./Scripts", "*.lua");
    }

    private void name_Click(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.panel1 = new Panel();
      this.button8 = new Button();
      this.button7 = new Button();
      this.close = new Button();
      this.name = new Label();
      this.button1 = new Button();
      this.button2 = new Button();
      this.button3 = new Button();
      this.button4 = new Button();
      this.button5 = new Button();
      this.button6 = new Button();
      this.fastColoredTextBox1 = new FastColoredTextBox();
      this.listBox1 = new ListBox();
      this.panel1.SuspendLayout();
      ((ISupportInitialize) this.fastColoredTextBox1).BeginInit();
      this.SuspendLayout();
      this.panel1.BackColor = Color.FromArgb(5, 5, 5);
      this.panel1.Controls.Add((Control) this.button8);
      this.panel1.Controls.Add((Control) this.button7);
      this.panel1.Controls.Add((Control) this.close);
      this.panel1.Controls.Add((Control) this.name);
      this.panel1.Location = new Point(-1, -1);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(644, 30);
      this.panel1.TabIndex = 0;
      this.panel1.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
      this.panel1.MouseMove += new MouseEventHandler(this.panel1_MouseMove);
      this.button8.BackColor = Color.FromArgb(10, 10, 10);
      this.button8.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button8.ForeColor = Color.Red;
      this.button8.Location = new Point(538, 3);
      this.button8.Name = "button8";
      this.button8.Size = new Size(28, 23);
      this.button8.TabIndex = 3;
      this.button8.Text = "↻";
      this.button8.UseVisualStyleBackColor = false;
      this.button8.Click += new EventHandler(this.button8_Click);
      this.button7.BackColor = Color.FromArgb(10, 10, 10);
      this.button7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button7.ForeColor = Color.Red;
      this.button7.Location = new Point(572, 3);
      this.button7.Name = "button7";
      this.button7.Size = new Size(28, 23);
      this.button7.TabIndex = 2;
      this.button7.Text = "-";
      this.button7.UseVisualStyleBackColor = false;
      this.button7.Click += new EventHandler(this.button7_Click);
      this.close.BackColor = Color.FromArgb(10, 10, 10);
      this.close.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.close.ForeColor = Color.Red;
      this.close.Location = new Point(606, 3);
      this.close.Name = "close";
      this.close.Size = new Size(28, 23);
      this.close.TabIndex = 1;
      this.close.Text = "X";
      this.close.UseVisualStyleBackColor = false;
      this.close.Click += new EventHandler(this.close_Click);
      this.name.AutoSize = true;
      this.name.BackColor = Color.Black;
      this.name.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.name.ForeColor = Color.Red;
      this.name.Location = new Point(5, 3);
      this.name.Name = "name";
      this.name.Size = new Size(68, 24);
      this.name.TabIndex = 0;
      this.name.Text = "Terror";
      this.name.Click += new EventHandler(this.name_Click);
      this.button1.BackColor = Color.FromArgb(10, 10, 10);
      this.button1.ForeColor = Color.Red;
      this.button1.Location = new Point(6, 288);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Execute";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.BackColor = Color.FromArgb(10, 10, 10);
      this.button2.ForeColor = Color.Red;
      this.button2.Location = new Point(558, 288);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "Inject";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button3.BackColor = Color.FromArgb(10, 10, 10);
      this.button3.ForeColor = Color.Red;
      this.button3.Location = new Point(330, 288);
      this.button3.Name = "button3";
      this.button3.Size = new Size(75, 23);
      this.button3.TabIndex = 3;
      this.button3.Text = "Script Hub";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button4.BackColor = Color.FromArgb(10, 10, 10);
      this.button4.ForeColor = Color.Red;
      this.button4.Location = new Point(249, 288);
      this.button4.Name = "button4";
      this.button4.Size = new Size(75, 23);
      this.button4.TabIndex = 4;
      this.button4.Text = "Save File";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button5.BackColor = Color.FromArgb(10, 10, 10);
      this.button5.ForeColor = Color.Red;
      this.button5.Location = new Point(168, 288);
      this.button5.Name = "button5";
      this.button5.Size = new Size(75, 23);
      this.button5.TabIndex = 5;
      this.button5.Text = "Open File";
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.button6.BackColor = Color.FromArgb(10, 10, 10);
      this.button6.ForeColor = Color.Red;
      this.button6.Location = new Point(87, 288);
      this.button6.Name = "button6";
      this.button6.Size = new Size(75, 23);
      this.button6.TabIndex = 6;
      this.button6.Text = "Clear";
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.fastColoredTextBox1.AutoCompleteBracketsList = new char[10]
      {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '"',
        '"',
        '\'',
        '\''
      };
      this.fastColoredTextBox1.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
      this.fastColoredTextBox1.AutoScrollMinSize = new Size(179, 42);
      this.fastColoredTextBox1.BackBrush = (Brush) null;
      this.fastColoredTextBox1.BackColor = Color.FromArgb(20, 20, 20);
      this.fastColoredTextBox1.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2;
      this.fastColoredTextBox1.CharHeight = 14;
      this.fastColoredTextBox1.CharWidth = 8;
      this.fastColoredTextBox1.CommentPrefix = "--";
      this.fastColoredTextBox1.Cursor = Cursors.IBeam;
      this.fastColoredTextBox1.DisabledColor = Color.FromArgb(100, 180, 180, 180);
      this.fastColoredTextBox1.ForeColor = Color.Red;
      this.fastColoredTextBox1.IndentBackColor = Color.FromArgb(20, 20, 20);
      this.fastColoredTextBox1.IsReplaceMode = false;
      this.fastColoredTextBox1.Language = Language.Lua;
      this.fastColoredTextBox1.LeftBracket = '(';
      this.fastColoredTextBox1.LeftBracket2 = '{';
      this.fastColoredTextBox1.LineNumberColor = Color.Red;
      this.fastColoredTextBox1.Location = new Point(-1, 36);
      this.fastColoredTextBox1.Name = "fastColoredTextBox1";
      this.fastColoredTextBox1.Paddings = new Padding(0);
      this.fastColoredTextBox1.RightBracket = ')';
      this.fastColoredTextBox1.RightBracket2 = '}';
      this.fastColoredTextBox1.SelectionColor = Color.FromArgb(60, 0, 0, (int) byte.MaxValue);
      this.fastColoredTextBox1.ServiceColors = (ServiceColors) componentResourceManager.GetObject("fastColoredTextBox1.ServiceColors");
      this.fastColoredTextBox1.Size = new Size(481, 246);
      this.fastColoredTextBox1.TabIndex = 7;
      this.fastColoredTextBox1.Text = "Made by Toro10\r\nFollow me on tiktok\r\n";
      this.fastColoredTextBox1.Zoom = 100;
      this.listBox1.BackColor = Color.FromArgb(20, 20, 20);
      this.listBox1.BorderStyle = BorderStyle.None;
      this.listBox1.ForeColor = Color.Red;
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new Point(486, 35);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new Size(147, 247);
      this.listBox1.TabIndex = 8;
      this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(10, 10, 10);
      this.ClientSize = new Size(645, 318);
      this.Controls.Add((Control) this.listBox1);
      this.Controls.Add((Control) this.fastColoredTextBox1);
      this.Controls.Add((Control) this.button6);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (Form1);
      this.Text = nameof (Form1);
      this.Load += new EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((ISupportInitialize) this.fastColoredTextBox1).EndInit();
      this.ResumeLayout(false);
    }
  }
}
