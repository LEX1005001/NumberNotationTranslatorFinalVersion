using NumberTranslateLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberNotationTranslator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение предназначено для перевода числа из системы счисления с основание Р в систему счисления с основанием Q"+
                "\r\nДля выполнения расчёта, в поле \"Введите число: \" введите целое или дробное число," +
                " каждая цифра которого не превышает основание его системы счисления и нажмите кнопку \"Вычислить\".\r\nЕсли поле \"Точность\"" +
                " оставить пустым или ввести туда 0, то результат будет выводиться с таким же количеством знаков после запятой, что и в исходном числе. " +
                "Минимально возможное основание системы счисления - 2, максимальное - 36\r\nВ случае ввода дробного числа используйте знак\"," +
                " для отделения целой и дробной части.\r\nПри вводе чисел в системах счисления больше 10 используйте буквы латинского алфавита.\r\n" +
                "При некорректном вводе выдаётся сообщение об ошибке. Пример правильного ввода: 10; 10,5; АВ,А","Справка");
        }


        private void buttonDo_Click_1(object sender, EventArgs e)
        {
           string xStr;//получаем произвольное число

            if(textBoxInputNumber.Text!="")
                xStr = textBoxInputNumber.Text;
            else
            {
                MessageBox.Show("Некорректный ввод.");
                return;
            }

            bool isNegative = false;//проверка на отрицательность
            if (xStr[0] == Convert.ToChar("-"))
            {
                isNegative = true;
                xStr=xStr.Remove(0,1);
            }

            bool isFractionalNmber = false;//проверка на число с дробной частью//
            if (xStr.Contains(',') == true)
            {
                isFractionalNmber= true;
            }

            //Проверка на корректность ввода
            for (int i = 0; i < xStr.Length; i++)
            {
                if (xStr[i] != Convert.ToChar(","))
                {
                   if (ClassTranslate.dig2int(xStr[i]) == -1)
                   {
                        MessageBox.Show("Некорректный ввод.\n" +
                            "Введён постаронний символ в поле\"Введите число\".\n" +
                            "Ошибка");
                        return;
                   }
                }
            }
          
            //Проверяем на корректность ввода системы счисления P
            if(!int.TryParse(textBoxNotationFrom.Text,out int P) || P > 37 || P <= 1)
            {
                MessageBox.Show("Некорректный ввод.\n" +
                    "Его изначальная c.c это - целое число от 2 до 36.\n" +
                    "Для справки нажмите нужную кнопку.", "Ошибка!");
                return;
            }

            //Проверяем на корректность ввода системы счисления Q
            if (!int.TryParse(textBoxNotationTo.Text,out int Q) || Q >= 37 || Q <= 1)
            {
                MessageBox.Show("Некорректный ввод.\n" +
                    "С.с в которую нужно перевести это - целое число от 2 до 36.\n" +
                    "Для справки нажмите нужную кнопку.", "Ошибка!");
                return;
            }

            int counter = 0;

            //Проверка на соответсктвие числа и его системы счисления
            for (int i=0; i < xStr.Length; i++)
            {
                if (xStr[i] != Convert.ToChar(","))
                {
                    if (ClassTranslate.dig2int(xStr[i])>= P)
                    {
                        MessageBox.Show("Цифры числа не могут превосходить его систему счисления.\n" +
                            "Для справки нажмите соответствующую кнопку.", "Ошибка!");
                        return;
                    }
                }
                else
                {
                    counter++;
                    if (counter > 1)
                    {
                        MessageBox.Show("Некорректный ввод. В чесле не может быть больше одной запятой\n" +
                            "Для справки нажмите соответствующую кнопку.", "Ошибка!");
                        return;
                    }
                }
            }

            string intPart = ClassTranslate.Divide(xStr)[0];    //Целая часть числа
            string fractPart = "";  //Дробная часть числа

            if (isFractionalNmber == true)
            {
                fractPart = ClassTranslate.Divide(xStr)[1];

                //Проверяем на наличие дробной части в числе 
                try
                {
                    fractPart = ClassTranslate.Divide(xStr)[1];
                }
                catch (Exception)
                {
                    fractPart = "0";
                }
            }

            int NumbersAfter;

            if (textBoxNumbersAfter.Text == "" || textBoxNumbersAfter.Text == "0")
                NumbersAfter = fractPart.Length;
            else
                try //Проверка ввода
                {
                    NumbersAfter = int.Parse(textBoxNumbersAfter.Text);
                    if (NumbersAfter < 0)
                    {
                        MessageBox.Show("Некорректный ввод.\n" +
                            "Точность - целое не отрицательное число.\n" +
                            "Для справки нажмите на .", "Ошибка");
                        return;
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Некорректный ввод.\n" +
                            "Точность - целое не отрицательное число.\n" +
                            "Для справки нажмите на .", "Ошибка");
                    return;
                }

            string intPart10 = ClassTranslate.notation10_Int(intPart, P);//Целая часть от числа в 10-ой системе счисления
            string intPartQ = ClassTranslate.Ten2Q_int(intPart10, Q);    // Целая часть числа в Q-ой системе счисления

            string fractPart10;//Дробная часть в c.c 10
            string fractPartQ;//Дробная часть числа в c.c  Q

            string result; //Результат переволда числа в c.c Q

            if (fractPart != "0" && isFractionalNmber==true)
            {
                fractPart10=ClassTranslate.notation10_Fract(fractPart, P);//дробная часть от числа в 10-ой c.c
                fractPartQ = ClassTranslate.Ten2Q_fract(fractPart10, Q,NumbersAfter);//дробная часть от чила в Q-ой с.c

                result = isNegative ? ($"-{intPartQ}" + $"{fractPartQ.Remove(0, 1)}") : ($"{intPartQ}" + $"{fractPartQ.Remove(0, 1)}");//Результат если есть дробная часть
            }
            else
            {
                result = isNegative ? ($"-{intPartQ}" ) : ($"{intPartQ}" );//Результат если нет дробной части
            }

            //вывод переведенного числа в c.c Q
            textBoxResult.Text = String.Format("{0}", result);
        }

       
    }
}
