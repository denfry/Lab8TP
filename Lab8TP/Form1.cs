using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8TP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем значения от пользователя
            double baseSide1 = Convert.ToDouble(textBoxBaseSide1.Text);
            double height1 = Convert.ToDouble(textBoxHeight1.Text);
            double baseSide2 = Convert.ToDouble(textBoxBaseSide2.Text);
            double height2 = Convert.ToDouble(textBoxHeight2.Text);

            // Создаем два объекта класса TrianglePyramid
            TrianglePyramid pyramid1 = new TrianglePyramid(baseSide1, height1);
            TrianglePyramid pyramid2 = new TrianglePyramid(baseSide2, height2);

            // Выполняем операции и выводим результаты
            TrianglePyramid result;

            switch (comboBoxOperation.SelectedItem.ToString())
            {
                case "-":
                    result = pyramid1 - pyramid2;
                    break;
                case "*":
                    result = pyramid1 * pyramid2.height;
                    break;
                case "/":
                    double divisor = Convert.ToDouble(textBoxDivisor.Text);
                    result = pyramid1 / divisor;
                    break;
                case "==":
                    MessageBox.Show((pyramid1 == pyramid2).ToString());
                    return;
                case "!=":
                    MessageBox.Show((pyramid1 != pyramid2).ToString());
                    return;
                default:
                    MessageBox.Show("Invalid operation selected.");
                    return;
            }

            MessageBox.Show(result.ToString(), "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxBaseSide1.Text = "";
            textBoxBaseSide2.Text = "";
            textBoxHeight1.Text = "";
            textBoxHeight2.Text = "";
            textBoxDivisor.Text = "";
        }
    }
}
