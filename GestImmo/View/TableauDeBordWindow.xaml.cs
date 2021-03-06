﻿using GestImmo.ViewModel;
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

namespace GestImmo.View
{
    /// <summary>
    /// Logique d'interaction pour TableauDeBordWindow.xaml
    /// </summary>
    public partial class TableauDeBordWindow : WindowBase
    {
        public TableauDeBordWindow()
        {
            InitializeComponent();
            // Chargement du contexte
            // Il s'agit du ViewModel que la vue TableauDeBordWindow va consommer
            DataContext = new TableauDeBordViewModel();
        }
    }
}
