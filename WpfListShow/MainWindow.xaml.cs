using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace WpfListShow
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ObservableCollection<Member> memberData = new ObservableCollection<Member>();
            memberData.Add(new Member()
            {
                Name = "Joe",
                Age = "23",
                Sex = SexOpt.Male,
                Pass = true,
                Email = new Uri("mailto:Joe@school.com")
            });
            memberData.Add(new Member()
            {
                Name = "Mike",
                Age = "20",
                Sex = SexOpt.Male,
                Pass = false,
                Email = new Uri("mailto:Mike@school.com")
            });
            memberData.Add(new Member()
            {
                Name = "Lucy",
                Age = "25",
                Sex = SexOpt.Female,
                Pass = true,
                Email = new Uri("mailto:Lucy@school.com")
            });
           // dataGrid.DataContext = memberData;
            string s = "sun";
            List<string> infoList = new List<string>();
            infoList.Add(s);
            dataGrid.ItemsSource = infoList;
            //dataGrid.Columns.Add
        }
        public enum SexOpt { Male, Female };

        public class Member
        {
            public string Name { get; set; }
            public string Age { get; set; }
            public SexOpt Sex { get; set; }
            public bool Pass { get; set; }
            public Uri Email { get; set; }
            public Uri Date { get; set; }
        }
    }
}
