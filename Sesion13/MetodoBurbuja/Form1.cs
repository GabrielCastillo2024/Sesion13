using MetodoBurbuja.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoBurbuja
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[10];
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Bubble bubble = new Bubble();
            bubble.bubbleSort(numbers);
            ShowNumbers();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int number = int.Parse(tbNumber.Text);
            numbers[i] = number;
            ShowNumbers();
            clear();

        }
        public void ShowNumbers()
        {
            if(lbNumeros.Items.Count > 0)
            {
                lbNumeros.Items.Clear();
            }
            foreach (int number in numbers)
            {
                lbNumeros.Items.Add(numbers);
            }
        }
        private void clear()
        {
            tbNumber.Clear();
            tbNumber.Focus();
        }
    }
}
