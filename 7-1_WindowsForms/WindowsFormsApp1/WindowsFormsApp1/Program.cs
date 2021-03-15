using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// Сергей Иванов
// Задание 7.1 
// а) добавить в к программу "Удвоитель" подсчёт количества отданных команд.
// б) добавить меню и команду "Играть". При нажатии появляется сообщение,
// какое число должен получить игрок. Игрок должен постараться получить
// это число за минимальное количество ходов.
// в)* добавить кнопку "отменить", которая отменяет последние ходы.

// Задание 7.2
// Используя Windows Forms, разработать игру "Угадай число".
// Компьютер загадывает число от 1 до 100, а человек пытается его угадать
// за минимальное число попыток. Для ввода данных от человека используется элемент TextBox.

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
