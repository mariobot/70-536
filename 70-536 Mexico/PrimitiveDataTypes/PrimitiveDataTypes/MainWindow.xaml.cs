using System.Windows;
using System.Windows.Controls;

namespace PrimitiveDataTypes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Show basic find functions (Edit/Find And Replace/Quick Find[CTRL+F])
    /// Locate methods using the drop-down list above the text editor
    /// </summary>

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void typeSelectionChange(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selectedType = (type.SelectedItem as ListBoxItem);
            switch (selectedType.Content.ToString())
            {
                case "int":
                    showIntValue();
                    break;
                case "long":
                    showLongValue();
                    break;
                case "float":
                    showFloatValue();
                    break;
                case "double":
                    showDoubleValue();
                    break;
                case "decimal":
                    showDecimalValue();
                    break;
                case "string":
                    showStringValue();
                    break;
                case "char":
                    showCharValue();
                    break;
                case "bool":
                    showBoolValue();
                    break;
            }
        }

        private void showIntValue()
        {
          int variable;
          variable = 42;
          value.Text = "42";
          }

        private void showLongValue()
        {
            long variable;
            variable = 42L;
            value.Text = "42L";
        }

        private void showFloatValue()
        {
            float variable; // Esta sentencia declara una variable del tipo float
            variable = 0.42F; // Esta sentencia asigna el valor a la variable. La F especifica que este valor sea tratado como float
            value.Text = "0.42F"; // Esta sentencia despliega el valor de la variable en la propiedad text del control textbox   
        }

        private void showDoubleValue()
        {
            double variable;
            variable = 0.42;
            value.Text = "0.42";
        }

        private void showDecimalValue()
        {
            decimal variable;
            variable = 0.42M;
            value.Text = "0.42M";
        }

        private void showStringValue()
        {
            string variable;
            variable = "42";
            value.Text = "\"forty two\"";
        }

        private void showCharValue()
        {
            char variable;
            variable = '4';
            value.Text = "'x'";
        }

        private void showBoolValue()
        {
            bool variable;
            variable = false;
            value.Text = "false";
        }

        private void quitClick(object sender, RoutedEventArgs e)
        {
            //añadir interactividad con teclado al botón (_)
            this.Close();
        }
    }
}