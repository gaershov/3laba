using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CompGraph.View
{
    public partial class MatrixTransposition : UserControl
    {
        const int MaxN = 10; // максимально допустимая размерность матрицы
        int n = 3; // текущая размерность матрицы 1
        int m = 3; // текущая размерность матрицы 2
        TextBox[,] MatrText = null; // матрица элементов типа TextBox
        double[,] Matr1 = new double[MaxN, MaxN]; // матрица 1 чисел с плавающей точкой
        double[,] Matr2 = new double[MaxN, MaxN]; // матрица 2 чисел с плавающей точкой        
        bool f1; // флажок, который указывает о вводе данных в матрицу Matr1        
        int dx = 40, dy = 20; // ширина и высота ячейки в MatrText[,] inputMatrix
        InputMatrix inputMatrix = null; // экземпляр (объект) класса формы inputMatrix

        public MatrixTransposition()
        {
            InitializeComponent();
            // І. Инициализация элементов управления и внутренних переменных
            DimensionNMatrixTexBox.Text = "";
            f1 = false; // матрицы еще не заполнены
            label2.Text = "false";            
            // ІІ. Выделение памяти и настройка MatrText
            int i, j;
            // 1. Выделение памяти для формы inputMatrix
            inputMatrix = new InputMatrix();
            // 2. Выделение памяти под самую матрицу
            MatrText = new TextBox[MaxN, MaxN];
            // 3. Выделение памяти для каждой ячейки матрицы и ее настройка
            for (i = 0; i < MaxN; i++)
                for (j = 0; j < MaxN; j++)
                {
                    // 3.1. Выделить память
                    MatrText[i, j] = new TextBox();
                    // 3.2. Обнулить эту ячейку
                    MatrText[i, j].Text = "0";
                    // 3.3. Установить позицию ячейки в форме inputMatrix
                    MatrText[i, j].Location = new System.Drawing.Point(10 + i * dx, 10 + j * dy);
                    // 3.4. Установить размер ячейки
                    MatrText[i, j].Size = new System.Drawing.Size(dx, dy);
                    // 3.5. Пока что спрятать ячейку
                    MatrText[i, j].Visible = false;
                    // 3.6. Добавить MatrText[i,j] в форму inputMatrix
                    inputMatrix.Controls.Add(MatrText[i, j]);
                }
        }
        private void Clear_MatrText()
        {
            // Обнуление ячеек MatrText
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    MatrText[i, j].Text = "0";
        }

        private void DimensionNMatrixTexBox_Leave(object sender, EventArgs e)
        {
            int nn;
            nn = Int16.Parse(DimensionNMatrixTexBox.Text);
            if (nn != n)
            {
                f1  = false;
                label2.Text = "false";                
            }
        }
        private void DimensionMMatrixTexBox_Leave(object sender, EventArgs e)
        { 
        }

            private void InputFirstMatrixButton_Click(object sender, EventArgs e)
        {
            // 1. Чтение размерности матрицы
            if (DimensionNMatrixTexBox.Text == "") return;
            n = int.Parse(DimensionNMatrixTexBox.Text);
            // 2. Обнуление ячейки MatrText
            Clear_MatrText();
            // 3. Настройка свойств ячеек матрицы MatrText
            // с привязкой к значению n и форме Form2
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    // 3.1. Порядок табуляции
                    MatrText[i, j].TabIndex = i * n + j + 1;
                    // 3.2. Сделать ячейку видимой
                    MatrText[i, j].Visible = true;
                }
            // 4. Корректировка размеров формы
            inputMatrix.Width = 10 + n * dx + 20;
            inputMatrix.Height = 10 + n * dy + inputMatrix.button1.Height + 50;
            // 5. Корректировка позиции и размеров кнопки на форме inputMatrix
            inputMatrix.button1.Left = 10;
            inputMatrix.button1.Top = 10 + n * dy + 10;
            inputMatrix.button1.Width = inputMatrix.Width - 30;
            // 6. Вызов формы inputMatrix
            if (inputMatrix.ShowDialog() == DialogResult.OK)
            {
                // 7. Перенос строк из формы inputMatrix в матрицу Matr1
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        if (MatrText[i, j].Text != "")
                            Matr1[i, j] = Double.Parse(MatrText[i, j].Text);
                        else
                            Matr1[i, j] = 0;
                // 8. Данные в матрицу Matr1 внесены
                f1 = true;
                label2.Text = "true";
            }
        }


        private void ResultTranspositionButton_Click(object sender, EventArgs e)
        {
            // 1. Проверка, введены ли данные в обеих матрицах
            if (!f1) return;
            // 2. Вычисление произведения матриц. Результат в Matr3
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Matr2[j, i] = 0;

                    Matr2[j, i] = Matr1[i, j];
                }
            // 3. Внесение данных в MatrText
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    // 3.1. Порядок табуляции
                    MatrText[i, j].TabIndex = i * n + j + 1;
                    // 3.2. Перевести число в строку
                    MatrText[i, j].Text = Matr2[i, j].ToString();
                }
            // 4. Вывод формы
            inputMatrix.ShowDialog();
        }

        private void SaveInFileButton_Click(object sender, EventArgs e)
        {

            FileStream fw = null;
            string msg;
            byte[] msgByte = null; // байтовый массив
            // 1. Открыть файл для записи
            fw = new FileStream("Trans_Matr.txt", FileMode.Create);
            // 2. Запись матрицы результата в файл

            // 2.1. Сначала записать число элементов матрицы Matr3
            msg = n.ToString() + "\r\n";
            // перевод строки msg в байтовый массив msgByte
            msgByte = Encoding.Default.GetBytes(msg);
            // запись массива msgByte в файл
            fw.Write(msgByte, 0, msgByte.Length);
            // 2.2. Теперь записать саму матрицу
            msg = "";
            for (int i = 0; i < n; i++)
            {
                // формируем строку msg из элементов матрицы
                for (int j = 0; j < n; j++)
                    msg = msg + Matr2[i, j].ToString() + " ";
                msg = msg + "\r\n";
                // добавить перевод строки
            }
            // 3. Перевод строки msg в байтовый массив msgByte
            msgByte = Encoding.Default.GetBytes(msg);
            // 4. запись строк матрицы в файл
            fw.Write(msgByte, 0, msgByte.Length);
            // 5. Закрыть файл
            if (fw != null) fw.Close();
        }
    }
}
