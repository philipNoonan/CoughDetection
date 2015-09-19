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

using Accord.Audio;
using Accord.Audition.Beat;
using Accord.DirectSound;

namespace CoughDetection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IAudioSource source;
        private EnergyBeatDetector detector;
        private Metronome metronome;
        private Signal current;

        private List<ComplexSignal> sample;
        private bool initializing = true;

        public MainWindow()
        {
            InitializeComponent();

            metronome = new Metronome();
            metronome.SynchronizingObject = lbManualTempo;
            metronome.TempoDetected += metronome_TempoDetected;

        }
    }
}
