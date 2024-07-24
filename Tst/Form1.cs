using System.Windows.Forms;
using static Tst.Configuration.TstConfiguration;
using static Tst.Service.TstService;
namespace Tst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] Day = ["�����", "���", "�����", "�����", "�����", "����", "���"];
            dayWcomboBox.DataSource = Day;
            string[] DayMonth = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"];
            dayMonthcomboBox.DataSource = DayMonth;
            string[] month = ["����", "�������", "�����", "���", "���", "���", "����", "����", "����", "����", "��", "����"];
            monthComboBox.DataSource = month;
            string[] Year = [@"���""�", "���\"�", "���\"�","���\"�","���\"�","���\"�","��\"�","���\"�","���\"�","���\"�","���\"�"];
            yearComboBox.DataSource = Year;
        }

        private string GetStringDay( string dayW)
        {
            string day = dayW switch
            {
                "�����" => "��� ����",
                "���" => "��� ����",
                "�����" => "����� ����",
                "�����" => "����� ����",
                "�����" => "����� ����",
                "���" => "��� ����",
                "���" => "���",
                _ => string.Empty,
            };
            return day;
        }

        private string GetStringDayMonth(string dayM)
        {
            string dayMon = dayM switch
            {
                "1" => "��� ��� ����",
                "2" => "��� ���� ����",
                "3" => "���� ���� ����",
                "4" => "����� ���� ����",
                "5" => "���� ���� ����",
                "6" => "��� ���� ����",
                "7" => "���� ���� ����",
                "8" => "����� ���� ����",
                "9" => "���� ���� ����",
                "10" => "���� ���� ����",
                "11" => "��� ���� ���� ����",
                "12" => "���� ��� ���� ����",
                "13" => "���� ��� ���� ����",
                "14" => "  ����� ������� ����",
                "15" => "���� ��� ���� ����",
                "16" => "�� ���� ���� ����",
                "17" => "���� ���� ���� ����",
                "18" => "����� ���� ���� ����",
                "19" => "���� ���� ���� ����",
                "20" => "�����  ���� ����",
                "21" => "����� ���� ���� ���",
                "22" => "���� ������ ����",
                "23" => "����� ������ ����",
                "24" => "���� ������ ����",
                "25" => "���� ������ ����",
                "26" => "��� ������ ����",
                "27" => "���� ������ ����",
                "28" => "����� ������ ����",
                "29" => "���� ������ ����",
                "30" => "������ ���� ����",
                _ => string.Empty,
            };
            return dayMon;
        }

        private string GetStringYear(string year)
        {
            string y = year switch
            {
               
                @"���""�" => "���� ����� ���� ���� ������ ����� ������ �����",
                @"���""�"=> "���� ����� ���� ���� ������ ���� ������ �����",
                "�����" => "����� ����",
                "�����" => "����� ����",
                "���" => "��� ����",
                "���" => "���",
                _ => string.Empty,
            };
            return y;
        }


        private void Enterbutton_Click(object sender, EventArgs e)
        {
            CreatXmlIfNoExist();
            AddTst();
            AddtDey(dayWcomboBox.Text);
            AddDeyMonth(int.Parse(dayMonthcomboBox.Text));
            AddMonth(monthComboBox.Text);
            AddYear(yearComboBox.Text);
            AddResult($"{GetStringDay(dayWcomboBox.Text)} {GetStringDayMonth(dayMonthcomboBox.Text)} {monthComboBox.Text} {GetStringYear(yearComboBox.Text)} ");
            MessageBox.Show($"{GetStringDay(dayWcomboBox.Text)} {GetStringDayMonth(dayMonthcomboBox.Text)} {monthComboBox.Text} {GetStringYear(yearComboBox.Text)} ");
        }
    }
}
