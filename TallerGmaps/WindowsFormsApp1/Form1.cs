using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        private List<string[]> values;
        public Form1()
        {
            double Latitud_inicial = 3.341756;
            double longitud_inicial = -76.530881;
            InitializeComponent();
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(Latitud_inicial,longitud_inicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            values = new List<string[]>();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String rutan = openFileDialog1.FileName;
                direc.Text = rutan;
                string[] lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);

                Dictionary<string, PointLatLng> regiones = new Dictionary<string, PointLatLng>();
                foreach (string line in lines)
                {
                    string[] rowLine = line.Split(',');

                    if (!rowLine[0].Equals("MUNICIPIO"))
                    {
                        values.Add(rowLine);
                        
                    }

                    if (!regiones.ContainsKey(rowLine[0]))
                    {
                        regiones.Add(rowLine[0], new PointLatLng(ubicacion(rowLine[3])[0], ubicacion(rowLine[3])[1]));
                        cb.Items.Add(rowLine[0]);
                    }
                }

            }
        }
        public double[] ubicacion(String u)
        {
            Double[] l = new double[2];
            String br = "";
            double d1 = 0;
            double d2 = 0;
            String[] aux;
            for (int i=2; i < u.Length-2; i++) {
                br += u[i];
            }
            aux = br.Split(',');
            d1 = Convert.ToDouble(aux[0]);
            d2 = Convert.ToDouble(aux[1]);
            l[0] = d1;
            l[1] = d2;
            return l;
        }
    }
}
