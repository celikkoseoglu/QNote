using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Win32;
using System.IO;
//using System.Threading.Tasks;

namespace QNote //Çelik Köseoğlu Tarafından Yazılmış ve Geliştirilmiştir! (Turkish)
{
    public partial class MainWindow : Window
    {
        private OpenFileDialog openFileDialog = null;
        //private string xCoord;
        //private string yCoord;

        public MainWindow()
        {
            InitializeComponent();
            try
            {
                TextReader reader = File.OpenText(@"C:\Users\Public\Documents\QNote\QNoteSaved.txt"); //creates reader
                source.Text = reader.ReadToEnd(); //uses reader to restore your notes

                //reader = File.OpenText(@"C:\Users\Public\Documents\QNote\WindowCoordinates.txt");
                //string xCoord = reader.ReadLine();
                //string yCoord = reader.ReadLine();

                try
                {

                    reader = File.OpenText(@"C:\Users\Public\Documents\QNote\options.txt");
                    source.FontFamily = new FontFamily(reader.ReadLine()); //sets font to custom value
                    string fontColorOption = reader.ReadLine(); //uses reader to restore font preference
                    string notepadColorOption = reader.ReadLine();
                    string backgroundColorOption = reader.ReadLine();
                    reader.Close();

                    if (fontColorOption == "Cyan")
                    {
                        source.Foreground = Brushes.Cyan;
                    }
                    else if (fontColorOption == "Purple")
                    {
                        source.Foreground = Brushes.Purple;
                    }
                    else if (fontColorOption == "Lightblue")
                    {
                        source.Foreground = Brushes.LightBlue;
                    }
                    else if (fontColorOption == "Darkblue")
                    {
                        source.Foreground = Brushes.DarkBlue;
                    }
                    else if (fontColorOption == "Blue")
                    {
                        source.Foreground = Brushes.Blue;
                    }
                    else if (fontColorOption == "Lightgreen")
                    {
                        source.Foreground = Brushes.LightGreen;
                    }

                    if (notepadColorOption == "Cyan")
                    {
                        source.Background = Brushes.Cyan;
                        fileName.Background = Brushes.Cyan;
                    }
                    else if (notepadColorOption == "Purple")
                    {
                        source.Background = Brushes.Purple;
                        fileName.Background = Brushes.Purple;
                    }
                    else if (notepadColorOption == "Lightblue")
                    {
                        source.Background = Brushes.LightBlue;
                        fileName.Background = Brushes.LightBlue;
                    }
                    else if (notepadColorOption == "Darkblue")
                    {
                        source.Background = Brushes.DarkBlue;
                        fileName.Background = Brushes.DarkBlue;
                    }
                    else if (notepadColorOption == "Blue")
                    {
                        source.Background = Brushes.Blue;
                        fileName.Background = Brushes.Blue;
                    }

                    if (backgroundColorOption == "Cyan")
                    {
                        main_window.Background = Brushes.Cyan;
                        developerName.Foreground = Brushes.Black;
                    }
                    else if (backgroundColorOption == "Purple")
                    {
                        main_window.Background = Brushes.Purple;
                        developerName.Foreground = Brushes.White;
                    }
                    else if (backgroundColorOption == "Lightblue")
                    {
                        main_window.Background = Brushes.LightBlue;
                        developerName.Foreground = Brushes.Black;
                    }
                    else if (backgroundColorOption == "Darkblue")
                    {
                        main_window.Background = Brushes.DarkBlue;
                        developerName.Foreground = Brushes.White;
                    }
                    else if (backgroundColorOption == "Blue")
                    {
                        main_window.Background = Brushes.Blue;
                        developerName.Foreground = Brushes.White;
                    }
                }

                catch
                {
                    developerName.Content = "Try Options button for Personalization";
                }
            }
            catch //if fails (if program runs for the first time) creates required directories
            {
                Directory.CreateDirectory(@"C:\Users\Public\Documents\QNote");
                //File.CreateText(@"C:\Users\Public\Documents\QNote\options.txt");
                source.Text = "Seems like you are running this application for the first time...\nThis place is for you to take your notes.\nYou can customize this window from the options menu.\nAlso you can easily close this app by pressing escape button.\nHit that Clear TextBox button and get started!";
            }
            /*Task first = Task.Factory.StartNew(() => StartApp());
            Task.WaitAll(first);*/
        }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("This will replace your notes with the file you opened. Are you sure?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                openFileDialog = new OpenFileDialog();
                openFileDialog.FileOk += openFileDialogFileOk;
                openFileDialog.Filter = "Text (*.txt)|*.txt"; //specifies file types to open | openFileDialog.Filter = "Bitmap|*.bmp|All|*.*";
                openFileDialog.ShowDialog();
            }   
        }

        private void openFileDialogFileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string fullPathname = openFileDialog.FileName;
            FileInfo src = new FileInfo(fullPathname);
            fileName.Text = src.Name;

            try
            {
                source.Text = "";
                TextReader reader = src.OpenText();
                source.Text = reader.ReadToEnd();
                reader.Close();
            }
            catch (OverflowException oEx)
            {
                fileName.Text = oEx.Message;
            }
        }

        private void clearTextBox_Click(object sender, RoutedEventArgs e) //asks confirmation for deleting notes
        {
            if (MessageBox.Show("Do you want to erase your notes?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                source.Text = null;
            }  
        }

        private void optionsButton_Click(object sender, RoutedEventArgs e) //opens options window when options button is clicked
        {
            var optionsWindow = new options();
            optionsWindow.Show();
        }

        protected override void OnClosed(EventArgs e) //things that the program must do on close
        {
            base.OnClosed(e);
            TextWriter save = new StreamWriter(@"C:\Users\Public\Documents\QNote\QNoteSaved.txt"); //saves your notes to specified directory
            save.WriteLine(source.Text);
            save.Close();
            /*save = new StreamWriter(@"C:\Users\Public\Documents\QNote\WindowCoordinates.qnote");
            save.WriteLine(xCoord);
            save.WriteLine(yCoord);
            save.Close();*/
        }

        private void esc_keyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Close();
            }
        }

        private void close_button_Click(object sender, RoutedEventArgs e) //saves text on close to specified directory
        {
            Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) //gives you the ability to drag app without windows frames
        {
            DragMove();
        }

        /*private void mainWindowSizeChanged(object sender, SizeChangedEventArgs e)
        {
            xCoord = this.ActualHeight.ToString();
            yCoord = this.ActualWidth.ToString();
        }*/
    }
}