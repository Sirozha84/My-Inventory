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
        public static void RegistryCard()
        {        
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
            Font font = new Font("Arial", 3, FontStyle.Regular, GraphicsUnit.Millimeter);
            e.Graphics.DrawString("Организация", font, Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("Организация", font, Brushes.Black, new Rectangle(100, 100,50,50));
            //e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, 827, 1169));
            //e.Graphics.DrawRectangle(Pens.Black, new Rectangle(2, 2, 823, 1165));
            //e.Graphics.DrawRectangle(Pens.Black, new Rectangle(4, 4, 819, 1161));


        }
    }
}
