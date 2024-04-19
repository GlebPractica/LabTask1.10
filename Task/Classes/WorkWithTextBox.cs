using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public class WorkWithTextBox
    {
        public static string GetStringFromTextBox(TextBox textBox, ref string outText)
        {
            if (textBox is null)
                return $"Неизвестный аргумент. Повторите попытку.\nCode error: GetStrfrTB";

            if (string.IsNullOrWhiteSpace(textBox.Text))
                return $"Пустая строка. Повторите попытку.";
            else
            {
                outText = textBox.Text;
                return $"Успешно! Текущий текст: {outText}";
            }
        }

        public static string GetIntFromTextBox(TextBox textBox, ref int outInt)
        {
            if (textBox is null)
                return $"Неизвестный аргумент. Повторите попытку.\nCode error: GetIntfrTB";

            if (int.TryParse(textBox.Text, out outInt))
                return $"Успешно! Текущее значение: {outInt}";
            else
                return $"Не удалось записать значение. Повторите попытку.\nТекущее значение: {textBox.Text}";
        }
    }
}
