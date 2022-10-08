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

namespace ThirdPractice
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

        private void CommandBinding_ExecutedBoldCommand(object sender, ExecutedRoutedEventArgs e)
        {
            richTextBox.FontWeight = FontWeights.Bold;
        }
        private void BoldButton_Click(object sender, RoutedEventArgs e)
        {
            richTextBox.FontWeight = FontWeights.Bold;
        }
        private void CommandBinding_ExecutedItalicCommand(object sender, ExecutedRoutedEventArgs e)
        {
            richTextBox.FontStyle = FontStyles.Italic;
        }
        private void ItalicButton_Click(object sender, RoutedEventArgs e)
        {
            richTextBox.FontStyle = FontStyles.Italic;
        }
        private void CommandBinding_ExecutedUnderlineCommand(object sender, ExecutedRoutedEventArgs e)
        {
            richTextBox.SelectAll();
            richTextBox.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
        }
        private void UnderlineButton_Click(object sender, RoutedEventArgs e)
        {
            richTextBox.SelectAll();
            richTextBox.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
        }
        private void CommandBinding_ExecutedClearCommand(object sender, ExecutedRoutedEventArgs e)
        {
            // убрать все стили с текста в richtextbox
            richTextBox.Selection.ClearAllProperties();
            richTextBox.FontStyle = FontStyles.Normal;
            richTextBox.FontWeight = FontWeights.Normal;
            richTextBox.FontSize = 8.95;
            richTextBox.FontFamily = new FontFamily("Cascadia Mono");
            richTextBox.Foreground = Brushes.Black;
        }
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            richTextBox.Selection.ClearAllProperties();
            richTextBox.FontStyle = FontStyles.Normal;
            richTextBox.FontWeight = FontWeights.Normal;
            richTextBox.FontSize = 8.95;
            richTextBox.FontFamily = new FontFamily("Cascadia Mono");
            richTextBox.Foreground = Brushes.Black;
        }
        private void CommandBinding_ExecutedFont15Command(object sender, ExecutedRoutedEventArgs e)
        {
            richTextBox.FontSize = 15;
        }
        private void Font15Button_Click(object sender, RoutedEventArgs e)
        {
            richTextBox.FontSize = 15;
        }
        private void CommandBinding_ExecutedFont30Command(object sender, ExecutedRoutedEventArgs e)
        {
            richTextBox.FontSize = 30;
        }
        private void Font30Button_Click(object sender, RoutedEventArgs e)
        {
            richTextBox.FontSize = 30;
        }
        private void CommandBinding_ExecutedRedCommand(object sender, ExecutedRoutedEventArgs e)
        {
            richTextBox.Foreground = Brushes.Red;
        }
        private void RedButton_Click(object sender, RoutedEventArgs e)
        {
            richTextBox.Foreground = Brushes.Red;
        }
        private void CommandBinding_ExecutedGreenCommand(object sender, ExecutedRoutedEventArgs e)
        {
            richTextBox.Foreground = Brushes.Green;
        }
        private void GreenButton_Click(object sender, RoutedEventArgs e)
        {
            richTextBox.Foreground = Brushes.Green;
        }
        private void CommandBinding_ExecutedBlueCommand(object sender, ExecutedRoutedEventArgs e)
        {
            richTextBox.Foreground = Brushes.Blue;
        }
        private void BlueButton_Click(object sender, RoutedEventArgs e)
        {
            richTextBox.Foreground = Brushes.Blue;
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RoutedCommands.ImageCrimea imageWindows = new RoutedCommands.ImageCrimea();
            imageWindows.Show();
        }
    }

    class FormatingCommands
    {
        static FormatingCommands()
        {
            BoldCommand             = new RoutedCommand("BoldCommand", typeof(FormatingCommands));
            ItalicCommand           = new RoutedCommand("ItalicCommand", typeof(FormatingCommands));
            UnderlineCommand        = new RoutedCommand("UnderlineCommand", typeof(FormatingCommands));
            ClearstylesCommand      = new RoutedCommand("ClearstylesCommand", typeof(FormatingCommands));
            Font15Command           = new RoutedCommand("Font15Command", typeof(FormatingCommands));
            Font30Command           = new RoutedCommand("Font30Command", typeof(FormatingCommands));
            RedCommand              =  new RoutedCommand("RedCommand", typeof(FormatingCommands));
            BlueCommand             = new RoutedCommand("BlueCommand", typeof(FormatingCommands));
            GreenCommand            = new RoutedCommand("GreenCommand", typeof(FormatingCommands));

        }

        public static RoutedCommand BoldCommand         { get; set; }
        public static RoutedCommand ItalicCommand       { get; set; }
        public static RoutedCommand UnderlineCommand    { get; set; }
        public static RoutedCommand ClearstylesCommand  { get; set; }
        public static RoutedCommand Font15Command       { get; set; }
        public static RoutedCommand Font30Command       { get; set; }
        public static RoutedCommand RedCommand          { get; set; }
        public static RoutedCommand BlueCommand         { get; set; }
        public static RoutedCommand GreenCommand        { get; set; }
    }
}
