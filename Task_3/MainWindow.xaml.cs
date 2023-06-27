using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Xml.Linq;

namespace Task_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Assembly assembly;
        Type[] types;
        string nameFile;
        List<string> element = new List<string>();

        List<Attribute> attributes = new List<Attribute>();
        public MainWindow()
        {
            InitializeComponent();

            ElementBox.Items.Add("Пусто... Відкрийте файл!");
            ElementBox.SelectedIndex = 0;




        }

        private void OpenFile()
        {
            InfoBox.Clear();
            string line = "";

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Все файлы (*.*)|*.*";

            bool? result = openFileDialog.ShowDialog();

            string filePath = default;
            if (result == true)
            {
                filePath = openFileDialog.FileName;
            }
            else
            {
                throw new Exception();
            }

            try
            {
                assembly = Assembly.LoadFile(filePath);
            }
            catch (Exception)
            {

                throw new Exception();
            }

            types = assembly.GetTypes();
            nameFile = line + assembly.FullName + "\n";

            InfoBox.Text += nameFile;

            ElementBox.Items.Clear();

            foreach (Type type in types)
            {
                ElementBox.Items.Add(type.Name);
            }

            ElementBox.SelectedIndex = 0;


        }


        public void ElementReflex()
        {

            Type type = default;
            string line = "";





            for (int i = 0; i < types.Length; i++)
            {
                if (types[i].Name == ElementBox.Text)
                {
                    type = types[i];
                }
            }

            line += "      ";

            if (element.Contains("ListBoxAtribute"))
            {
                InfoBox.Text += line + "Tp-At: " + type.Attributes + "\n";
            }
            InfoBox.Text += line + "Tp: " + type.Name + "\n";


            if (element.Contains("ListBoxBaseClass"))
            {
                Type baseType = type.BaseType;
                while (baseType != null)
                {
                    InfoBox.Text += line + "    " + "Bs: " + baseType.Name + "\n";
                    baseType = baseType.BaseType;
                }

            }

    
                PropertyInfo[] properties = type.GetProperties();
                foreach (var properte in properties)
                {
                    if (element.Contains("ListBoxProperties"))
                    {
                        InfoBox.Text += line + "    " + "Pr: " + properte.Name + "\n";
                    }

                    if (element.Contains("ListBoxAtribute"))
                    {

                        InfoBox.Text += line + "    " + "Pr-At: " + properte.Attributes + "\n";
                    }

                }



            FieldInfo[] fields = type.GetFields();
            foreach (var field in fields)
            {
                if (element.Contains("ListBoxFild"))
                {
                    InfoBox.Text += line + "    " + "Fl: " + field.Name + "\n";

                }

                if (element.Contains("ListBoxAtribute"))
                {

                    InfoBox.Text += line + "    " + "Fl-At: " + field.Attributes + "\n";
                }

            }





            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
            foreach (var method in methods)
            {
                if (element.Contains("ListBoxMethod"))
                {
                    InfoBox.Text += line + "    " + "Mth: " + method.Name + "\n";
                }

                if (element.Contains("ListBoxAtribute"))
                {

                    InfoBox.Text += line + "    " + "M-At: " + method.Attributes + "\n";
                }


            }




            //if (element.Contains("ListBoxAtribute"))
            //{

            //    inf[] methods = ;
            //    foreach (var method in methods)
            //    {
            //        InfoBox.Text += line + "    " + "Mth: " + method.Name + "\n";
            //    }

            //}


            //foreach (Type altype in types)
            //{
            //    if (altype.IsClass)
            //    {
            //        Console.WriteLine(altype.Name);
            //    }
            //}



        }


        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFile();
        }

        private void Подивитись_Click(object sender, RoutedEventArgs e)
        {
            element.Clear();
            InfoBox.Clear();
            InfoBox.Text += nameFile;

            foreach (ListBoxItem selectedItem in ListBoxElement.SelectedItems)
            {
                element.Add(selectedItem.Name);
            }


            ElementReflex();
        }





    }
}
