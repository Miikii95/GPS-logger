using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MapForLogger._03
{
    public partial class Form1 : Form
    {
        private string _rawFile;
        private string _appDataFolder;
        private List<GeoPoint> _track;

        public Form1()
        {
            InitializeComponent();
            _appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                                                    Assembly.GetExecutingAssembly().GetName().Name);
            mapControl.CacheFolder = _appDataFolder;
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
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _rawFile = dialog.FileName;
                tb_file.Text = _rawFile;
            }
            _track=  readPoints(_rawFile);
        }

        private void mapControl_Click(object sender, EventArgs e)
        {
           
        }

        public List<GeoPoint> readPoints (string pathToRawFile)
        {
            string[] lines = File.ReadAllLines(pathToRawFile);
            List<GeoPoint> points = new List<GeoPoint>();
            foreach (string line in lines)
            {
                if (line == "Program started!")
                {

                    continue;
                }
                if (line == "") { continue; }

                string[] data = line.Split(';');
                string[] time = data[0].Split(':');
                int hour = int.Parse(time[0]);
                int minute = int.Parse(time[1]);
                int second = int.Parse(time[2]);
                float lat = float.Parse(data[1].Substring(6), CultureInfo.InvariantCulture);
                float lon = float.Parse(data[2].Substring(6), CultureInfo.InvariantCulture);
                //DateTime dateTime = new DateTime(1, 1, 1, hour, minute, second);

                points.Add(new GeoPoint(longitude: lon, latitude: lat)); //LONGITURE AND LATITUDE ARE !!!FLIPPED!!! IN GEO POINT CONSTRUCTOR
                                                                         // flipped in comapre to standard geograpihic notation
                                                                         //or mayby I am wrong....
            }
            return points;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var points = _track;

            // Creating a track with default style
            var track = new Track(TrackStyle.Default);

            // Add points to the track
            track.AddRange(points);

            // Add track to the map
            mapControl.Tracks.Add(track);
        }
    }//Form1
}//namespace
