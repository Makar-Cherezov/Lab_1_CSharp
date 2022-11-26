using System;

namespace ClassCard
{
    public class Card

    {
        private int value;
        private string suite;
        string[] values = new string[] {"2", "3", "4", "5", "6", "7", "8", "9", "10",
            "валет", "дама", "король", "туз"};

        public Card(int value, string suite) 
        {
            this.value = value;
            this.suite = suite;
        }

        Random rand = new Random();

        public Card()
        {
            this.value = rand.Next(0, 13);
            switch (rand.Next(0, 4))
            {
                case 0:
                    this.suite = "черви";
                    break;
                case 1:
                    this.suite = "бубны";
                    break;
                case 2:
                    this.suite = "крести";
                    break;
                case 3:
                    this.suite = "пики";
                    break;
            }
        }
        public string GetValue()
        {
            return values[this.value];
        }
        public string GetSuite()
        {
            return this.suite;
        }
        public bool IsTrump(string trump_suite)
        {
            if (this.suite == trump_suite)
            {
                return true;
            }
            else
            {
                return false; //
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="card"></param>
        /// <param name="trump_suite"></param>
        /// <returns></returns>
        public bool Compare(Card card, string trump_suite)
        {

            bool this_trump = this.IsTrump(trump_suite);
            bool card_trump = card.IsTrump(trump_suite);
            if ((card_trump && !this_trump))
                return false;
            else if (!card_trump && this_trump)
                return true;
            else if (card.suite != this.suite)
                return false;
            else if (card.value < this.value)
                return true;
            else return false;
        }
    }
}
