using System.Text;
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
 
    public partial class MainWindow : Window
    {
        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            SubmitClaimPage submitClaimPage = new SubmitClaimPage();
            this.Content = submitClaimPage;
        }

        private void ViewClaim_Click(object sender, RoutedEventArgs e)
        {
            ViewClaimPage viewClaimPage = new ViewClaimPage();
            this.Content = viewClaimPage;
        }

        private void Admin_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            this.Content = loginWindow;
        }

    }
}