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
using System.Windows.Media.Animation;
using Syncfusion.UI.Xaml.ProgressBar;

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       
        MediaPlayer mp = new MediaPlayer();
        MediaPlayer mp1 = new MediaPlayer();

        public MainWindow()
        {

            InitializeComponent();




            soundstart();



        }
        public void soundstart()
        {
           
            mp.Open(new Uri("C:\\Users\\suresh.pranadarth\\Downloads\\PokersNeonLight\\WpfApp8\\Sound\\Flicker.mp3"));
            mp.Play();

            mp1.Open(new Uri("C:\\Users\\suresh.pranadarth\\Downloads\\PokersNeonLight\\WpfApp8\\Sound\\Light.mp3"));
            mp1.Play();
            mp1.SpeedRatio = 2.5;

        }
       
    }
}
