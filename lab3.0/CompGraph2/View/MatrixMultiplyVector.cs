using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompGraph.View
{
    public partial class MatrixMultiplyVector : UserControl
    {
        const int MaxN = 4; // максимально допустимая размерность матрицы
        int n = 3; // текущая размерность матрицы
        TextBox[,] MatrText = null; // матрица элементов типа TextBox
        double[,] Matr1 = new double[MaxN, MaxN]; // матрица 1 чисел с плавающей точкой

        TextBox[] VectorText = null; // Вектор элементов типа TextBox
        double[] Vector = new double[MaxN]; // Вектор чисел с плавающей точкой

        double[,] MatrResult = new double[MaxN, MaxN]; // матрица результатов

        bool f1; // флажок, который указывает о вводе данных в матрицу Matr1
        bool f2; // флажок, который указывает о вводе данных в матрицу Matr2

        int dx = 40, dy = 20; // ширина и высота ячейки в MatrText[,] inputMatrix

        InputMatrix inputMatrix = null; // экземпляр (объект) класса формы inputMatrix
        InputMatrix inputVector = null; // экземпляр (объект) класса формы inputMatrix
        public MatrixMultiplyVector()
        {
            InitializeComponent();

            // І. Инициализация элементов управления и внутренних переменных
            DimensionMatrixTexBox.Text = "";

            f1 = f2 = false; // матрицы еще не заполнены
            label2.Text = "false";
            label3.Text = "false";

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
            // І. Инициализация элементов управления и внутренних переменных
            DimensionMatrixTexBox.Text = "";
            label3.Visible = false;

            // ІІ. Выделение памяти и настройка MatrText
            int k;

            // 1. Выделение памяти для формы inputMatrix
            inputVector = new InputMatrix();

            // 2. Выделение памяти под самую матрицу
            VectorText = new TextBox[MaxN];

            // 3. Выделение памяти для каждой ячейки матрицы и ее настройка
            for (k = 0; k < MaxN; k++)
            {
                // 3.1. Выделить память
                VectorText[k] = new TextBox();

                // 3.2. Обнулить эту ячейку
                VectorText[k].Text = "0";

                // 3.3. Установить позицию ячейки в форме inputMatrix
                VectorText[k].Location = new System.Drawing.Point(10 + k * dx, 10);

                // 3.4. Установить размер ячейки
                VectorText[k].Size = new System.Drawing.Size(dx, dy);

                // 3.5. Пока что спрятать ячейку
                VectorText[k].Visible = false;

                // 3.6. Добавить MatrText[i,j] в форму inputMatrix
                inputVector.Controls.Add(VectorText[k]);
            }
        }
        private void Clear_MatrText()
        {
            // Обнуление ячеек MatrText
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    MatrText[i, j].Text = "0";
        }
        private void Clear_VectorText()
        {
            // Обнуление ячеек VectorText
            for (int k = 0; k < n; k++)
                VectorText[k].Text = "0";
        }
        private void DimensionMatrixTexBox_Leave(object sender, EventArgs e)
        {
            int nn;
            nn = Int16.Parse(DimensionMatrixTexBox.Text);
            if (nn != n)
            {
                f1 = f2 = false;
                label2.Text = "false";
                label3.Text = "false";
            }
        }
        private void InputVectorButton_Click(object sender, EventArgs e)
        {
            // 1. Чтение размерности матрицы
            if (DimensionMatrixTexBox.Text == "") return;
            n = int.Parse(DimensionMatrixTexBox.Text);

            // 2. Обнуление ячейки MatrText
            Clear_VectorText();

            // 3. Настройка свойств ячеек матрицы MatrText
            //с привязкой к значению n и форме Form2
            for (int k = 0; k < n; k++)
            {
                // 3.1. Порядок табуляции
                VectorText[k].TabIndex = k * n + 1; //Проверить потом

                // 3.2. Сделать ячейку видимой
                VectorText[k].Visible = true;
            }

            // 4. Корректировка размеров формы
            inputVector.Width = 10 + n * dx + 20;
            inputVector.Height = 10 + 20 + 20 + inputVector.button1.Height + 50;

            // 5. Корректировка позиции и размеров кнопки на форме inputMatrix
            inputVector.button1.Left = 10;
            inputVector.button1.Top = 10 + 20 + 10;
            inputVector.button1.Width = inputVector.Width - 30;

            // 6. Вызов формы inputMatrix
            if (inputVector.ShowDialog() == DialogResult.OK)
            {
                // 7. Перенос строк из формы inputMatrix в матрицу Matr1
                for (int k = 0; k < n; k++)
                    if (VectorText[k].Text != "")
                        Vector[k] = Double.Parse(VectorText[k].Text);
                    else
                        Vector[k] = 0;

                // 8. Данные в матрицу Matr1 внесены
                f2 = true;
                label3.Text = "true";
            }
        }
        private void InputMatrixButton_Click(object sender, EventArgs e)
        {
            // 1. Чтение размерности матрицы
            if (DimensionMatrixTexBox.Text == "") return;
            n = int.Parse(DimensionMatrixTexBox.Text);

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
        private void ResultMultiplicationButton_Click(object sender, EventArgs e)
        {
            // 1. Проверка, введены ли данные
            if (!((f1 == true) && (f2 == true))) return;

            // 2. Вычисление произведения матрицы на вектор. Результат в MatrResult
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    MatrResult[j, i] = 0;
                    for (int k = 0; k < n; k++)
                        MatrResult[j, i] = MatrResult[j, i] + Matr1[k, i] * Vector[j];
                }

            // 3. Внесение данных в MatrText
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    // 3.1. Порядок табуляции
                    MatrText[i, j].TabIndex = i * n + j + 1;
                    // 3.2. Перевести число в строку
                    MatrText[i, j].Text = MatrResult[i, j].ToString();
                }

            // 4. Вывод формы
            inputMatrix.ShowDialog();
        }
    }
}
