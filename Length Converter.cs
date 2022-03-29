using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _476_Project_2
{
    public partial class Length_Converter : Form
    {
        public abstract class converter
        {
            protected decimal num;
            protected converter c;

            public void setValue(decimal i)
            {
                num = i;
            }

            public decimal getValue()
            {
                return num;
            }
            public void addSuccessor(converter new_)
            {
                c = new_;
            }

            public abstract void Convert_(decimal distance);
        }

        public class Mile : converter
        {
            public Mile()
            {
                num = 0;
            }
            public override void Convert_(decimal distance)
            {
                num = decimal.Multiply(distance, Convert.ToDecimal(0.621371192));

                if (c != null)
                {
                    c.Convert_(num);
                }
            }
        }

        public class Yard : converter
        {
            public Yard()
            {
                num = 0;
            }
            public override void Convert_(decimal distance)
            {
                num = decimal.Multiply(distance, Convert.ToDecimal(1760));

                if (c != null)
                {
                    c.Convert_(num);
                }
            }
        }

        public class Feet : converter
        {
            public Feet()
            {
                num = 0;
            }
            public override void Convert_(decimal distance)
            {
                num = decimal.Multiply(distance, Convert.ToDecimal(3));

                if (c != null)
                {
                    c.Convert_(num);
                }
            }
        }

        public class wrapper
        {
            protected decimal num;
            protected decimal rounded;
            protected string expNotation;
            protected string fullString;
            protected wrapper w;

            public wrapper()
            {
                num = 0;
            }

            public decimal getNum()
            {
                return num;
            }
            public void setNum(decimal n)
            {
                num = n;
            }

            public decimal getRounded()
            {
                return rounded;
            }

            public string getExpNotation()
            {
                return expNotation;
            }
            public void generateExpNotation()
            {
                int counter = 0;

                while (rounded > 10)
                {
                    rounded *= Convert.ToDecimal(0.1);
                    counter++;
                }

                expNotation = Convert.ToString(rounded) + "e" + Convert.ToString(counter);
            }
            public string generateFullString(int index)
            {
                switch (index)
                {
                    case 0:
                        fullString = expNotation + " Miles";
                        break;
                    case 1:
                        fullString = expNotation + " Yards";
                        break;
                    case 2:
                        fullString = expNotation + " Feet";
                        break;
                }

                return fullString;
            }
        }

        public class RoundDecimal : wrapper
        {
            public RoundDecimal(wrapper newWrapper)
            {
                this.w = newWrapper;
                num = w.getNum();
                rounded = decimal.Round(num, 2);
            }
        }

        public class expNotation : wrapper
        {
            public expNotation(wrapper newWrapper)
            {
                this.w = newWrapper;
                num = w.getNum();
                rounded = w.getRounded();
                expNotation = "";
            }
        }
        public class fullString : wrapper
        {
            public fullString(wrapper newWrapper)
            {
                this.w = newWrapper;
                num = w.getNum();
                rounded = w.getRounded();
                expNotation = w.getExpNotation();
                fullString = "";
            }
        }

        decimal value = 0;
        Mile suc1 = new Mile();
        Yard suc2 = new Yard();
        Feet suc3 = new Feet();

        wrapper wuc1 = new wrapper();
        wrapper wuc2, wuc3, wuc4;

        public Length_Converter()
        {
            InitializeComponent();

            suc2.addSuccessor(suc3);
            suc1.addSuccessor(suc2);
        }

        private void emoji_45_Click(object sender, EventArgs e)
        {
            value = numbers.Value;

            suc1.Convert_(value);

            switch(A_LIST.SelectedIndex)
            {
                case 0:
                    wuc1.setNum(suc1.getValue());
                    break;
                case 1:
                    wuc1.setNum(suc2.getValue());
                    break;
                case 2:
                    wuc1.setNum(suc3.getValue());
                    break;
            }

            wuc2 = new RoundDecimal(wuc1);
            wuc3 = new expNotation(wuc2);
            wuc3.generateExpNotation();
            wuc4 = new fullString(wuc3);

            switch (A_LIST.SelectedIndex)
            {
                case 0:
                    bruhsoundhashtag2.Text = wuc4.generateFullString(A_LIST.SelectedIndex);
                    //bruhsoundhashtag2.Text = Convert.ToString(suc1.getValue());
                    break;
                case 1:
                    bruhsoundhashtag2.Text = wuc4.generateFullString(A_LIST.SelectedIndex);
                    //bruhsoundhashtag2.Text = Convert.ToString(suc2.getValue());
                    break;
                case 2:
                    bruhsoundhashtag2.Text = wuc4.generateFullString(A_LIST.SelectedIndex);
                    //bruhsoundhashtag2.Text = Convert.ToString(suc3.getValue());
                    break;
            }
        }
    }
}
