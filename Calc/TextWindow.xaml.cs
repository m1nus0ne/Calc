using System.Windows;

namespace Calc
{
    public partial class TextWindow : Window
    {
        public TextWindow()
        {
            InitializeComponent();
        }

        public void Update(string text)
        {
            TextBox.Text = text;
        }
    }
}