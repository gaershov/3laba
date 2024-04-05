
namespace CompGraph.View
{
    partial class MatrixOperations
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
            this.RezultSubtractionButton = new System.Windows.Forms.Button();
            this.RezultOfAdditionButton = new System.Windows.Forms.Button();
            this.SaveInFileButton = new System.Windows.Forms.Button();
            this.ResultMultiplicationButton = new System.Windows.Forms.Button();
            this.InputSecondMatrixButton = new System.Windows.Forms.Button();
            this.InputFirstMatrixButton = new System.Windows.Forms.Button();
            this.DimensionMatrixTexBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RezultSubtractionButton);
            this.panel1.Controls.Add(this.RezultOfAdditionButton);
            this.panel1.Controls.Add(this.SaveInFileButton);
            this.panel1.Controls.Add(this.ResultMultiplicationButton);
            this.panel1.Controls.Add(this.InputSecondMatrixButton);
            this.panel1.Controls.Add(this.InputFirstMatrixButton);
            this.panel1.Controls.Add(this.DimensionMatrixTexBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NLabel);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 585);
            this.panel1.TabIndex = 19;
            // 
            // RezultSubtractionButton
            // 
            this.RezultSubtractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RezultSubtractionButton.Location = new System.Drawing.Point(35, 398);
            this.RezultSubtractionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RezultSubtractionButton.Name = "RezultSubtractionButton";
            this.RezultSubtractionButton.Size = new System.Drawing.Size(397, 75);
            this.RezultSubtractionButton.TabIndex = 28;
            this.RezultSubtractionButton.Text = "Результат Вычитания";
            this.RezultSubtractionButton.UseVisualStyleBackColor = true;
            this.RezultSubtractionButton.Click += new System.EventHandler(this.RezultSubtractionButton_Click);
            // 
            // RezultOfAdditionButton
            // 
            this.RezultOfAdditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RezultOfAdditionButton.Location = new System.Drawing.Point(35, 315);
            this.RezultOfAdditionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RezultOfAdditionButton.Name = "RezultOfAdditionButton";
            this.RezultOfAdditionButton.Size = new System.Drawing.Size(397, 75);
            this.RezultOfAdditionButton.TabIndex = 27;
            this.RezultOfAdditionButton.Text = "Результат Сложения";
            this.RezultOfAdditionButton.UseVisualStyleBackColor = true;
            this.RezultOfAdditionButton.Click += new System.EventHandler(this.RezultOfAdditionButton_Click);
            // 
            // SaveInFileButton
            // 
            this.SaveInFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveInFileButton.Location = new System.Drawing.Point(35, 481);
            this.SaveInFileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveInFileButton.Name = "SaveInFileButton";
            this.SaveInFileButton.Size = new System.Drawing.Size(397, 75);
            this.SaveInFileButton.TabIndex = 25;
            this.SaveInFileButton.Text = "Сохранить в файле “Res_Matr.txt";
            this.SaveInFileButton.UseVisualStyleBackColor = true;
            this.SaveInFileButton.Click += new System.EventHandler(this.SaveInFileButton_Click);
            // 
            // ResultMultiplicationButton
            // 
            this.ResultMultiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultMultiplicationButton.Location = new System.Drawing.Point(35, 232);
            this.ResultMultiplicationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultMultiplicationButton.Name = "ResultMultiplicationButton";
            this.ResultMultiplicationButton.Size = new System.Drawing.Size(397, 75);
            this.ResultMultiplicationButton.TabIndex = 26;
            this.ResultMultiplicationButton.Text = "Результат Умножения";
            this.ResultMultiplicationButton.UseVisualStyleBackColor = true;
            this.ResultMultiplicationButton.Click += new System.EventHandler(this.ResultMultiplicationButton_Click);
            // 
            // InputSecondMatrixButton
            // 
            this.InputSecondMatrixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputSecondMatrixButton.Location = new System.Drawing.Point(34, 159);
            this.InputSecondMatrixButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputSecondMatrixButton.Name = "InputSecondMatrixButton";
            this.InputSecondMatrixButton.Size = new System.Drawing.Size(275, 65);
            this.InputSecondMatrixButton.TabIndex = 24;
            this.InputSecondMatrixButton.Text = "Ввод Матрицы 2";
            this.InputSecondMatrixButton.UseVisualStyleBackColor = true;
            this.InputSecondMatrixButton.Click += new System.EventHandler(this.InputSecondMatrixButton_Click);
            // 
            // InputFirstMatrixButton
            // 
            this.InputFirstMatrixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputFirstMatrixButton.Location = new System.Drawing.Point(35, 86);
            this.InputFirstMatrixButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputFirstMatrixButton.Name = "InputFirstMatrixButton";
            this.InputFirstMatrixButton.Size = new System.Drawing.Size(275, 65);
            this.InputFirstMatrixButton.TabIndex = 23;
            this.InputFirstMatrixButton.Text = "Ввод Матрицы 1";
            this.InputFirstMatrixButton.UseVisualStyleBackColor = true;
            this.InputFirstMatrixButton.Click += new System.EventHandler(this.InputFirstMatrixButton_Click);
            // 
            // DimensionMatrixTexBox
            // 
            this.DimensionMatrixTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DimensionMatrixTexBox.Location = new System.Drawing.Point(103, 17);
            this.DimensionMatrixTexBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DimensionMatrixTexBox.Name = "DimensionMatrixTexBox";
            this.DimensionMatrixTexBox.Size = new System.Drawing.Size(328, 45);
            this.DimensionMatrixTexBox.TabIndex = 22;
            this.DimensionMatrixTexBox.Leave += new System.EventHandler(this.DimensionMatrixTexBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(317, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 39);
            this.label3.TabIndex = 21;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(318, 97);
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
            // MatrixOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MatrixOperations";
            this.Size = new System.Drawing.Size(503, 593);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RezultSubtractionButton;
        private System.Windows.Forms.Button RezultOfAdditionButton;
        private System.Windows.Forms.Button SaveInFileButton;
        private System.Windows.Forms.Button ResultMultiplicationButton;
        private System.Windows.Forms.Button InputSecondMatrixButton;
        private System.Windows.Forms.Button InputFirstMatrixButton;
        private System.Windows.Forms.TextBox DimensionMatrixTexBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NLabel;
    }
}
