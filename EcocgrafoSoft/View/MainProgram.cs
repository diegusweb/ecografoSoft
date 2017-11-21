using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcocgrafoSoft.View
{
    public partial class MainProgram : Form
    {
        EcoLayout ecoLayout;

        public MainProgram()
        {
            InitializeComponent();


            ecoLayout = new EcoLayout(0);
            ecoLayout.EcoLayout_Load(ecoLayout, EventArgs.Empty);

            this.Controls.Add(ecoLayout);
            ecoLayout.Dock = DockStyle.Fill;
            // OnResize(null, null);

        }
    }
}
