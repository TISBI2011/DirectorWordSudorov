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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SudorovMA_Cinema.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegInPage.xaml
    /// </summary>
    public partial class RegInPage : Page
    {
        public RegInPage()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            NaitiKinoEntities us = new NaitiKinoEntities();
       
            MessageBox.Show("Пользователь зарегистрирован");
        }
    }
}
