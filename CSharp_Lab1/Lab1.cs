using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassCard;

namespace CSharp_Lab1
{
    public partial class Lab1 : Form
    {
        Card[] cards = new Card[2];
       // List<Card> _cards = new List<Card>(2);
       
        
        string trump_suite;
        public Lab1()
        {
            InitializeComponent();
        }

        private void Lab1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (comboBoxValues.SelectedIndex > -1 && comboBoxSuites.SelectedIndex > -1)
            {
                Card card = new Card(comboBoxValues.SelectedIndex, comboBoxSuites.SelectedItem.ToString());
                textBoxShow.Text = "Ваша карта:" +
                    Environment.NewLine + card.GetValue() + ' ' + card.GetSuite();
                cards[0] = card;
            }
            else textBoxShow.Text = "Выберите масть и значение!";

        }

        private void buttonRand_Click(object sender, EventArgs e)
        {
            Card card = new Card();
            textBoxShow.Text = "Ваша карта:" + 
                Environment.NewLine + card.GetValue() + ' ' + card.GetSuite();
            cards[0] = card;
        }

        private void buttonOpp_Click(object sender, EventArgs e)
        {
            if (comboBoxValues.SelectedIndex > -1 && comboBoxSuites.SelectedIndex > -1)
            {
                Card card = new Card(comboBoxValues.SelectedIndex, comboBoxSuites.SelectedItem.ToString());
                textBoxOpp.Text = "Карта оппонента:" +
                    Environment.NewLine + card.GetValue() + ' ' + card.GetSuite();
                cards[1] = card;
            }
            else textBoxOpp.Text = "Выберите масть и значение!";
                
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            if (comboBoxTrump.SelectedIndex > -1)
            {
                trump_suite = comboBoxTrump.SelectedItem.ToString();
                textBoxCompare.Text = "Сравнить карты:" +
                    Environment.NewLine + cards[0].GetValue() + ' ' + cards[0].GetSuite() +
                    Environment.NewLine + cards[1].GetValue() + ' ' + cards[1].GetSuite();
                if (cards[0].Compare(cards[1], trump_suite))
                    textBoxCompare.Text += Environment.NewLine + "Ваша победа!";
                else textBoxCompare.Text += Environment.NewLine + "Вы не победили!";
            }
            else textBoxCompare.Text = "Выберите козырь!";



        }
    }
}
