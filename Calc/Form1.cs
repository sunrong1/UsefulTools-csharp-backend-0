using System;
using System.Windows.Forms;

namespace Calc
{
    public partial class CalcForm : Form
    {
        private string strOutput = "";
        private double lNumFormer = 0;//前一个操作数
        private double lNumTemp = 0;//临时变量
        private double lResult = 0;//结果
        private char cOperator;//操作符
        private bool bDotClicked = false;//用于标记小数点是否被按下
        //private uint decimalIndex = 0;//用于标记当前小数点后精度位数，如3.14的decimalIndex==2
        double lastDecimalNum = 1;//最近一次点击的小数精度，即小数最后一位精度，如0.01

        public CalcForm()
        {
            InitializeComponent();
            //数字按钮0~9
            button_num_0.Click += new EventHandler(Numbers_Click);
            button_num_1.Click += new EventHandler(Numbers_Click);
            button_num_2.Click += new EventHandler(Numbers_Click);
            button_num_3.Click += new EventHandler(Numbers_Click);
            button_num_4.Click += new EventHandler(Numbers_Click);
            button_num_5.Click += new EventHandler(Numbers_Click);
            button_num_6.Click += new EventHandler(Numbers_Click);
            button_num_7.Click += new EventHandler(Numbers_Click);
            button_num_8.Click += new EventHandler(Numbers_Click);
            button_num_9.Click += new EventHandler(Numbers_Click);

            //运算符+、-、*、/
            button_add.Click += new EventHandler(Operators_Click);
            button_sub.Click += new EventHandler(Operators_Click);
            button_mul.Click += new EventHandler(Operators_Click);
            button_div.Click += new EventHandler(Operators_Click);
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {

        }
        //****数字按钮0-9
        private void Button_num_0_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void Button_num_1_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_2_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_3_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_4_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_5_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_6_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_7_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_8_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_9_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        //****操作符+、-、*、/
        private void Button_add_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Operators_Click（）函数
        }

        private void Button_sub_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Operators_Click（）函数
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Operators_Click（）函数
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Operators_Click（）函数
        }


        //****等于号=
        private void Button_enter_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cOperator)
                {
                    case '+':
                        //计算并检测数据是否越界
                        checked { lResult = lNumFormer + lNumTemp; }
                        break;
                    case '-':
                        checked { lResult = lNumFormer - lNumTemp; }
                        break;
                    case '*':
                        checked { lResult = lNumFormer * lNumTemp; };
                        break;
                    case '/':
                        checked { lResult = lNumFormer / lNumTemp; };
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                MessageBox.Show("运算结果溢出");
            }

            txtOutput.Text = lResult.ToString();
            //清空变量
            lNumFormer = 0;//前一个操作数
            lNumTemp = 0;//临时变量
            lResult = 0;//结果
            cOperator = '\0';//操作符
            strOutput = "";
            bDotClicked = false;
            lastDecimalNum = 1;
        }

        //****清空键CE
        private void button_ce_Click(object sender, EventArgs e)
        {
            //清空变量
            lNumFormer = 0;//前一个操作数
            lNumTemp = 0;//临时变量
            lResult = 0;//结果
            cOperator = '\0';//操作符
            strOutput = "";
            bDotClicked = false;
            lastDecimalNum = 1;

            //清空页面显示
            txtOutput.Text = "";
        }

        //****小数点.
        private void button_dot_Click(object sender, EventArgs e)
        {
            if (!bDotClicked)
            {
                strOutput += ".";
                txtOutput.Text = strOutput;
                bDotClicked = true;
            }
        }

        //集中处理按钮点击事件
        //****数字按钮0-9
        private void Numbers_Click(object sender, EventArgs e)
        {
            string strClickNum = ((Button)sender).Text;
            try
            {
                if (bDotClicked)
                {
                    //得出点击的小数数值
                    //decimalIndex++;
                    lastDecimalNum *= 0.1;
                    checked { lNumTemp = lNumTemp + long.Parse(strClickNum) * lastDecimalNum; }
                }
                else
                {
                    checked { lNumTemp = lNumTemp * 10 + long.Parse(strClickNum); }
                }
            }
            catch
            {
                //貌似double型并不会轻易溢出
                MessageBox.Show("数据溢出");
            }
            txtOutput.Text = lNumTemp.ToString();
            strOutput += strClickNum;
            //strOutput = lNumTemp.ToString();
            txtOutput.Text = strOutput;
        }

        //集中处理按钮点击事件
        //****操作符+、-、*、/
        private void Operators_Click(object sender, EventArgs e)
        {
            cOperator = ((Button)sender).Text[0];//strClickOp长度为1
            lNumFormer = lNumTemp;
            lNumTemp = 0;
            strOutput += cOperator.ToString();
            txtOutput.Text = strOutput;
            bDotClicked = false;
            lastDecimalNum = 1;
        }

        //键盘按键
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // if it is a hotkey, return true; otherwise, return false
            switch (keyData)
            {
                case Keys.NumPad0:
                    button_num_0.Focus();
                    button_num_0.PerformClick();
                    return true;
                case Keys.NumPad1:
                    button_num_1.Focus();
                    button_num_1.PerformClick();
                    return true;
                case Keys.NumPad2:
                    button_num_2.Focus();
                    button_num_2.PerformClick();
                    return true;
                case Keys.NumPad3:
                    button_num_3.Focus();
                    button_num_3.PerformClick();
                    return true;
                case Keys.NumPad4:
                    button_num_4.Focus();
                    button_num_4.PerformClick();
                    return true;
                case Keys.NumPad5:
                    button_num_5.Focus();
                    button_num_5.PerformClick();
                    return true;
                case Keys.NumPad6:
                    button_num_6.Focus();
                    button_num_6.PerformClick();
                    return true;
                case Keys.NumPad7:
                    button_num_7.Focus();
                    button_num_7.PerformClick();
                    return true;
                case Keys.NumPad8:
                    button_num_8.Focus();
                    button_num_8.PerformClick();
                    return true;
                case Keys.NumPad9:
                    button_num_9.Focus();
                    button_num_9.PerformClick();
                    return true;
                case Keys.Add:
                    button_add.Focus();
                    button_add.PerformClick();
                    return true;
                case Keys.Subtract:
                    button_sub.Focus();
                    button_sub.PerformClick();
                    return true;
                case Keys.Multiply:
                    button_mul.Focus();
                    button_mul.PerformClick();
                    return true;
                case Keys.Divide:
                    button_div.Focus();
                    button_div.PerformClick();
                    return true;
                case Keys.Enter:
                    button_enter.Focus();
                    button_enter.PerformClick();
                    return true;
                case Keys.Escape:
                    button_ce.Focus();
                    button_ce.PerformClick();
                    return true;
                case Keys.Decimal:
                    button_dot.Focus();
                    button_dot.PerformClick();
                    return true;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
