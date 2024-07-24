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
            string[] Day = ["ראשון", "שני", "שלישי", "רביעי", "חמישי", "שישי", "שבת"];
            dayWcomboBox.DataSource = Day;
            string[] DayMonth = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"];
            dayMonthcomboBox.DataSource = DayMonth;
            string[] month = ["תשרי", "מרחשוון", "כסליו", "טבת", "שבט", "אדר", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול"];
            monthComboBox.DataSource = month;
            string[] Year = [@"תשפ""ד", "תשפ\"ה", "תשפ\"ו","תשפ\"ז","תשפ\"ח","תשפ\"ט","תש\"צ","תשצ\"א","תשצ\"ב","תשצ\"ג","תשצ\"ד"];
            yearComboBox.DataSource = Year;
        }

        private string GetStringDay( string dayW)
        {
            string day = dayW switch
            {
                "ראשון" => "אחד בשבת",
                "שני" => "שני בשבת",
                "שלישי" => "שלישי בשבת",
                "רביעי" => "רביעי בשבת",
                "חמישי" => "חמישי בשבת",
                "ששי" => "ששי בשבת",
                "שבת" => "שבת",
                _ => string.Empty,
            };
            return day;
        }

        private string GetStringDayMonth(string dayM)
        {
            string dayMon = dayM switch
            {
                "1" => "יום אחד לירח",
                "2" => "שני ימים לירח",
                "3" => "שלשה ימים לירח",
                "4" => "ארבעה ימים לירח",
                "5" => "חמשה ימים לירח",
                "6" => "ששה ימים לירח",
                "7" => "ימים לירח שבעה",
                "8" => "שמונה ימים לירח",
                "9" => "תשעה ימים לירח",
                "10" => "עשרה ימים לירח",
                "11" => "אחד עשרה ימים לירח",
                "12" => "שנים עשר ימים לירח",
                "13" => "שלשה עשר ימים לירח",
                "14" => "  ארבעה עשרימים לירח",
                "15" => "חמשה עשר ימים לירח",
                "16" => "שש עשרה ימים לירח",
                "17" => "שבעה עשרה ימים לירח",
                "18" => "שמונה עשרה ימים לירח",
                "19" => "תשעה עשרה ימים לירח",
                "20" => "עשרים  ימים לירח",
                "21" => "עשרים ואחד לירח שבת",
                "22" => "שנים ועשרים לירח",
                "23" => "שלושה ועשרים לירח",
                "24" => "ארעה ועשרים לירח",
                "25" => "חמשה ועשרים לירח",
                "26" => "ששה ועשרים לירח",
                "27" => "שבעה ועשרים לירח",
                "28" => "שמונה ושערים לירח",
                "29" => "תשעה ועשרים לירח",
                "30" => "שלושים ימים לירח",
                _ => string.Empty,
            };
            return dayMon;
        }

        private string GetStringYear(string year)
        {
            string y = year switch
            {
               
                @"תשפ""ד" => "חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם",
                @"תשפ""ה"=> "חמשת אלפים ושבע מאות ושמנים וחמש לבריאת העולם",
                "רביעי" => "רביעי בשבת",
                "חמישי" => "חמישי בשבת",
                "ששי" => "ששי בשבת",
                "שבת" => "שבת",
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
