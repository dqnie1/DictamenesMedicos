﻿using System;
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
using System.Windows.Shapes;

namespace DictamenesMedicos.View
{
    /// <summary>
    /// Interaction logic for HomePaciente.xaml
    /// </summary>
    public partial class HomePaciente : Window
    {
        public HomePaciente()
        {
            InitializeComponent();
        }
        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); // Morimos la aplicación
        }

        private void btnMisCitas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMisDictamenes_Click()
        {

        }
    }
}
