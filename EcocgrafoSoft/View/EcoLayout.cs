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
    public partial class EcoLayout : UserControl
    {
        PatientPanel patientPanel;
        public EcoLayout(int tab)
        {
            InitializeComponent();
            paymentV2Layout.SelectedIndex = tab;
        }

        public void EcoLayout_Load(object sender, EventArgs e)
        {
            TabControl parentForm = (sender as TabControl);

            if (patientPanel == null) {
                patientPanel = new PatientPanel("MY PATIENT", false);
            }
        }
    }
}
