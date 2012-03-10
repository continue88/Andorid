using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameEditor.Controls
{
    public partial class AnimationPreviewPanel : DoubleBuffControl
    {
        Pen mLinePen = new Pen(Color.Black);
        SolidBrush mLineBrush = new SolidBrush(Color.Black);

        public AnimationPreviewPanel()
        {
            InitializeComponent();
        }

        public override void ForceUpdate(Graphics g)
        {
            base.ForceUpdate(g);

            g.DrawLine(mLinePen, 0.0f, Size.Height * 0.5f, Size.Width, Size.Height * 0.5f);
            g.DrawLine(mLinePen, Size.Width * 0.5f, 0, Size.Width * 0.5f, Size.Height);
        }
    }
}
