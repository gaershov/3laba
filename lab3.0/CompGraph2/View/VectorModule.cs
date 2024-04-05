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
    public partial class VectorModule : UserControl
    {
        const int MaxN = 10; // максимально допустимая размерность
        int n = 3; // текущая размерность

        TextBox[] VectorText = null; // Вектор элементов типа TextBox
        double[] Vector = new double[MaxN]; // Вектор чисел с плавающей точкой

        bool f1; // флажок, который указывает о вводе данных в вектор

        int dx = 40, dy = 20; // ширина и высота ячейки в VectorText[] inputVector

        InputMatrix inputVector = null; // экземпляр (объект) класса формы inputMatrix

        private void Clear_VectorText()
        {
            // Обнуление ячеек VectorText
            for (int i = 0; i < n; i++)
                VectorText[i].Text = "0";
        }

        private void DimensionVectorTexBox_Leave(object sender, EventArgs e)
        {
            int nn;
            nn = Int16.Parse(DimensionVectorTexBox.Text);
            if (nn != n)
            {
                f1 = false;
                label2.Text = "false";
            }
        }

        private void InputVectorButton_Click(object sender, EventArgs e)
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
                VectorText[i].TabIndex = i * n + 1; //Проверить потом

                // 3.2. Сделать ячейку видимой
                VectorText[i].Visible = true;
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
                for (int i = 0; i < n; i++)
                    if (VectorText[i].Text != "")
                        Vector[i] = Double.Parse(VectorText[i].Text);
                    else
                        Vector[i] = 0;

                // 8. Данные в матрицу Matr1 внесены
                f1 = true;
                label2.Text = "true";
            }
        }

        private void ResultModuleButton_Click(object sender, EventArgs e)
        {
            // 1. Проверка
            if (!(f1 == true)) return;

            double module = 0; //Модуль

            // 2. Вычисление модуля
            for (int i = 0; i < n; i++)
            {
                module += Vector[i] * Vector[i];
            }
            module = Math.Sqrt(module);

            // 3. Вывод на экран
            label1.Text = module.ToString("0.######");
            label1.Visible = true;


        }

        public VectorModule()
        {
            InitializeComponent();
            // І. Инициализация элементов управления и внутренних переменных
            DimensionVectorTexBox.Text = "";
            label1.Visible = false;

            f1 = false; // Вектор не заполнен
            label2.Text = "false";

            // ІІ. Выделение памяти и настройка MatrText
            int i;

            // 1. Выделение памяти для формы inputMatrix
            inputVector = new InputMatrix();

            // 2. Выделение памяти под самую матрицу
            VectorText = new TextBox[MaxN];

            // 3. Выделение памяти для каждой ячейки матрицы и ее настройка
            for (i = 0; i < MaxN; i++)
            {
                // 3.1. Выделить память
                VectorText[i] = new TextBox();

                // 3.2. Обнулить эту ячейку
                VectorText[i].Text = "0";

                // 3.3. Установить позицию ячейки в форме inputMatrix
                VectorText[i].Location = new System.Drawing.Point(10 + i * dx, 10);

                // 3.4. Установить размер ячейки
                VectorText[i].Size = new System.Drawing.Size(dx, dy);

                // 3.5. Пока что спрятать ячейку
                VectorText[i].Visible = false;

                // 3.6. Добавить MatrText[i,j] в форму inputMatrix
                inputVector.Controls.Add(VectorText[i]);
            }
        }

    }
}
