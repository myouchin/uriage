﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NouhinSyo
{
    public partial class frmAsamiDenkiNouhinsyoInput : frmNouhinsyoInputBase
    {
        public frmAsamiDenkiNouhinsyoInput()
        {
            InitializeComponent();
            setContorolLayout(this);

            getPanel1().Controls.Add(panel5);
            panel5.Location = new Point(4, 174);

            this.Size = new Size(1339, 631);
        }
    }
}
