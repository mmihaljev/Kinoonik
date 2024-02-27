using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SlanjeObavijesti
{
    public partial class SlanjeObavijesti : ServiceBase
    {
        public SlanjeObavijesti()
        {
            InitializeComponent();
        }

        // Funkcija pokreće tajmer koji traje 1000ms tj. jednu sekundu
        // i koji po završetku pokreće funkciju "OnTimer" koja vodi u RepozitorijObavijest
        // gdje se provjerava jesu li ispunjeni uvjeti za slanje obavijesti
        protected override void OnStart(string[] args)
        {
            Timer timer = new Timer();
            timer.Interval = 1000; 
            timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        protected override void OnStop()
        {

        }

        public void OnTimer(object sender, ElapsedEventArgs args)
        {
            RepozitorijObavijest.ProvjeriUvjete();
        }
    }
}
