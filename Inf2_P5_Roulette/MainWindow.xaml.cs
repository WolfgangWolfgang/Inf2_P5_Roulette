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

namespace Inf2_P5_Roulette
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

        /// <summary>
        /// Ruft in einem neuen Fenster die Bestenliste der ersten n - besten Spiele auf 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuBestenListe_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Menu: Ruft in einem neuen Fenster Die Hilfe / Spielanleitung auf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuHilfe_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Eventuell Unnötig, jenach Benutzung zu Entfernen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuSave_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Menu: Beendet Sofort das gesamte Programm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Schwierigkeitsgrad: Setzt den Schwierigkeitsgrad auf Normal <-- Alles zufällig
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuNormal_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Schwierigkeitsgrad: Setzt den Schwirigkeitsgrad auf Unbesiegbar <-- Gegner setzt nach dem Spieler und Tippt IMMER richtig!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuUnbesiegbar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
