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
    public partial class VectorsMulti : UserControl
    {
        const int MaxN = 4; // максимально допустимая размерность
        int n = 3; // текущая размерность

        TextBox[] VectorText = null; // Вектор элементов типа TextBox
        double[] Vector = new double[MaxN]; // Вектор чисел с плавающей точкой
        TextBox[] VectorText2 = null; // Вектор элементов типа TextBox
        double[] Vector2 = new double[MaxN];
        bool f1; // флажок, который указывает о вводе данных в вектор
        bool f2;
        int dx = 40, dy = 20; // ширина и высота ячейки в VectorText[] inputVector

        InputMatrix inputVector = null;
        InputMatrix inputVector2 = null;// экземпляр (объект) класса формы inputMatrix
        public VectorsMulti()
        {
            InitializeComponent();
            textBox_VectorAN.Text = "";
            label_A.Visible = false;
            label_ATF.Visible = false;
            f1 = false;
            f2 = false;// Вектор не заполнен
            label_A.Text = "false";
            label_ATF.Text = "false";
            label_ATF.Visible = true;   
            label_A.Visible = true;
            // ІІ. Выделение памяти и настройка MatrText
            int i;

            // 1. Выделение памяти для формы inputMatrix
            inputVector = new InputMatrix();
            inputVector2 = new InputMatrix();

            // 2. Выделение памяти под самую матрицу
            VectorText = new TextBox[MaxN];
            VectorText2 = new TextBox[MaxN];
            // 3. Выделение памяти для каждой ячейки матрицы и ее настройка
            for (i = 0; i < MaxN; i++)
            {
                // 3.1. Выделить память
                VectorText[i] = new TextBox();
                VectorText2[i] = new TextBox();
                // 3.2. Обнулить эту ячейку
                VectorText[i].Text = "0";
                VectorText2[i].Text = "0";
                // 3.3. Установить позицию ячейки в форме inputMatrix
                VectorText[i].Location = new System.Drawing.Point(10 + i * dx, 10);
                VectorText2[i].Location = new System.Drawing.Point(10 + i * dx, 10);
                // 3.4. Установить размер ячейки
                VectorText[i].Size = new System.Drawing.Size(dx, dy);
                VectorText2[i].Size = new System.Drawing.Size(dx, dy);
                // 3.5. Пока что спрятать ячейку
                VectorText[i].Visible = false;
                VectorText2[i].Visible = false;
                // 3.6. Добавить MatrText[i,j] в форму inputMatrix
                inputVector.Controls.Add(VectorText[i]);
                inputVector2.Controls.Add(VectorText2[i]);
            }
        }
        

        private void Clear_VectorTextA()
        {
            // Обнуление ячеек VectorText
            for (int i = 0; i < n; i++)
                VectorText[i].Text = "0";
        }
        private void Clear_VectorTextB()
        {
            // Обнуление ячеек VectorText
            for (int i = 0; i < n; i++)
                VectorText2[i].Text = "0";
        }
        private void textBox_VectorAN_Leave(object sender, EventArgs e)
        {
            int nn;
            nn = Int16.Parse(textBox_VectorAN.Text);
            if (nn != n)
            {
                f1 = false;
                f2 = false;
                label_A.Text = "false";
                label_ATF.Text = "false";
            }
        }

        
        private void button_EnterVectorA_Click(object sender, EventArgs e)
        {
            if (textBox_VectorAN.Text == "") return;
            n = int.Parse(textBox_VectorAN.Text);

            // 2. Обнуление ячейки MatrText
            Clear_VectorTextA();

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
                f2 = true;
                label_ATF.Text = "true";
            }
        }

        private void button_MultiVectors_Click(object sender, EventArgs e)
        {
            // 1. Проверка
            if (!(f1 == true) || !(f2 == true)) return;

            double answer = 0; //Модуль

            // 2. Вычисление модуля
            for (int i = 0; i < n; i++)
            {
                answer += Vector[i] * Vector2[i];
            }
            
            

            // 3. Вывод на экран
            label_Answer.Text = answer.ToString("0.######");
            label_Answer.Visible = true;
        }

        

        private void button_EnterVectorB_Click_1(object sender, EventArgs e)
        {
            
            if (textBox_VectorAN.Text == "") return;
            n = int.Parse(textBox_VectorAN.Text);
            
            // 2. Обнуление ячейки MatrText
            Clear_VectorTextB();

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
                f1 = true;
                label_A.Text = "true";
            }
        }
    }
}
