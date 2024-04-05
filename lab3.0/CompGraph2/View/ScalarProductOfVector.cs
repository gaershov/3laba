using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompGraph.View
{
    public partial class ScalarProductOfVector : UserControl
    {
        const int MaxN = 4; // максимально допустимая размерность
        int n = 3; // текущая размерность

        TextBox[] VectorText1 = null; // Вектор элементов типа TextBox
        double[] Vector1 = new double[MaxN]; // Вектор1 чисел с плавающей точкой

        TextBox[] VectorText2 = null;
        double[] Vector2 = new double[MaxN]; // Вектор2 чисел с плавающей точкой

        bool f1; // флажок, который указывает о вводе данных в первый вектор
        bool f2; // флажок, который указывает о вводе данных во второй вектор

        int dx = 40, dy = 20; // ширина и высота ячейки в VectorText[] inputVector

        InputMatrix inputVector1 = null; // экземпляр (объект) класса формы inputMatrix
        InputMatrix inputVector2 = null;
        private void Clear_VectorText()
        {
            // Обнуление ячеек VectorText1 и VectorText2
            for (int i = 0; i < n; i++)
            {
                VectorText1[i].Text = "0";
                VectorText2[i].Text = "0";
            }
        }

        private void DimensionVectorTexBox_Leave(object sender, EventArgs e)
        {
            int nn;
            nn = Int16.Parse(DimensionVectorTexBox.Text);
            if (nn != n)
            {
                f1 = false;
                f2 = false;
                label2.Text = "false";
                label4.Text = "false";
            }
        }

        private void InputVectorButton1_Click(object sender, EventArgs e)
        {
            // 1. Чтение размерности матрицы
            if (DimensionVectorTexBox.Text == "") return;
            n = int.Parse(DimensionVectorTexBox.Text);

            // 2. Обнуление ячейки MatrText
            Clear_VectorText();

            // 3. Настройка свойств ячеек матрицы MatrText
            //с привязкой к значению n и форме Form2
            for (int i = 0; i < n; i++)
            {
                // 3.1. Порядок табуляции
                VectorText1[i].TabIndex = i * n + 1; //Проверить потом

                // 3.2. Сделать ячейку видимой
                VectorText1[i].Visible = true;
            }

            // 4. Корректировка размеров формы
            inputVector1.Width = 10 + n * dx + 20;
            inputVector1.Height = 10 + 20 + 20 + inputVector1.button1.Height + 50;

            // 5. Корректировка позиции и размеров кнопки на форме inputMatrix
            inputVector1.button1.Left = 10;
            inputVector1.button1.Top = 10 + 20 + 10;
            inputVector1.button1.Width = inputVector1.Width - 30;

            // 6. Вызов формы inputMatrix
            if (inputVector1.ShowDialog() == DialogResult.OK)
            {
                // 7. Перенос строк из формы inputMatrix в матрицу Matr1
                for (int i = 0; i < n; i++)
                    if (VectorText1[i].Text != "")
                        Vector1[i] = Double.Parse(VectorText1[i].Text);
                    else
                        Vector1[i] = 0;

                // 8. Данные в матрицу Matr1 внесены
                f1 = true;
                label4.Text = "true";
            }
        }

        private void InputVectorButton2_Click(object sender, EventArgs e)
        {

            // 1. Чтение размерности матрицы
            if (DimensionVectorTexBox.Text == "") return;
            n = int.Parse(DimensionVectorTexBox.Text);

            // 2. Обнуление ячейки MatrText
            Clear_VectorText();

            // 3. Настройка свойств ячеек матрицы MatrText
            //с привязкой к значению n и форме Form2
            for (int i = 0; i < n; i++)
            {
                // 3.1. Порядок табуляции
                VectorText2[i].TabIndex = i * n + 1; //Проверить потом

                // 3.2. Сделать ячейку видимой
                VectorText2[i].Visible = true;
            }

            // 4. Корректировка размеров формы
            inputVector2.Width = 10 + n * dx + 20;
            inputVector2.Height = 10 + 20 + 20 + inputVector2.button1.Height + 50;

            // 5. Корректировка позиции и размеров кнопки на форме inputMatrix
            inputVector2.button1.Left = 10;
            inputVector2.button1.Top = 10 + 20 + 10;
            inputVector2.button1.Width = inputVector2.Width - 30;

            // 6. Вызов формы inputMatrix
            if (inputVector2.ShowDialog() == DialogResult.OK)
            {
                // 7. Перенос строк из формы inputMatrix в матрицу Matr1
                for (int i = 0; i < n; i++)
                    if (VectorText2[i].Text != "")
                        Vector2[i] = Double.Parse(VectorText2[i].Text);
                    else
                        Vector2[i] = 0;

                // 8. Данные в матрицу Matr1 внесены
                f2 = true;
                label2.Text = "true";
            }
        }

        private void ResultScolarButton_Click(object sender, EventArgs e)
        {
            if (!(f1 && f2))
            {
                label1.Text = "Необходимо правильно заполнить оба вектора.";
                return;
            }

            double scalarProduct = 0;
            for (int i = 0; i < n; i++)
            {
                scalarProduct += Vector1[i] * Vector2[i];
            }

            label1.Text = scalarProduct.ToString("0.######");
            label1.Visible = true;
        }
        public ScalarProductOfVector()
        {
            InitializeComponent();
            // І. Инициализация элементов управления и внутренних переменных
            DimensionVectorTexBox.Text = "";
            label1.Visible = false;

            f1 = false; // Вектор не заполнен
            label2.Text = "false";

            f2 = false; // Вектор не заполнен
            label4.Text = "false";

            // ІІ. Выделение памяти и настройка MatrText
            int i;

            // 1. Выделение памяти для формы inputMatrix
            inputVector1 = new InputMatrix();
            inputVector2 = new InputMatrix();

            // 2. Выделение памяти под самую матрицу
            VectorText1 = new TextBox[MaxN];
            VectorText2 = new TextBox[MaxN];

            // 3. Выделение памяти для каждой ячейки матрицы и ее настройка
            for (i = 0; i < MaxN; i++)
            {
                // 3.1. Выделить память
                VectorText1[i] = new TextBox();
                VectorText2[i] = new TextBox();

                // 3.2. Обнулить эту ячейку
                VectorText1[i].Text = "0";
                VectorText2[i].Text = "0";

                // 3.3. Установить позицию ячейки в форме inputMatrix
                VectorText1[i].Location = new System.Drawing.Point(10 + i * dx, 10);
                VectorText2[i].Location = new System.Drawing.Point(10 + i * dx, 10);

                // 3.4. Установить размер ячейки
                VectorText1[i].Size = new System.Drawing.Size(dx, dy);
                VectorText2[i].Size = new System.Drawing.Size(dx, dy);

                // 3.5. Пока что спрятать ячейку
                VectorText1[i].Visible = false;
                VectorText2[i].Visible = false;

                // 3.6. Добавить MatrText[i,j] в форму inputMatrix
                inputVector1.Controls.Add(VectorText1[i]);
                inputVector2.Controls.Add(VectorText2[i]);
            }
        }
    }
}
