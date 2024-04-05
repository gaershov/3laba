using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
namespace CompGraph.View
{
    public partial class MatrixMultiConst : UserControl
    {
        const int MaxN = 4;
        System.Windows.Forms.TextBox[,] MatrText = null;
        double[,] Matr1 = new double[MaxN, MaxN];
        double[,] Matr3 = new double[MaxN, MaxN];
        bool f1;
        bool f2;
        int dx = 40, dy = 20;
        InputMatrix form2 = null;
        private int _number_of_lines;
        private int _number_of_columns;
        private double _const;

        public MatrixMultiConst()
        {
            InitializeComponent();
            f1 = f2 = false;
            label_f1.Text = "false";
            label_f2.Text = "false";
            // ІІ. Выделение памяти и настройка MatrText
            int i, j;
            // 1. Выделение памяти для формы Form2
            form2 = new InputMatrix();
            // 2. Выделение памяти под самую матрицу
            MatrText = new System.Windows.Forms.TextBox[MaxN, MaxN];
            // 3. Выделение памяти для каждой ячейки матрицы и ее настройка
            for (i = 0; i < MaxN; i++)
                for (j = 0; j < MaxN; j++)
                {
                    // 3.1. Выделить память
                    MatrText[i, j] = new System.Windows.Forms.TextBox();
                    // 3.2. Обнулить эту ячейку
                    MatrText[i, j].Text = "0";
                    // 3.3. Установить позицию ячейки в форме Form2
                    MatrText[i, j].Location = new System.Drawing.Point(10 + i *
               dx, 10 + j * dy);
                    // 3.4. Установить размер ячейки
                    MatrText[i, j].Size = new System.Drawing.Size(dx, dy);
                    // 3.5. Пока что спрятать ячейку
                    MatrText[i, j].Visible = false;
                    // 3.6. Добавить MatrText[i,j] в форму form2
                    form2.Controls.Add(MatrText[i, j]);
                }

        }

        private void Clear_MatrText()
        {
            _number_of_columns = int.Parse(textBox_BNumber.Text);
            _number_of_lines = int.Parse(textBox_ANumber.Text);
            // Обнуление ячеек MatrText
            for (int i = 0; i < MaxN; i++)
                for (int j = 0; j < MaxN; j++)
                    MatrText[i, j].Text = "0";
        }


        private void button_EnterMatrix_Click(object sender, EventArgs e)
        {
            
            try
            {

                // 1. Чтение размерности матрицы

                if (textBox_ANumber.Text == "" || textBox_BNumber.Text == "")
                {
                    throw new Exception("Check your value");
                }
                
                // 2. Обнуление ячейки MatrText
                Clear_MatrText();
                _number_of_columns = int.Parse(textBox_BNumber.Text);
                _number_of_lines = int.Parse(textBox_ANumber.Text);
                // 3. Настройка свойств ячеек матрицы MatrText
                //    с привязкой к значению n и форме Form2
                for (int i = 0; i < _number_of_lines; i++)
                    for (int j = 0; j < _number_of_columns; j++)
                    {
                        // 3.1. Порядок табуляции
                        MatrText[i, j].TabIndex = i * _number_of_lines + j + 1;
                        // 3.2. Сделать ячейку видимой
                        MatrText[i, j].Visible = true;
                    }
                // 4. Корректировка размеров формы
                form2.Width = 10 + MaxN * dx + 20;
                form2.Height = 10 + MaxN * dy + form2.button1.Height + 50;
                // 5. Корректировка позиции и размеров кнопки на форме Form2 form2.button1.Left = 10;
                form2.button1.Top = 10 + MaxN * dy + 10;
                form2.button1.Width = form2.Width - 30;
                // 6. Вызов формы Form2
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    // 7. Перенос строк из формы Form2 в матрицу Matr1
                    for (int i = 0; i < _number_of_lines; i++)
                        for (int j = 0; j < _number_of_columns; j++)
                            if (MatrText[i, j].Text != "")
                                Matr1[i, j] = Double.Parse(MatrText[i, j].Text);
                            else
                                Matr1[i, j] = 0;
                    // 8. Данные в матрицу Matr1 внесены

                    f1 = true;
                    label_f1.Text = "true";
                }
            }
            catch(Exception ex)
            {
                label_ErrorMatrix.Text = ex.Message;
                label_ErrorMatrix.Visible = true;
            }
        }

        private void button_Multi_Click(object sender, EventArgs e)
        {
            
            if (!((f1 == true) || !(f2 == true))) return;
            _const = double.Parse(textBox_Const.Text);
            _number_of_columns = int.Parse(textBox_BNumber.Text);
            _number_of_lines = int.Parse(textBox_ANumber.Text);
            // 2. Вычисление произведения матриц. Результат в Matr3
            for (int i = 0; i < _number_of_lines; i++)
                for (int j = 0; j < _number_of_columns; j++)
                {
                    Matr3[i, j] = Matr1[i, j] * _const;

                }
            
            // 3. Внесение данных в MatrText
            for (int i = 0; i < _number_of_lines; i++)
                for (int j = 0; j < _number_of_columns; j++)
                {
                    // 3.1. Порядок табуляции
                    MatrText[i, j].TabIndex = i * _number_of_lines + j + 1;
                    // 3.2. Перевести число в строку
                    MatrText[i, j].Text = Matr3[i, j].ToString();
                }
            // 4. Вывод формы
            form2.ShowDialog();
        }

        private void button_SaveToFile_Click(object sender, EventArgs e)
        {

        }

        private void button_EnterConst_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Const.Text == "")
                {
                    throw new Exception("Check your value");
                }
                _const = double.Parse(textBox_Const.Text);
                label_f2.Text = "true";
            }
            catch(Exception ex)
            {
                label_ErrorConst.Text = ex.Message;
                label_ErrorConst.Visible = true;
            }
        }

        private void textBox_ANumber_Leave(object sender, EventArgs e)
        {
            int aa;
            _number_of_lines = int.Parse(textBox_ANumber.Text);
            
            aa = Int16.Parse(textBox_ANumber.Text);
            
            if (aa != _number_of_lines)
            {
                f1 = false;
                label_f1.Text = "false";
            }
            
        }
        private void textBox_Const_Leave(object sender, EventArgs e)
        {
            
            int cc;
            _const = double.Parse(textBox_Const.Text);
            
            cc = Int16.Parse(textBox_Const.Text);
            
            
            if (cc != _const)
            {
                f2 = false;
                label_f2.Text = "false";
            }
        }

        private void textBox_BNumber_Leave(object sender, EventArgs e)
        {
            
            int bb;
            
            
            _number_of_columns = int.Parse(textBox_BNumber.Text);
            
            
            bb = Int16.Parse(textBox_BNumber.Text);
            if ( bb != _number_of_columns)
            {
                f1 = false;
                label_f1.Text = "false";
            }
            
        }

    }
}
