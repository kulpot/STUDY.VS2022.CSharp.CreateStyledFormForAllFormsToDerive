using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateStyledFormForAllFormsToDerive
{
    public partial class StyledForm : Form
    {
        private LinearGradientBrush _LGB;

        public StyledForm()
        {
            InitializeComponent();
            _LGB = new LinearGradientBrush(this.ClientRectangle, Color.Purple, Color.MediumPurple, 45f);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(_LGB, this.ClientRectangle);
        }
    }
}
