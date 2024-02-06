using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clock
{
    public partial class Clock : Form
    {
        private Timer timer1;
        private IContainer components;
        private CheckBox cbShowDate;
        private Button btnHideControls;
        private Button btnExit;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showDateToolStripMenuItem;
        private ToolStripMenuItem showContolsToolStripMenuItem;
        private ToolStripSeparator exitToolStripMenuItem;
        private ToolStripSeparator exitToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem2;
        private Label label1;
        int dontIndex;
        public Clock()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            int startX = Screen.PrimaryScreen.Bounds.Width - this.Width - 25;
            int startY = 25;
            this.SetDesktopLocation(startX, startY);
            ControlsVisibility(false);
            cbShowDate.Checked = false;
            Directory.SetCurrentDirectory("..\\..\\Fonts");
            chooseForm = new ChoseForm();
            colorDialog1.Color = new Coloring;
            colorDialog2.Color = new Coloring;
            colorDialog1.Color = foreground;
            colorDialog2.Color = foreground;
            int music = 0;//переменная-флаг: 0 - музыка не играет, и не готова играть; 1 - музыка не играет, но готова играть; 3 - музыка играет
            string nameFileMusic = "";//путь до выбранного файла для сигнала будильника
            string Hours = "";//установленные на будильнике часы
            string Minutes = "";//установленные на будильнике минуты
            string Seconds = "";//установленные на будильнике секунды
            string[] Records;//список будильников
            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
            Color backgraound = bnew color.font();
            Chhose font media = new Font();

        }
        void ControlsVisibility(bool visible)
        {
            cbShowDate.Visible = visible;
            btnExit.Visible = visible;
            btnHideControls.Visible = visible;
            this.ShowInTaskbar = visible;
            this.TransparencyKey = !visible ? SystemColors.Control : Color.White;
            this.FormBorderStyle = !visible ? FormBorderStyle.None : FormBorderStyle.Sizable;
        }
        private void File_Load(object sender, EventArgs e)
        {

        }
        private void priv(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Close(object sender, EventArgs e)
        {
            return BindingMemberInfo();
            if (BindingMemberInfo(true))
            {
                void Close();
                Font = null;
                return (font);
            }
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbShowDate = new System.Windows.Forms.CheckBox();
            this.btnHideControls = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showContolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Font = new System.Drawing.Font("Vladimir Script", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 116);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.DoubleClick += new System.EventHandler(this.label1_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbShowDate
            // 
            this.cbShowDate.AutoSize = true;
            this.cbShowDate.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowDate.Location = new System.Drawing.Point(25, 240);
            this.cbShowDate.Name = "cbShowDate";
            this.cbShowDate.Size = new System.Drawing.Size(195, 56);
            this.cbShowDate.TabIndex = 2;
            this.cbShowDate.Text = "ShowDate";
            this.cbShowDate.UseVisualStyleBackColor = true;
            this.cbShowDate.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnHideControls
            // 
            this.btnHideControls.BackColor = System.Drawing.SystemColors.Control;
            this.btnHideControls.Font = new System.Drawing.Font("Vivaldi", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideControls.Location = new System.Drawing.Point(25, 408);
            this.btnHideControls.Name = "btnHideControls";
            this.btnHideControls.Size = new System.Drawing.Size(179, 62);
            this.btnHideControls.TabIndex = 3;
            this.btnHideControls.Text = "Hide controls";
            this.btnHideControls.UseVisualStyleBackColor = false;
            this.btnHideControls.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Vivaldi", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(25, 476);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(179, 62);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "The best alarm";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDateToolStripMenuItem,
            this.showContolsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1,
            this.exitToolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 82);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showDateToolStripMenuItem
            // 
            this.showDateToolStripMenuItem.Name = "showDateToolStripMenuItem";
            this.showDateToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.showDateToolStripMenuItem.Text = "Show date";
            // 
            // showContolsToolStripMenuItem
            // 
            this.showContolsToolStripMenuItem.Name = "showContolsToolStripMenuItem";
            this.showContolsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.showContolsToolStripMenuItem.Text = "Show contols";
            this.showContolsToolStripMenuItem.Click += new System.EventHandler(this.showControlsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 6);
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(142, 6);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(145, 22);
            this.exitToolStripMenuItem2.Text = "exit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Clock
            // 
            /*this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(599, 547);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHideControls);
            this.Controls.Add(this.cbShowDate);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clock";
            this.Text = "Clock";
            this.TopMost = true;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();*/

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("T");
            /*label2.Text = DateTime.Now.ToString("yyyy.MM.dd ddd");
            label2.Visible = cbShowDate.Checked;*/
            if (cbShowDate.Checked)
            {
                string date = DateTime.Now.ToString("yyyy.MM.dd ddd");
                label1.Text = $"{label1.Text}\n{date}";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlsVisibility(false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            ControlsVisibility(true);
            //label1_DoubleClick( sender,  e);
        }
        private void label1_DoubleClick(object sender, EventArgs e)
        {
            //ControlsVisibility(true);
        }
        private void cbShowDate_Click(object sender, EventArgs e)
        {
            ControlsVisibility(!cbShowDate.Checked);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void Close()
        {
            StreamWriter writer = new StreamWriter;
        }
        private void showDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbShowDate.Checked)
            {
                cbShowDate.Checked = false;
                //showDateToolStripMenuItem.Text = "Show date";
                timer1_Tick(sender, e);
                showDateToolStripMenuItem.Checked = false;
            }
            if ()
            {
                cbShowDate.Checked = true;
                timer1_Tick(sender, e);
                showDateToolStripMenuItem.Checked = true;
                void Close();
                return Font;
            }
            else
            {
                cbShowDate.Checked = true;
                //showDateToolStripMenuItem.Text = "Hide date";
                timer1_Tick(sender, e);
                showDateToolStripMenuItem.Checked = true;
            }
        }
        private void showControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (btnExit.Visible)
            {
                ControlsVisibility(false);
                //showControlsToolStripMenuItem.Text = "Show controls"; 
                showControlsToolStripMenuItem.Checked = false;
            }
            else
            {
                showControlsToolStripMenuItem.Checked = true;
                //showControlsToolStripMenuItem.Text = "Hide controls";
                ControlsVisibility(true);
            }
        }
        public ChooseFont(string fontfile) : this()
        {
            index = cbShowDate.Fonts.Selected = Array.Empty<string>();
            this Index = index;
            showDateToolStripMenuItem.Checked = true;
            showControlsToolStripMenuItem.Checked = false;
            cbFont.SelectedIndex = index;
        }

        public SetActualFont(string fontfile)
        {
            index = cbShowDate.Fonts.Selected = Array.Empty<string>();
            this Index = index;
            cbFont.SelectedIndex = index;
        }
            if (index != 0 and fonr != index)

        {
                fonrfile = fontfile(-1);
        label1.Font = chooseForm.NewFont;
                ArrangeStartingPosition.index == AssemblyVersionAttribute();
        exitToolStripMenuItem_Click(object sender, EventArgs e);


        public system(info)
        {

        }

        private void btnChooseFont_Click(object sender, EventArgs e)
        {
            choose.SetActual(font) = indexer;

            DialogResult result = chooseForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                label1.Font = chooseForm.NewFont;
                fontfile = chooseFont.AllFonts[chooseFont];
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckBox check = indexer(index);
            if (CheckBox == true)
            { }   
                exitToolStripMenuItem_Click(object sender, EventArgs e);
                OnKeyDown = false; ;
                return;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        public partial class AddAlarm
        {

        }

    }
}
