﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Taak1
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

        private void redImage_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Red;            
        }

        private void yellowImage_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Yellow;
        }

        private void greenImage_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Green;
        }

        private void blueImage_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Blue;
        }

        private void MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;

            kleurcodeTextBox.Text = "";
            informatieTextBox.Text = "";
        }

        private void redImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            kleurcodeTextBox.Text = "#FF0000";
            informatieTextBox.Text = "Rood is de kleur van warmte";
        }

        private void yellowImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            kleurcodeTextBox.Text = "#FFFF00";
            informatieTextBox.Text = "Geel is de kleur van levenslust";
        }

        private void greenImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            kleurcodeTextBox.Text = "#008000";
            informatieTextBox.Text = "Groen is de kleur van genezing";
        }

        private void blueImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            kleurcodeTextBox.Text = "#0000FF";
            informatieTextBox.Text = "Blauw is de kleur van intelligentie";
        }
    }
}