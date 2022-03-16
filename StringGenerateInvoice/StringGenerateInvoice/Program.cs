﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringGenerateInvoice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== STRING GENERATE INVOICE =====");
            Console.Write("Input : ");
            string inputUser = Console.ReadLine();
            string outputInvoice = GenerateInvoice(inputUser);
            Console.WriteLine(outputInvoice);
        }

        static string GenerateInvoice(string input)
        {
            int inputNum = int.Parse(input)+1;
            DateTime currentDate = DateTime.Now;

            currentDate = currentDate.AddDays(3);
            string Date = currentDate.ToString("dd/MM/yyyy");
            string[] arrayDate = Date.Split('/');
            string Day = DateTime.Now.ToString("ddd");
            string dy = Day.Substring(0, 2);
            string ddInRoman = ToRoman(int.Parse(arrayDate[0]));
            string yyInRoman = ToRoman(int.Parse(arrayDate[2].Substring(2)));
            string invoice = $"INV/{arrayDate[2]}{arrayDate[1]}/{dy.ToUpper()}/{ddInRoman}/{yyInRoman}/" + inputNum;
            return invoice;
        }

        static string ToRoman (int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("Masukkan nilai antara 1 dan 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900);
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            throw new ArgumentOutOfRangeException("Terjadi Kesalahan");
        }
    }
}
