using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            try
            {
                StreetRacer streetRacer = new StreetRacer();
                FormulaOne formulaOne = new FormulaOne();
                Helicopter helicopter = new Helicopter();
                Jet jet = new Jet();

                //call
                streetRacer.go();
                formulaOne.go();
                helicopter.go();
                jet.go();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnStrategy_Click(object sender, EventArgs e)
        {
            Jet jet = new Jet();

            jet.SetAlgorithm(new GoByDrivingAlgorithm());
            jet.go();

            jet.SetAlgorithm(new GoByFlyingAlgorithm());
            jet.go();

            jet.SetAlgorithm(new GoByFlyingFastAlgorithm());
            jet.go();
        }
    }
}
