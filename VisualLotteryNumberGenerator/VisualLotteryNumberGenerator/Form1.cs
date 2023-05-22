using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLotteryNumberGenerator
{
    public partial class VisualLotteryNumberGenerator : Form
    {
        private int option = 0;
        private Random rnd = new Random();
        private int[] generatedNumbers;
        private const int LOTTO_MAX_MAX = 50;
        private const int LOTTO_649_MAX = 49;
        private const int LOTTO_MAX_LENGTH = 7;
        private const int LOTTO_649_LENGTH = 6;

        public VisualLotteryNumberGenerator()
        {
            InitializeComponent();
        }

        private int selectLottoRng(int selection) {

            int rn;

            if (selection == 0)
            {
                //Numbers for Lotto 6/49 and BC 49 are between 0 - 49
                rn = rnd.Next(LOTTO_649_MAX);
            }
            else {
                //Numbers for Lotto Max are between 0 - 50
                rn = rnd.Next(LOTTO_MAX_MAX);
            }

            return rn;
        }

        private void populateGeneratedNumbers(int length) {
            for (int i = 0; i < length; i++) {
                generatedNumbers[i] = selectLottoRng(option);
            }
        }

        private void generateLottoMaxNumbers() {
            //Lotto Max requires 7 numbers
            generatedNumbers = new int[LOTTO_MAX_LENGTH];
            populateGeneratedNumbers(LOTTO_MAX_LENGTH);
        }

        private void generateLotto649Numbers() {
            //Lotto 6/49 and BC 49 requires 6 numbers
            generatedNumbers = new int[LOTTO_649_LENGTH];
            populateGeneratedNumbers(LOTTO_649_LENGTH);
        }

        private void printNumbers() {
            //Print numbers to screen
            String lottoNumbers = "";

            for (int i = 0; i < generatedNumbers.Length; i++) {
                lottoNumbers += generatedNumbers[i] + " ";
            }

            randomNumbers.Text = lottoNumbers;
        }

        private void lottoMaxBtn_Click(object sender, EventArgs e)
        {
            lottoMaxBtn.Hide();
            lotto649Btn.Hide();
            regenerateBtn.Show();
            backBtn.Show();
            randomNumbers.Show();
            numbersLabel.Show();
            option = 0;
            generateLottoMaxNumbers();
            printNumbers();
        }

        private void lotto649Btn_Click(object sender, EventArgs e)
        {
            lotto649Btn.Hide();
            lottoMaxBtn.Hide();
            randomNumbers.Show();
            regenerateBtn.Show();
            backBtn.Show();
            numbersLabel.Show();
            option = 1;
            generateLotto649Numbers();
            printNumbers();
        }

        private void regenerateBtn_Click(object sender, EventArgs e)
        {
            if (option == 0)
            {
                generateLottoMaxNumbers();
            }
            else {
                generateLotto649Numbers();
            }

            printNumbers();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            backBtn.Hide();
            regenerateBtn.Hide();
            numbersLabel.Hide();
            randomNumbers.Hide();
            lotto649Btn.Show();
            lottoMaxBtn.Show();
        }
    }
}
