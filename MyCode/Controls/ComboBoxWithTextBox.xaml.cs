using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace MyCode.Controls
{
    /// <summary>
    ///     UserControl where a ComboBox also has an editable TextBox
    /// </summary>

    public sealed partial class ComboBoxWithTextBox : UserControl
    {
        public ComboBoxWithTextBox()
        {
            InitializeComponent();
        }

        public object ComboBoxTextItems
        {
            set { comboBox.SetBinding(ItemsControl.ItemsSourceProperty, value as Binding); }
        }

        public object SelectedComboBoxTextItem
        {
            set { textBox.SetBinding(TextBox.TextProperty, value as Binding); }
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textBox.Text = comboBox.SelectedItem as string;
        }
    }
}