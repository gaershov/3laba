namespace CompGraph.View
{
    partial class MatrixMultiConst
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_SaveToFile = new System.Windows.Forms.Button();
            this.button_Multi = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_f2 = new System.Windows.Forms.Label();
            this.label_ErrorConst = new System.Windows.Forms.Label();
            this.button_EnterConst = new System.Windows.Forms.Button();
            this.textBox_Const = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_f1 = new System.Windows.Forms.Label();
            this.label_ErrorMatrix = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_EnterMatrix = new System.Windows.Forms.Button();
            this.textBox_ANumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_BNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 231);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.Controls.Add(this.button_SaveToFile);
            this.panel4.Controls.Add(this.button_Multi);
            this.panel4.Location = new System.Drawing.Point(3, 192);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 35);
            this.panel4.TabIndex = 11;
            // 
            // button_SaveToFile
            // 
            this.button_SaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SaveToFile.Location = new System.Drawing.Point(204, 3);
            this.button_SaveToFile.Name = "button_SaveToFile";
            this.button_SaveToFile.Size = new System.Drawing.Size(195, 29);
            this.button_SaveToFile.TabIndex = 12;
            this.button_SaveToFile.Text = "Save to “Res_Module.txt\"";
            this.button_SaveToFile.UseVisualStyleBackColor = true;
            this.button_SaveToFile.Click += new System.EventHandler(this.button_SaveToFile_Click);
            // 
            // button_Multi
            // 
            this.button_Multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Multi.Location = new System.Drawing.Point(3, 3);
            this.button_Multi.Name = "button_Multi";
            this.button_Multi.Size = new System.Drawing.Size(195, 29);
            this.button_Multi.TabIndex = 12;
            this.button_Multi.Text = "Matrix × Const = ...";
            this.button_Multi.UseVisualStyleBackColor = true;
            this.button_Multi.Click += new System.EventHandler(this.button_Multi_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.label_f2);
            this.panel3.Controls.Add(this.label_ErrorConst);
            this.panel3.Controls.Add(this.button_EnterConst);
            this.panel3.Controls.Add(this.textBox_Const);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(207, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 183);
            this.panel3.TabIndex = 10;
            // 
            // label_f2
            // 
            this.label_f2.AutoSize = true;
            this.label_f2.Location = new System.Drawing.Point(134, 124);
            this.label_f2.Name = "label_f2";
            this.label_f2.Size = new System.Drawing.Size(10, 13);
            this.label_f2.TabIndex = 2;
            this.label_f2.Text = ".";
            // 
            // label_ErrorConst
            // 
            this.label_ErrorConst.AutoSize = true;
            this.label_ErrorConst.Location = new System.Drawing.Point(4, 145);
            this.label_ErrorConst.Name = "label_ErrorConst";
            this.label_ErrorConst.Size = new System.Drawing.Size(0, 13);
            this.label_ErrorConst.TabIndex = 13;
            // 
            // button_EnterConst
            // 
            this.button_EnterConst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_EnterConst.Location = new System.Drawing.Point(35, 119);
            this.button_EnterConst.Name = "button_EnterConst";
            this.button_EnterConst.Size = new System.Drawing.Size(93, 23);
            this.button_EnterConst.TabIndex = 12;
            this.button_EnterConst.Text = "Enter const";
            this.button_EnterConst.UseVisualStyleBackColor = true;
            this.button_EnterConst.Click += new System.EventHandler(this.button_EnterConst_Click);
            // 
            // textBox_Const
            // 
            this.textBox_Const.Location = new System.Drawing.Point(65, 50);
            this.textBox_Const.Name = "textBox_Const";
            this.textBox_Const.Size = new System.Drawing.Size(54, 20);
            this.textBox_Const.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "const =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Const";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.label_f1);
            this.panel2.Controls.Add(this.label_ErrorMatrix);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button_EnterMatrix);
            this.panel2.Controls.Add(this.textBox_ANumber);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox_BNumber);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 183);
            this.panel2.TabIndex = 9;
            // 
            // label_f1
            // 
            this.label_f1.AutoSize = true;
            this.label_f1.Location = new System.Drawing.Point(140, 124);
            this.label_f1.Name = "label_f1";
            this.label_f1.Size = new System.Drawing.Size(10, 13);
            this.label_f1.TabIndex = 1;
            this.label_f1.Text = ".";
            // 
            // label_ErrorMatrix
            // 
            this.label_ErrorMatrix.AutoSize = true;
            this.label_ErrorMatrix.Location = new System.Drawing.Point(3, 145);
            this.label_ErrorMatrix.Name = "label_ErrorMatrix";
            this.label_ErrorMatrix.Size = new System.Drawing.Size(0, 13);
            this.label_ErrorMatrix.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrix (a, b)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "a =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "b =";
            // 
            // button_EnterMatrix
            // 
            this.button_EnterMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_EnterMatrix.Location = new System.Drawing.Point(25, 119);
            this.button_EnterMatrix.Name = "button_EnterMatrix";
            this.button_EnterMatrix.Size = new System.Drawing.Size(109, 23);
            this.button_EnterMatrix.TabIndex = 7;
            this.button_EnterMatrix.Text = "Enter matrix";
            this.button_EnterMatrix.UseVisualStyleBackColor = true;
            this.button_EnterMatrix.Click += new System.EventHandler(this.button_EnterMatrix_Click);
            // 
            // textBox_ANumber
            // 
            this.textBox_ANumber.Location = new System.Drawing.Point(37, 48);
            this.textBox_ANumber.Name = "textBox_ANumber";
            this.textBox_ANumber.Size = new System.Drawing.Size(24, 20);
            this.textBox_ANumber.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "<5";
            // 
            // textBox_BNumber
            // 
            this.textBox_BNumber.Location = new System.Drawing.Point(37, 82);
            this.textBox_BNumber.Name = "textBox_BNumber";
            this.textBox_BNumber.Size = new System.Drawing.Size(24, 20);
            this.textBox_BNumber.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "<5";
            // 
            // MatrixMultiConst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MatrixMultiConst";
            this.Size = new System.Drawing.Size(479, 352);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ANumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_BNumber;
        private System.Windows.Forms.Button button_EnterMatrix;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_Const;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_EnterConst;
        private System.Windows.Forms.Button button_Multi;
        private System.Windows.Forms.Button button_SaveToFile;
        private System.Windows.Forms.Label label_ErrorMatrix;
        private System.Windows.Forms.Label label_ErrorConst;
        private System.Windows.Forms.Label label_f2;
        private System.Windows.Forms.Label label_f1;
    }
}
