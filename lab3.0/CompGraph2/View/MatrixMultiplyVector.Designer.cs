namespace CompGraph.View
{
    partial class MatrixMultiplyVector
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveInFileButton = new System.Windows.Forms.Button();
            this.ResultMultiplicationButton = new System.Windows.Forms.Button();
            this.InputVectorButton = new System.Windows.Forms.Button();
            this.InputMatrixButton = new System.Windows.Forms.Button();
            this.DimensionMatrixTexBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveInFileButton);
            this.panel1.Controls.Add(this.ResultMultiplicationButton);
            this.panel1.Controls.Add(this.InputVectorButton);
            this.panel1.Controls.Add(this.InputMatrixButton);
            this.panel1.Controls.Add(this.DimensionMatrixTexBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NLabel);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 464);
            this.panel1.TabIndex = 20;
            // 
            // SaveInFileButton
            // 
            this.SaveInFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveInFileButton.Location = new System.Drawing.Point(35, 314);
            this.SaveInFileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveInFileButton.Name = "SaveInFileButton";
            this.SaveInFileButton.Size = new System.Drawing.Size(397, 75);
            this.SaveInFileButton.TabIndex = 25;
            this.SaveInFileButton.Text = "Сохранить в файле “Res_Matr.txt";
            this.SaveInFileButton.UseVisualStyleBackColor = true;
            // 
            // ResultMultiplicationButton
            // 
            this.ResultMultiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultMultiplicationButton.Location = new System.Drawing.Point(35, 231);
            this.ResultMultiplicationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultMultiplicationButton.Name = "ResultMultiplicationButton";
            this.ResultMultiplicationButton.Size = new System.Drawing.Size(397, 75);
            this.ResultMultiplicationButton.TabIndex = 26;
            this.ResultMultiplicationButton.Text = "Результат Умножения";
            this.ResultMultiplicationButton.UseVisualStyleBackColor = true;
            this.ResultMultiplicationButton.Click += new System.EventHandler(this.ResultMultiplicationButton_Click);
            // 
            // InputVectorButton
            // 
            this.InputVectorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputVectorButton.Location = new System.Drawing.Point(34, 158);
            this.InputVectorButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputVectorButton.Name = "InputVectorButton";
            this.InputVectorButton.Size = new System.Drawing.Size(275, 65);
            this.InputVectorButton.TabIndex = 24;
            this.InputVectorButton.Text = "Ввод Вектора";
            this.InputVectorButton.UseVisualStyleBackColor = true;
            this.InputVectorButton.Click += new System.EventHandler(this.InputVectorButton_Click);
            // 
            // InputMatrixButton
            // 
            this.InputMatrixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputMatrixButton.Location = new System.Drawing.Point(35, 86);
            this.InputMatrixButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputMatrixButton.Name = "InputMatrixButton";
            this.InputMatrixButton.Size = new System.Drawing.Size(275, 65);
            this.InputMatrixButton.TabIndex = 23;
            this.InputMatrixButton.Text = "Ввод Матрицы ";
            this.InputMatrixButton.UseVisualStyleBackColor = true;
            this.InputMatrixButton.Click += new System.EventHandler(this.InputMatrixButton_Click);
            // 
            // DimensionMatrixTexBox
            // 
            this.DimensionMatrixTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DimensionMatrixTexBox.Location = new System.Drawing.Point(103, 17);
            this.DimensionMatrixTexBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DimensionMatrixTexBox.Name = "DimensionMatrixTexBox";
            this.DimensionMatrixTexBox.Size = new System.Drawing.Size(328, 45);
            this.DimensionMatrixTexBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(317, 169);
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
            // MatrixMultiplyVector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MatrixMultiplyVector";
            this.Size = new System.Drawing.Size(484, 472);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveInFileButton;
        private System.Windows.Forms.Button ResultMultiplicationButton;
        private System.Windows.Forms.Button InputVectorButton;
        private System.Windows.Forms.Button InputMatrixButton;
        private System.Windows.Forms.TextBox DimensionMatrixTexBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NLabel;
    }
}
