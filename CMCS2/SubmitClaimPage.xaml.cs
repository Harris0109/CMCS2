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
using Microsoft.Win32;

namespace CMCS2
{
    using Microsoft.Win32;

    public partial class SubmitClaimPage : Page
    {
        private string uploadedFilePath;

        public SubmitClaimPage()
        {
            InitializeComponent();
        }

        private void UploadFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Document files (*.pdf;*.docx;*.xlsx)|*.pdf;*.docx;*.xlsx",
                Title = "Select a document"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                uploadedFilePath = openFileDialog.FileName;
                FileNameTextBlock.Text = $"File selected: {System.IO.Path.GetFileName(uploadedFilePath)}";
            }
            else
            {
                FileNameTextBlock.Text = "No file selected";
            }
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LecturerNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(HoursWorkedTextBox.Text) ||
                string.IsNullOrWhiteSpace(HourlyRateTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (string.IsNullOrEmpty(LecturerIDTextBox.Text) ||
               ClaimTypeComboBox.SelectedItem == null ||
               string.IsNullOrEmpty(ClaimDescriptionTextBox.Text))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            string lecturerID = LecturerIDTextBox.Text;
            string claimType = ((ComboBoxItem)ClaimTypeComboBox.SelectedItem).Content.ToString();
            string claimDescription = ClaimDescriptionTextBox.Text;

            MessageBox.Show($"Claim submitted for {LecturerNameTextBox.Text}. Document: {uploadedFilePath ?? "No file uploaded"}");
        }



    }

}
