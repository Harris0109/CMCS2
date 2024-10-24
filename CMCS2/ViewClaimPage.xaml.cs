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

namespace CMCS2
{
  
    public partial class ViewClaimPage : Page
    {
        public ViewClaimPage()
        {
            InitializeComponent();

            var claims = new List<Claim>
        {
            new Claim { LecturerName = "John Doe", HoursWorked = 10, HourlyRate = 50, Status = "Pending" },
            new Claim { LecturerName = "Jane Smith", HoursWorked = 8, HourlyRate = 60, Status = "Accepted" },
        };

            ClaimsDataGrid.ItemsSource = claims;
        }

        public class Claim
        {
            public string LecturerName { get; set; }
            public double HoursWorked { get; set; }
            public decimal HourlyRate { get; set; }
            public string Status { get; set; }
        }
    }

}
