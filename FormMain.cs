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

namespace WinFormsProj
{
    public partial class FormMain : Form
    {
        int summ;
        int pizza;
        int standart;
        int drinks;
        string pizzaName;
        List<string> drinksNames = new List<string>();
        string drinksList;
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonBonus_Click(object sender, EventArgs e)
        {
            FormBonus f3 = new FormBonus();
            f3.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormInfo f2 = new FormInfo();
            f2.Show();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (pizza != 0 || standart != 0)
            {
                if (radioSmall.Checked == true)
                {
                    pizzaName = pizzaName + " (" + radioSmall.Text + ")";
                }
                else if (radioMedium.Checked == true)
                {
                    pizzaName = pizzaName + " (" + radioMedium.Text + ")";
                }
                else if (radioLarge.Checked == true)
                {
                    pizzaName = pizzaName + " (" + radioLarge.Text + ")";
                }
                foreach (string str in drinksNames)
                    drinksList = drinksList + str;
                saveCheck.ShowDialog();
                if (textBoxPromo.Text != "")
                {
                    File.WriteAllText($"{saveCheck.FileName}" + ".txt", $"Заказ №############.\nПицца: {pizzaName}.\nНапитки: {drinksList}.\n{labelSumm.Text}\nПромокод: {textBoxPromo.Text}\n{labelFinal.Text}");
                    Application.Exit();
                }
                else
                {
                    File.WriteAllText($"{saveCheck.FileName}" + ".txt", $"Заказ №############.\nПицца: {pizzaName}.\nНапитки: {drinksList}.\n{labelSumm.Text}");
                    Application.Exit();
                }
            }
            else if ((pizza == 0 || standart == 0) && drinks == 0)
            {
                MessageBox.Show("Заказ пуст.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Вы не выбрали пиццу.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (pizza != 0 || standart != 0)
            {
                if (textBoxPromo.Text == "")
                {
                    MessageBox.Show("Промокод не введён.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (textBoxPromo.Text == "FIRSTORDER")
                {
                    labelFinal.Text = $"Итоговая стоимость: {(int)(summ - summ * 0.15)}р.";
                }
                else if (textBoxPromo.Text == "CHICKENPEPSI" && radioSmall.Checked == true && radioChicken.Checked == true && checkPepsi.Checked == true)
                {
                    labelFinal.Text = $"Итоговая стоимость: {(int)(summ - summ * 0.1)}р.";
                }
                else
                {
                    MessageBox.Show("Введён неверный промокод или не выполнены условия.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали пиццу.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radioPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            radioSmall.Checked = true;
            radioMedium.Checked = false;
            radioLarge.Checked = false;
            if (radioPepperoni.Checked == true)
            {
                pizzaName = $"\n{radioPepperoni.Text}";
                summ = drinks;
                standart = 300;
                summ = summ + standart;
                labelSumm.Text = $"Сумма заказа: {summ}р.";
            }
        }

        private void radioMedium_CheckedChanged(object sender, EventArgs e)
        {
            summ = drinks;
            if (radioMedium.Checked == true)
            {
                pizza = Convert.ToInt32(standart * 1.5);
                summ = summ + pizza;
            }
            labelSumm.Text = $"Сумма заказа: {summ}р.";
        }

        private void radioSmall_CheckedChanged(object sender, EventArgs e)
        {
            summ = drinks;
            if (radioSmall.Checked == true)
            {
                pizza = standart;
                summ = summ + pizza;
            }
            labelSumm.Text = $"Сумма заказа: {summ}р.";
        }

        private void radioLarge_CheckedChanged(object sender, EventArgs e)
        {
            summ = drinks;
            if (radioLarge.Checked == true)
            {
                pizza = standart * 2;
                summ = summ + pizza;
            }
            labelSumm.Text = $"Сумма заказа: {summ}р.";
        }

        private void radioDoublePepperoni_CheckedChanged(object sender, EventArgs e)
        {
            radioSmall.Checked = true;
            radioMedium.Checked = false;
            radioLarge.Checked = false;
            if (radioDoublePepperoni.Checked == true)
            {
                pizzaName = $"\n{radioDoublePepperoni.Text}";
                summ = drinks;
                standart = 450;
                summ = summ + standart;
                labelSumm.Text = $"Сумма заказа: {summ}р.";
            }
        }

        private void radioFourCheese_CheckedChanged(object sender, EventArgs e)
        {
            radioSmall.Checked = true;
            radioMedium.Checked = false;
            radioLarge.Checked = false;
            if (radioFourCheese.Checked == true)
            {
                pizzaName = $"\n{radioFourCheese.Text}";
                summ = drinks;
                standart = 350;
                summ = summ + standart;
                labelSumm.Text = $"Сумма заказа: {summ}р.";
            }
        }

        private void radioChicken_CheckedChanged(object sender, EventArgs e)
        {
            radioSmall.Checked = true;
            radioMedium.Checked = false;
            radioLarge.Checked = false;
            if (radioChicken.Checked == true)
            {
                pizzaName = $"\n{radioChicken.Text}";
                summ = drinks;
                standart = 400;
                summ = summ + standart;
                labelSumm.Text = $"Сумма заказа: {summ}р.";
            }
        }

        private void radioMargarita_CheckedChanged(object sender, EventArgs e)
        {
            radioSmall.Checked = true;
            radioMedium.Checked = false;
            radioLarge.Checked = false;
            if (radioMargarita.Checked == true)
            {
                pizzaName = $"\n{radioMargarita.Text}";
                summ = drinks;
                standart = 400;
                summ = summ + standart;
                labelSumm.Text = $"Сумма заказа: {summ}р.";
            }
        }

        private void radioHawaiian_CheckedChanged(object sender, EventArgs e)
        {
            radioSmall.Checked = true;
            radioMedium.Checked = false;
            radioLarge.Checked = false;
            if (radioHawaiian.Checked == true)
            {
                pizzaName = $"\n{radioHawaiian.Text}";
                summ = drinks;
                standart = 450;
                summ = summ + standart;
                labelSumm.Text = $"Сумма заказа: {summ}р.";
            }
        }

        private void checkFanta_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkFanta.Checked == true)
            {
                drinksNames.Add($"\n{checkFanta.Text}");
                drinks = drinks + 75;
                if (pizza != 0)
                {
                    summ = pizza + drinks;
                }
                else
                {
                    summ = standart + drinks;
                }
            }
            else
            {
                drinksNames.Remove("\nFanta (75р.)");
                drinks = drinks - 75;
                if (pizza != 0)
                {
                    summ = pizza + drinks;
                }
                else
                {
                    summ = standart + drinks;
                }
            }
            labelSumm.Text = $"Сумма заказа: {summ}р.";
        }

        private void checkCola_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkCola.Checked == true)
            {
                drinksNames.Add($"\n{checkCola.Text}");
                drinks = drinks + 78;
                if (pizza != 0)
                {
                    summ = pizza + drinks;
                }
                else
                {
                    summ = standart + drinks;
                }
            }
            else
            {
                drinksNames.Remove("\nCoca-Cola (78р.)");
                drinks = drinks - 78;
                if (pizza != 0)
                {
                    summ = pizza + drinks;
                }
                else
                {
                    summ = standart + drinks;
                }
            }
            labelSumm.Text = $"Сумма заказа: {summ}р.";
        }

        private void checkPepsi_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkPepsi.Checked == true)
            {
                drinksNames.Add($"\n{checkPepsi.Text}");
                drinks = drinks + 83;
                if (pizza != 0)
                {
                    summ = pizza + drinks;
                }
                else
                {
                    summ = standart + drinks;
                }
            }
            else
            {
                drinksNames.Remove("\nPepsi (83р.)");
                drinks = drinks - 83;
                if (pizza != 0)
                {
                    summ = pizza + drinks;
                }
                else
                {
                    summ = standart + drinks;
                }
            }
            labelSumm.Text = $"Сумма заказа: {summ}р.";
        }

        private void checkSprite_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkSprite.Checked == true)
            {
                drinksNames.Add($"\n{checkSprite.Text}");
                drinks = drinks + 68;
                if (pizza != 0)
                {
                    summ = pizza + drinks;
                }
                else
                {
                    summ = standart + drinks;
                }
            }
            else
            {
                drinksNames.Remove("\nSprite (68р.)");
                drinks = drinks - 68;
                if (pizza != 0)
                {
                    summ = pizza + drinks;
                }
                else
                {
                    summ = standart + drinks;
                }
            }
            labelSumm.Text = $"Сумма заказа: {summ}р.";
        }

