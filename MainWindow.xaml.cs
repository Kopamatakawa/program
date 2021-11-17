using System;
using System.Collections.Generic;
using System.IO;
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

namespace CopyFilesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var taskNumber = TaskNumber.Text;
            string sourcePath = @"Z:\";
            string targetPath = @"S:\Common\IT\Public\Rozmowy-reklamacje\";
            string[] fileNamesArray = fileNames.Text.GetLines().ToArray();

            if (taskNumber == null || taskNumber.Equals(""))
            {
                MessageBox.Show("Uzupełnij numer zgłoszenia!");
            } else
            {
                targetPath = System.IO.Path.Combine(targetPath, taskNumber);
                System.IO.Directory.CreateDirectory(targetPath);
                if(fileNames.Text.Equals(""))
                {
                    MessageBox.Show("Wprowadź przynajmniej jedną nazwę pliku!");
                } else
                {
                   foreach(var file in fileNamesArray)
                    {
                        string fileSourcePath = System.IO.Path.Combine(sourcePath,file);
                        string fileTargetPath = System.IO.Path.Combine(targetPath,file);
                        System.IO.File.Copy(fileSourcePath, fileTargetPath, true);
                    }                   
                }
            }
           
        }

        private void TaskNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
