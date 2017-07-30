using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace GestImmo.View
{
    public class WindowBase : Window
    {
        protected void GoTo_RecapitulatifPaiments(object sender, RoutedEventArgs e)
        {
            // TODO
        }

        protected void GoTo_Frais(object sender, RoutedEventArgs e)
        {
            // TODO
        }

        protected void GoTo_Logement(object sender, RoutedEventArgs e)
        {
            LogementWindow logementWindow = new LogementWindow();
            App.Current.MainWindow = logementWindow;
            this.Close();
            logementWindow.Show();
        }

        protected void GoTo_Remboursements(object sender, RoutedEventArgs e)
        {
            // TODO
        }

        protected void GoTo_SynthèseFinanciere(object sender, RoutedEventArgs e)
        {
            // TODO
        }

        protected void GoTo_TableauDeBord(object sender, RoutedEventArgs e)
        {
            TableauDeBordWindow tableauDeBordWindow = new TableauDeBordWindow();
            App.Current.MainWindow = tableauDeBordWindow;
            this.Close();
            tableauDeBordWindow.Show();
        }
    }
}
