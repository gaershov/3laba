
namespace CompGraph.View
{
    partial class MatrixTransposition
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveInFileButton = new System.Windows.Forms.Button();
            this.ResultTranspositionButton = new System.Windows.Forms.Button();
            this.InputFirstMatrixButton = new System.Windows.Forms.Button();
            this.DimensionNMatrixTexBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveInFileButton);
            this.panel1.Controls.Add(this.ResultTranspositionButton);
            this.panel1.Controls.Add(this.InputFirstMatrixButton);
            this.panel1.Controls.Add(this.DimensionNMatrixTexBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NLabel);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 333);
            this.panel1.TabIndex = 20;
            // 
            // SaveInFileButton
            // 
            this.SaveInFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveInFileButton.Location = new System.Drawing.Point(35, 226);
            this.SaveInFileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveInFileButton.Name = "SaveInFileButton";
            this.SaveInFileButton.Size = new System.Drawing.Size(397, 75);
            this.SaveInFileButton.TabIndex = 25;
            this.SaveInFileButton.Text = "Сохранить в файле “Trans_Matr.txt";
            this.SaveInFileButton.UseVisualStyleBackColor = true;
            this.SaveInFileButton.Click += new System.EventHandler(this.SaveInFileButton_Click);
            // 
            // ResultTranspositionButton
            // 
            this.ResultTranspositionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTranspositionButton.Location = new System.Drawing.Point(35, 144);
            this.ResultTranspositionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultTranspositionButton.Name = "ResultTranspositionButton";
            this.ResultTranspositionButton.Size = new System.Drawing.Size(397, 75);
            this.ResultTranspositionButton.TabIndex = 26;
            this.ResultTranspositionButton.Text = "Результат Транспонирования";
            this.ResultTranspositionButton.UseVisualStyleBackColor = true;
            this.ResultTranspositionButton.Click += new System.EventHandler(this.ResultTranspositionButton_Click);
            // 
            // InputFirstMatrixButton
            // 
            this.InputFirstMatrixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputFirstMatrixButton.Location = new System.Drawing.Point(35, 71);
            this.InputFirstMatrixButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputFirstMatrixButton.Name = "InputFirstMatrixButton";
            this.InputFirstMatrixButton.Size = new System.Drawing.Size(275, 65);
            this.InputFirstMatrixButton.TabIndex = 23;
            this.InputFirstMatrixButton.Text = "Ввод Матрицы 1";
            this.InputFirstMatrixButton.UseVisualStyleBackColor = true;
            this.InputFirstMatrixButton.Click += new System.EventHandler(this.InputFirstMatrixButton_Click);
            // 
            // DimensionNMatrixTexBox
            // 
            this.DimensionNMatrixTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DimensionNMatrixTexBox.Location = new System.Drawing.Point(103, 17);
            this.DimensionNMatrixTexBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DimensionNMatrixTexBox.Name = "DimensionNMatrixTexBox";
            this.DimensionNMatrixTexBox.Size = new System.Drawing.Size(328, 45);
            this.DimensionNMatrixTexBox.TabIndex = 22;
            this.DimensionNMatrixTexBox.Leave += new System.EventHandler(this.DimensionNMatrixTexBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(317, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 39);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            // 
            // NLabel
            // 
            this.NLabel.AutoSize = true;
            this.NLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NLabel.Location = new System.Drawing.Point(27, 17);
            this.NLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(80, 39);
            this.NLabel.TabIndex = 19;
            this.NLabel.Text = "N = ";
            // 
            // MatrixTransposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MatrixTransposition";
            this.Size = new System.Drawing.Size(484, 341);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveInFileButton;
        private System.Windows.Forms.Button ResultTranspositionButton;
        private System.Windows.Forms.Button InputFirstMatrixButton;
        private System.Windows.Forms.TextBox DimensionNMatrixTexBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NLabel;
    }
}
