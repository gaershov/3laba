
namespace CompGraph
{
    partial class LabFirstForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.scalarProductOfVector1 = new CompGraph.View.ScalarProductOfVector();
            this.matrixTransposition1 = new CompGraph.View.MatrixTransposition();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.matrixMultiplyVector1 = new CompGraph.View.MatrixMultiplyVector();

            this.TabControl.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 

            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1216, 812);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Matrix Transposition";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1216, 812);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vector Module";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1216, 812);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Matrix Operations";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 

            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Controls.Add(this.tabPage4);
            this.TabControl.Controls.Add(this.tabPage5);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1224, 838);
            this.TabControl.TabIndex = 9;
            this.TabControl.Size = new System.Drawing.Size(986, 558);
            this.TabControl.TabIndex = 9;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.scalarProductOfVector1);
            this.tabPage4.Controls.Add(this.matrixTransposition1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1216, 812);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Scalar Product Of Vectors";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 

            // scalarProductOfVector1
            // 
            this.scalarProductOfVector1.Location = new System.Drawing.Point(8, 6);
            this.scalarProductOfVector1.Name = "scalarProductOfVector1";
            this.scalarProductOfVector1.Size = new System.Drawing.Size(722, 580);
            this.scalarProductOfVector1.TabIndex = 1;
            // 
            // matrixTransposition1
            // 
            this.matrixTransposition1.Location = new System.Drawing.Point(633, 196);
            this.matrixTransposition1.Name = "matrixTransposition1";
            this.matrixTransposition1.Size = new System.Drawing.Size(8, 8);
            this.matrixTransposition1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.matrixMultiplyVector1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1216, 812);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Marix X Vector";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // matrixMultiplyVector1
            // 
            this.matrixMultiplyVector1.Location = new System.Drawing.Point(3, 6);
            this.matrixMultiplyVector1.Name = "matrixMultiplyVector1";
            this.matrixMultiplyVector1.Size = new System.Drawing.Size(647, 804);
            this.matrixMultiplyVector1.TabIndex = 0;

            // 
            // LabFirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 838);
            this.Controls.Add(this.TabControl);
            this.Name = "LabFirstForm";
            this.Text = "LabFirst";
            this.Load += new System.EventHandler(this.LabFirstForm_Load);
            this.TabControl.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private View.VectorModule vectorModulе1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage4;
        private View.MatrixTransposition matrixTransposition1;
        private View.ScalarProductOfVector scalarProductOfVector1;
        private System.Windows.Forms.TabPage tabPage5;
        private View.MatrixMultiplyVector matrixMultiplyVector1;

    }
}

