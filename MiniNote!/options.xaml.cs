using System;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Win32;
using System.IO;

namespace QNote
{
    public partial class options : Window
    {
        public options()
        {
            InitializeComponent();
            try
            {
                TextReader optionsReader = File.OpenText(@"C:\Users\Public\Documents\QNote\options.txt");
                fontOption.Text = optionsReader.ReadLine();
                fontColor.Text = optionsReader.ReadLine();
                notepadColor.Text = optionsReader.ReadLine();
                backgroundColor.Text = optionsReader.ReadLine();
                optionsReader.Close();
            }
            catch
            {
                fontOption.Text = "Default Font";
                fontColor.Text = "Default Color";
                notepadColor.Text = "Default Color";
                backgroundColor.Text = "Default Color";
            }
        }
        
        

        private void applyButton_Click(object sender, RoutedEventArgs e)
        {
            TextWriter optionsWriter = new StreamWriter(@"C:\Users\Public\Documents\QNote\options.txt");
            optionsWriter.WriteLine(fontOption.Text);
            optionsWriter.WriteLine(fontColor.Text);
            optionsWriter.WriteLine(notepadColor.Text);
            optionsWriter.WriteLine(backgroundColor.Text);
            optionsWriter.Close();

            MessageBox.Show("Changes that will be applied the next time you run QNote");
            Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) //gives you the ability to drag app without windows frames
        {
            DragMove();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}