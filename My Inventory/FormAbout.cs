using System.Drawing;
using System.Windows.Forms;

namespace My_Inventory
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            labelName.Text = Application.ProductName;
            labelVersion.Text = "Версия: " + Application.ProductVersion + " BETA!";
            labelAutor.Text = "Автор программы: Сергей гордеев";

            Font fontR = new Font(history.Font.FontFamily, history.Font.Size, FontStyle.Regular);
            Font fontB = new Font(history.Font.FontFamily, history.Font.Size, FontStyle.Bold);

            history.SelectionFont = fontB;
            history.AppendText("Версия 2.1 (13.10.2020)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Отчёт \" История сотрудника\"\n" +
                "• В журнале перемещений можно включить отображение прежнего хозяина/положения\n" +
                "• Исправлено переименование сотрудника (теперь правятся и все записи с ним связанные)\n" +
                "• Исправлена ошибка сброса фильтра при обновлении данных\n" +
                "• Исправлена ошибка записи серийного номера\n\n");
            
            history.SelectionFont = fontB;
            history.AppendText("Версия 2.0 (28.08.2020)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Переработана система записи базы в файл\n");
            history.AppendText("• Переработан интерфейс создания и редактирования объектов и сотрудников\n");
            history.AppendText("• Ведение истории перемещения для каждого объекта\n");
            history.AppendText("• Общий журнал перемещений теперь формируется динамически\n\n");
            
            history.SelectionFont = fontB;
            history.AppendText("Версия 1.1 (30.06.2017)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Исправлена ошибка \"Вы уверены что хотите true этот предмет ?\"\n");
            history.AppendText("• Добавлено окно About\n");
            history.AppendText("• Перерисована иконка приложения\n\n");
            
            history.SelectionFont = fontB;
            history.AppendText("Версия 1.0 (10.01.2017)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Учёт инвентаря\n");
            history.AppendText("• Просмотр прикреплённых объектов в списке сотрудников\n");
            history.AppendText("• Печать карточек учёта сотрудников\n");
            history.AppendText("• Автоматически формируемые выпадающие списки организаций, подразделений, должностей и местоположений\n");
        }

        private void linkLabelSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Program.Site);
        }
    }
}
