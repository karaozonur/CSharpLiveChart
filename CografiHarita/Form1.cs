using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CografiHarita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap gMaps = new LiveCharts.WinForms.GeoMap();
            Dictionary<string, double> keyValues = new Dictionary<string, double>();
            keyValues["AYD"] = 100;
            keyValues["ML"] = 999;
            //keyValues["BG"] = 1;

           //var lang=new Dictionary<string, string>();
           // lang["TR"] = "TÜRKİYE";

            gMaps.HeatMap = keyValues;
            gMaps.Source = "Turkey.xml";
            //gMaps.LanguagePack = lang;

            this.Controls.Add(gMaps);
            gMaps.Dock = DockStyle.Fill;
        
        }
    }
}