        private void checkBlackTea_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBlackTea.Checked == true)
            {
                drinksNames.Add($"\n{checkBlackTea.Text}");
                drinks = drinks + 80;
                if (pizza != 0)
                {
                    summ = pizza + drinks;
                }
                else
                {
                    summ = standart + drinks;
                }
            }
            else
            {
                drinksNames.Remove("\nЧёрный чай (80р.)");
                drinks = drinks - 80;
                if (pizza != 0)
                {
                    summ = pizza + drinks;
                }
                else
                {
                    summ = standart + drinks;
                }
            }
            labelSumm.Text = $"Сумма заказа: {summ}р.";
        }

        private void checkGreenTea_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkGreenTea.Checked == true)
            {
                drinksNames.Add($"\n{checkGreenTea.Text}");
                drinks = drinks + 82;
                if (pizza != 0)
                {
                    summ = pizza + drinks;
                }
                else
                {
                    summ = standart + drinks;
                }
            }
            else
            {
                drinksNames.Remove("\nЗелёный чай (82р.)");
                drinks = drinks - 82;
                if (pizza != 0)
                {
                    summ = pizza + drinks;
                }
                else
                {
                    summ = standart + drinks;
                }
            }
            labelSumm.Text = $"Сумма заказа: {summ}р.";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            radioSmall.Checked = false;
            radioMedium.Checked = false;
            radioLarge.Checked = false;
            radioPepperoni.Checked = false;
            radioDoublePepperoni.Checked = false;
            radioFourCheese.Checked = false;
            radioChicken.Checked = false;
            radioMargarita.Checked = false;
            radioHawaiian.Checked = false;
            checkCola.Checked = false;
            checkPepsi.Checked = false;
            checkSprite.Checked = false;
            checkFanta.Checked = false;
            checkBlackTea.Checked = false;
            checkGreenTea.Checked = false;
            drinksList = "";
            standart = 0;
            pizza = 0;
            summ = 0;
            labelSumm.Text = $"Сумма заказа: {summ}р.";
            labelFinal.Text = "";
            textBoxPromo.Text = "";
        }
    }
}
