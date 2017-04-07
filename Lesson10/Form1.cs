//#define TRIAL
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int number = 498635;
        }

        /// <summary>
        /// Метод: сумма двух инт чисел
        /// </summary>
        /// <param name="x">Первое слагаемое</param>
        /// <param name="y">Второе слагаемое</param>
        /// <returns>Сумму ...</returns>
        private int Sum(int x, int y)
        {
            return x + y;
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
#if TRIAL
            Random rnd = new Random();
            lbl_result.Text = rnd.Next(-100, 101).ToString();
            MessageBox.Show("Купите продукт!");
#else
#warning Дописать проверки!!!
            //todo Дописать проверки
//#error Дописать проверки!!!
            Thread.Sleep(10000);
            int x = int.Parse(rtb_firstOp.Text);
            int y = int.Parse(rtb_secondOp.Text);
            int sum = x + y;
            lbl_result.Text = sum.ToString();
            //MessageBox.Show(sum.ToString());
            //int num = Sum(1, 2);
#endif
        }
    }
}
