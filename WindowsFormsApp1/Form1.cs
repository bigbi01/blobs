using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// basic caculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region 
        /// <summary>
        ///  basic constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        /// <summary>
        /// clear the user input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            this.UserInput.Text = string.Empty;
            this.UserInput.Focus();
        }

        private void CButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.UserInput.Text.Length >= this.UserInput.SelectionStart + 1)
                removeValue();
            focusInput();
        }

        private void DivBouton_Click(object sender, EventArgs e)
        {
            addValue("%");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            addValue("7");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            addValue("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            addValue("9");
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            addValue("X");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            addValue("4");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            addValue("5");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            addValue("6");
        }

        private void BtnMoins_Click(object sender, EventArgs e)
        {
            addValue("-");
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            addValue("1");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            addValue("2");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            addValue("3");
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            addValue("+");
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            addValue("0");
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            addValue(".");
        }

        private void BtnEgale_Click(object sender, EventArgs e)
        {
            this.UserInput.Focus();
        }


        #region Private Helpers

        private void focusInput()
        {
            this.UserInput.Focus();
        }
        private void addValue(string n)
        {
            var selectionStart = this.UserInput.SelectionStart;
            this.UserInput.Text = this.UserInput.Text.Insert(this.UserInput.SelectionStart, n);
            UserInput.SelectionStart = selectionStart + n.Length;
            UserInput.SelectionLength = 0;
            focusInput();
        }
        private void removeValue()
        {
            var selectionStart = this.UserInput.SelectionStart;
            this.UserInput.Text = this.UserInput.Text.Remove(this.UserInput.SelectionStart, 1);
            UserInput.SelectionStart = selectionStart ;
            UserInput.SelectionLength = 0;
        }

        private void Calculate()
        {

        }
        #endregion
    }
}
