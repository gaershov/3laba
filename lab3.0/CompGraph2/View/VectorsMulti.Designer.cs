namespace CompGraph.View
{
    partial class VectorsMulti
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
            this.label_Answer = new System.Windows.Forms.Label();
            this.button_SaveToFile = new System.Windows.Forms.Button();
            this.button_MultiVectors = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_EnterVectorB = new System.Windows.Forms.Button();
            this.button_EnterVectorA = new System.Windows.Forms.Button();
            this.label_A = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_VectorAN = new System.Windows.Forms.TextBox();
            this.label_ATF = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(408, 229);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.Controls.Add(this.label_Answer);
            this.panel4.Controls.Add(this.button_SaveToFile);
            this.panel4.Controls.Add(this.button_MultiVectors);
            this.panel4.Location = new System.Drawing.Point(3, 190);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 35);
            this.panel4.TabIndex = 11;
            // 
            // label_Answer
            // 
            this.label_Answer.AutoSize = true;
            this.label_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Answer.Location = new System.Drawing.Point(168, 9);
            this.label_Answer.Name = "label_Answer";
            this.label_Answer.Size = new System.Drawing.Size(11, 16);
            this.label_Answer.TabIndex = 12;
            this.label_Answer.Text = ".";
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
            // 
            // button_MultiVectors
            // 
            this.button_MultiVectors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_MultiVectors.Location = new System.Drawing.Point(3, 3);
            this.button_MultiVectors.Name = "button_MultiVectors";
            this.button_MultiVectors.Size = new System.Drawing.Size(195, 29);
            this.button_MultiVectors.TabIndex = 12;
            this.button_MultiVectors.Text = "Vector A × Vector B = ...";
            this.button_MultiVectors.UseVisualStyleBackColor = true;
            this.button_MultiVectors.Click += new System.EventHandler(this.button_MultiVectors_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.label_ATF);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.button_EnterVectorB);
            this.panel3.Controls.Add(this.button_EnterVectorA);
            this.panel3.Controls.Add(this.label_A);
            this.panel3.Location = new System.Drawing.Point(207, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 181);
            this.panel3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vector A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vector B";
            // 
            // button_EnterVectorB
            // 
            this.button_EnterVectorB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_EnterVectorB.Location = new System.Drawing.Point(3, 106);
            this.button_EnterVectorB.Name = "button_EnterVectorB";
            this.button_EnterVectorB.Size = new System.Drawing.Size(113, 23);
            this.button_EnterVectorB.TabIndex = 20;
            this.button_EnterVectorB.Text = "Enter vector B";
            this.button_EnterVectorB.UseVisualStyleBackColor = true;
            this.button_EnterVectorB.Click += new System.EventHandler(this.button_EnterVectorB_Click_1);
            // 
            // button_EnterVectorA
            // 
            this.button_EnterVectorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_EnterVectorA.Location = new System.Drawing.Point(3, 39);
            this.button_EnterVectorA.Name = "button_EnterVectorA";
            this.button_EnterVectorA.Size = new System.Drawing.Size(113, 23);
            this.button_EnterVectorA.TabIndex = 7;
            this.button_EnterVectorA.Text = "Enter vector A";
            this.button_EnterVectorA.UseVisualStyleBackColor = true;
            this.button_EnterVectorA.Click += new System.EventHandler(this.button_EnterVectorA_Click);
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Location = new System.Drawing.Point(122, 111);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(35, 13);
            this.label_A.TabIndex = 21;
            this.label_A.Text = "label3";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_VectorAN);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 181);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "n =";
            // 
            // textBox_VectorAN
            // 
            this.textBox_VectorAN.Location = new System.Drawing.Point(36, 20);
            this.textBox_VectorAN.Name = "textBox_VectorAN";
            this.textBox_VectorAN.Size = new System.Drawing.Size(24, 20);
            this.textBox_VectorAN.TabIndex = 3;
            // 
            // label_ATF
            // 
            this.label_ATF.AutoSize = true;
            this.label_ATF.Location = new System.Drawing.Point(122, 44);
            this.label_ATF.Name = "label_ATF";
            this.label_ATF.Size = new System.Drawing.Size(35, 13);
            this.label_ATF.TabIndex = 22;
            this.label_ATF.Text = "label3";
            // 
            // VectorsMulti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "VectorsMulti";
            this.Size = new System.Drawing.Size(528, 520);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_SaveToFile;
        private System.Windows.Forms.Button button_MultiVectors;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_EnterVectorA;
        private System.Windows.Forms.TextBox textBox_VectorAN;
        private System.Windows.Forms.Button button_EnterVectorB;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Label label_Answer;
        private System.Windows.Forms.Label label_ATF;
    }
}
