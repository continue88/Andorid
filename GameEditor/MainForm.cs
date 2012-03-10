using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameEditor.Controls;
using GameData;

namespace GameEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Root.Instance.Init(Application.StartupPath);

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Control panel = new ImagesetPanel();
            panel.Dock = DockStyle.Fill;
            tabPageImageset.Controls.Add(panel);

            panel = new AnimationSetPanel();
            panel.Dock = DockStyle.Fill;
            tabPageAnimations.Controls.Add(panel);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Root.Instance.Shutdown();
        }
    }
}
