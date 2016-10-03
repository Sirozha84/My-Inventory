using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_Inventory
{
    static class Print
    {
        static User usr;
        static List<Item> itms;
        static int PageNum;
        public static void RegistryCard(User user)
        {
            usr = user;
            itms = Data.Items.FindAll(o => o.User == usr.Name);
            PageNum = 1;

            PrintDocument doc = new PrintDocument();

            doc.PrintPage += new PrintPageEventHandler(PD_PrintPage);

            PrintDialog diag = new PrintDialog();
            if (diag.ShowDialog() == DialogResult.Cancel) return;
            doc.PrinterSettings = diag.PrinterSettings;
            doc.PrinterSettings.DefaultPageSettings.Landscape = true;
            doc.Print();
        }
        static void PD_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font Big = new Font("Arial", 6, FontStyle.Regular, GraphicsUnit.Millimeter);
            Font Mid = new Font("Arial", 5, FontStyle.Regular, GraphicsUnit.Millimeter);
            Font Small = new Font("Arial", 4, FontStyle.Regular, GraphicsUnit.Millimeter);
            StringFormat Centr = new StringFormat();
            Centr.Alignment = StringAlignment.Center;
            Centr.LineAlignment = StringAlignment.Center;
            StringFormat Left = new StringFormat();
            Left.LineAlignment = StringAlignment.Center;

            // 1169 x 827

            //Титульные поля
            Label(80, 80, 1010, 35, "Организация: " + usr.Organisation, Big, Centr, false, e);
            Label(80, 115, 1010, 35, "Карточка учёта оргтехники № " + PageNum, Big, Centr, false, e);
            Label(80, 160, 300, 30, "Структурное подразделение:", Mid, Left, false, e);
            Label(380, 160, 700, 30, usr.Departament, Mid, Left, false, e);
            Label(80, 190, 300, 30, "Подотчётное лицо:" , Mid, Left, false, e);
            Label(380, 190, 700, 30, usr.Name + " (" + usr.Post + ")", Mid, Left, false, e);
            //Шапка таблицы
            Label(80, 240, 60, 30, "Номер", Small, Centr, true, e);
            Label(140, 240, 200, 30, "Наименование", Small, Centr, true, e);
            Label(340, 240, 200, 30, "Модель", Small, Centr, true, e);
            Label(540, 240, 60, 30, "Инв №", Small, Centr, true, e);
            Label(600, 240, 190, 30, "Дата", Small, Centr, true, e);
            Label(790, 240, 200, 30, "Место", Small, Centr, true, e);
            Label(990, 240, 100, 30, "Подпись", Small, Centr, true, e);
            //Поля таблицы
            for (int i = 0; i < 20; i++)
            {
                if (itms.Count > 0)
                {
                    Item it = itms[0];
                    Label(80, 270 + i * 20, 60, 20, (i+1).ToString(), Small, Left, true, e);
                    Label(140, 270 + i * 20, 200, 20, it.Name, Small, Left, true, e);
                    Label(340, 270 + i * 20, 200, 20, it.Name, Small, Left, true, e);
                    Label(540, 270 + i * 20, 60, 20, it.Number, Small, Left, true, e);
                    Label(600, 270 + i * 20, 190, 20, it.Date, Small, Left, true, e);
                    Label(790, 270 + i * 20, 200, 20, it.Place, Small, Left, true, e);
                    Label(990, 270 + i * 20, 100, 20, "", Small, Left, true, e);
                    itms.RemoveAt(0);
                }
            }
            //Нижние поля
            Label(80, 700, 1069, 35, "Карточку заполнил " + Data.Post + " __________ " + Data.ResponsiblePerson +
                "   " + Date(), Mid, Left, false, e);
            e.HasMorePages = itms.Count > 0;
            PageNum++;
        }
        static void Label(int X, int Y, int W, int H, string Label, Font font, StringFormat format, bool rect, PrintPageEventArgs e)
        {
            //Brush border = Brushes.Black.Clone();
            Pen border = new Pen(Color.Black, 0.5f);
            //e.Graphics.DrawString(Label, font, Brushes.Black, new Rectangle(X, Y, W, H), format);
            e.Graphics.DrawString(Label, font, Brushes.Black, new Rectangle(X, Y, W, H), format);
            if (rect) e.Graphics.DrawRectangle(border, new Rectangle(X, Y, W, H));
        }
        static string Date()
        {
            DateTime now = DateTime.Now;
            string str = now.Day.ToString() + " ";
            switch (now.Month)
            {
                case 1: str += "января"; break;
                case 2: str += "февраля"; break;
                case 3: str += "марта"; break;
                case 4: str += "апреля"; break;
                case 5: str += "мая"; break;
                case 6: str += "июня"; break;
                case 7: str += "июля"; break;
                case 8: str += "августа"; break;
                case 9: str += "сентября"; break;
                case 10: str += "октября"; break;
                case 11: str += "ноября"; break;
                case 12: str += "декабоя"; break;
            }
            str += " " + now.Year.ToString() + " г.";
            return str;
        }
    }
}
