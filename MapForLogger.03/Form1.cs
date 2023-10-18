using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapForLogger._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mapControl.CacheFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MapControl");
            string userAgent = "My non commercial app using for WinFormsMapControl";
            mapControl.TileServer = new OpenStreetMapTileServer(userAgent);
            mapControl.ZoomLevel = 12;
            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mapControl.Center = new GeoPoint(19.93f,50.06f);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var center = mapControl.Center;
            float lat = center.Latitude;
            float lon = center.Longitude;
            MessageBox.Show($"lat = {lat} | lon = {lon}");
            
        }

        private void mapControl_Click(object sender, EventArgs e)
        {
           
        }
    }
}
