using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTranslateLibrary
{
    /// <summary>
    /// Класс для перевода целых чисел из одной системы счисления в другую
    /// </summary>
    public class ClassTranslate
    {
        /// <summary>
        /// Алфавит систем счисления
        /// </summary>
        const string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// Функция возращает числовое значение смвола
        /// </summary>
        /// <param name="k"> символ </param>
        /// <returns> целое число </returns> 
        public static int dig2int(char k)
        {
            return digits.IndexOf(k);
        }
        /// <summary>
        /// Переволит из числового значения в символ
        /// </summary>
        /// <param name="i"></param>
        /// <returns> Символ </returns>
        public static string int2dig(int i)
        {
            if (i > digits.Length)
                return "-1";
            return Convert.ToString(digits[i]);
        }

        /// <summary>
        /// Разделяет число на целую и дробную часть
        /// </summary>
        /// <param name="s"></param>
        /// <returns>Массив из целой и дробной части</returns>
        public static string[] Divide(string s)
        {
            string[] arr = s.Split(',');
            return arr;
        }

        /// <summary>
        /// Перевод целой части числа в 10-ую систему счисления 
        /// </summary>
        /// <param name="x">целая часть числа</param>
        /// <param name="n">исходная с.c</param>
        /// <returns>число в 10-ой системе счисления</returns>
        public static string notation10_Int(string x, int P)
        {
            if (P == 10)
                return x;
            int x10 = dig2int(x[0]);
            for (int i = 1; i < x.Length; i++)
            {
                x10 *= P;
                x10 += dig2int(x[i]);
            }
            return Convert.ToString(x10);
        }

        /// <summary>
        /// Перевод дробной части числа в 10-ую систему счисления
        /// </summary>
        /// <param name="x">дробная часть числа</param>
        /// <param name="n">первоначальная с.c</param>
        /// <returns>число в 10-ой с.c</returns>
        public static string notation10_Fract(string x, int P)
        {
            if (P == 10)
                return x;
            string xZero = "0" + x;
            char[] xReverse = xZero.ToCharArray().Reverse().ToArray();

            double x10 = dig2int(xReverse[0]);
            for (int i = 1; i < xReverse.Length; i++)
            {
                x10 /= P;
                x10 += dig2int(xReverse[i]);
            }
            string tmp = Convert.ToString(x10);
            return tmp.Substring(2, tmp.Length-2 );
        }

        /// <summary>
        /// Перевод целой части числа из 10-ой с.c в систему счисления Q
        /// </summary>
        /// <param name="x">целая часть числа</param>
        /// <param name="Q">система счисления в которую нужно перевести число</param>
        /// <returns>число в системе счисления Q</returns>
        public static string Ten2Q_int(string x, int Q)//Что-то не так
        {

            if (Q == 10)
                return x;

            string xQ = "";
            int xInt = int.Parse(x);

            while (xInt >= Q)
            {
                xQ = Convert.ToString(digits[xInt % Q]) + xQ;
                xInt /= Q;
            }
            xQ = Convert.ToString(digits[xInt % Q]) + xQ;
            return xQ;
        }

        /// <summary>
        /// Переводит дробную часть числа из 10-ой с.c в систему счисления Q
        /// </summary>
        /// <param name="x">дробная часть числа</param>
        /// <param name="Q">система счисления в которую нужно перевести число</param>
        /// <param name="DecPlaces">Кол-во знаков после запятой</param>
        /// <returns>число в системе счисления Q</returns>
        public static string Ten2Q_fract(string x, int Q, int DecPlaces)//?
        {
            if (Q == 10)
                if (DecPlaces < x.Length)
                    return "0," + x.Substring(0, DecPlaces);
                else
                    return "0," + x;

            int coutnter = 0;//Счётчик сколько знаков мы рассчитали после запятой
            double xQ = double.Parse("0," + x);
            string answer = "0,";

            while (true)
            {
                xQ *= Q;
                string tmp = Convert.ToString(xQ);
                answer += int2dig(int.Parse(Divide(tmp)[0]));

                if (xQ >= 1)
                {
                    x = Convert.ToString(xQ);
                    try //проверка на существование остатка у числа
                    {
                        xQ = double.Parse("0," + Divide(x)[1]);
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }

                coutnter += 1;
                if (coutnter >= DecPlaces)
                    break;
            }
            return answer;

        }
        /// <summary>
        /// Функция проверки числа на отрицательность
        /// </summary>
        /// <param name="xStr"></строка - то что мы проверяем>
        /// <returns></True / False в зависимости от числа>
        static bool IsNegative(string xStr)
        {
            if (xStr[0] == Convert.ToChar("-"))
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// Функция разделяет число на целую и друбную часть
        /// </summary>
        /// <param name="xStr"></Обрабатываемое число>
        /// <returns></массив строк(нулевой элемент -целая часть, первый-дробная часть ч./><returns>
        static string[] SepNumber(string xStr)
        {
            string[] number = new string[2];
            number[0] = ClassTranslate.Divide(xStr)[0];

            try
            {
                number[1] = Divide(xStr)[1];//Дробная часть
            }
            catch (Exception)
            {
                number[1] = "0";
            }
            return number;
        }

        /// <summary>
        /// Переводит целую часть числа из P(системы счиления)
        /// до Q
        /// </summary>
        /// <param name="IntPart"> Целая часть числа</param>
        /// <param name="P">Исходная система счисления</param>
        /// <param name="Q">С.с в которую нужно перевести число</param>
        /// <returns> Целую чатсть чила в с.с Q</returns>
        static string TranslateIntPartFromP2Q(string IntPart, int P, int Q)
        {
            IntPart = notation10_Int(IntPart, P);//Переод целой части в 10-ую
            IntPart = Ten2Q_int(IntPart, Q);     //Перевод целой ч. из 10 -> Q
            return IntPart;
        }

        /// <summary>
        /// Переводит дробную часть числа из P с.c -> Q
        /// </summary>
        /// <param name="FractPart"></param>
        /// <param name="P"> Изночальная система счисления</param>
        /// <param name="Q"> С.с в которую нужно перевести число</param>
        /// <param name="DecPlaces">кол-во знаков после запятой</param>
        /// <returns></returns>
        static string TranslateFractPartFromP2Q(string FractPart, int P, int Q, int DecPlaces)
        {
            if (FractPart != "0")
            {
                FractPart = notation10_Fract(FractPart, P);//Дробная часть из P -> 10
                FractPart = Ten2Q_fract(FractPart, Q, DecPlaces);

            }
            return FractPart;
        }
        public static string TranslateP2Q(string xStr, int P, int Q, int Decplaces)
        {
            if (IsNegative(xStr))
                xStr = xStr.Remove(0, 1);

            string[] SepatNum = SepNumber(xStr);//Разделяет число на целую и дробную часть [123,456]

            if (Decplaces == 0)
            {
                Decplaces = SepatNum[1].Length;//число знаков полсле ,
            }
            SepatNum[0] = TranslateIntPartFromP2Q(SepatNum[0], P, Q); //Перевод  целой части числа из P -> Q
            SepatNum[1] = TranslateFractPartFromP2Q(SepatNum[1], P, Q, Decplaces);//Перевод дробной части из P -> Q

            if (SepatNum[1] != "0") //Если у числа есть дробная часть, возращаем результат вместе  ней
                return IsNegative(xStr) ? ($"-{SepatNum[0]}{SepatNum[1].Remove(0, 1)}") :
                    ($"{SepatNum[0]}{SepatNum[1].Remove(0, 1)}");//При необходимости возращаем знак
            else  //Иначе возращяем целую часть
                return IsNegative(xStr) ? $"-{SepatNum[0]}" : $"{SepatNum[0]}";//При необходимости возращяем -
        }
    }

}
