using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompGraph.View;



namespace CompGraph
{
    public partial class LabFirstForm : Form
    {


        private void LabFirstForm_Load(object sender, EventArgs e)
        {
            MatrixOperations мatrixOperations = new MatrixOperations();
            мatrixOperations.Dock = DockStyle.Fill;            
            TabControl.TabPages[0].Controls.Add(мatrixOperations);
            VectorModule vectorModule = new VectorModule();
            vectorModule.Dock = DockStyle.Fill;
            TabControl.TabPages[1].Controls.Add(vectorModule);
            MatrixTransposition matrixTransposition = new MatrixTransposition();
            matrixTransposition.Dock = DockStyle.Fill;
            TabControl.TabPages[2].Controls.Add(matrixTransposition);

        }

        public LabFirstForm()
        {
            InitializeComponent();
        }


    }

}
