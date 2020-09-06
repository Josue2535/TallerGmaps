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
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        GMapOverlay marker;
        GMapOverlay poligons;
        GMapOverlay routes;
        DataTable dt;
        private MinTic minT;
        public Form1()
        {
            marker = new GMapOverlay("marker");
            poligons = new GMapOverlay("poligonos");
            routes = new GMapOverlay("routes");

            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            minT = new MinTic();
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
                        minT.addMunicipio(rowLine[0]);
                        if (minT.findZona(rowLine[0],rowLine[1],rowLine[2],ubicacion(rowLine[3]), ubicacion(rowLine[4]))==null)
                        {
                            minT.addZona(rowLine[0], rowLine[1], rowLine[2], ubicacion(rowLine[3]), ubicacion(rowLine[4]));
                            
                        }
                    }

                    
                }

                for (int i = 0; i < minT.showMunicipios().Count; i++) {
                    cbMuni.Items.Add(minT.showMunicipios()[i]);
                }

            }
        }
        public double ubicacion(String u)
        {
            String br = "";
            double d1 = 0;
            for (int i=0; i < u.Length; i++) {
                if (u[i] == '"')
                {

                }
                else if (u[i] == '.') {
                    br += ",";
                }
                else if (u[i] == ')' || u[i] == '(')
                {
                }
                else
                {
                    br += u[i];
                }
                
            }
            
            ltest.Text = br;

            d1 = double.Parse(br);
            return d1;
        }

        private void cbMuni_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < minT.showUbicacion(cbMuni.SelectedItem.ToString()).Count; i++) {
                cbLp.Items.Add(minT.showUbicacion(cbMuni.SelectedItem.ToString()));
            }
        }

        private void cbAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbLp_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string[] row in values)
            {
                if (cbLp.SelectedItem.Equals(row[1]))
                {
                    cbAd.Items.Add(row[2]);
                }
            }
        }

        private void Gmap_Load(object sender, EventArgs e)
        {
            double Latitud_inicial = 3.341756;
            double longitud_inicial = -76.530881;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(Latitud_inicial, longitud_inicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;
            gMapControl1.Overlays.Add(routes);
            gMapControl1.Overlays.Add(marker);
            gMapControl1.Overlays.Add(poligons);
        }

        private void setMarkers() { 
        
        }
    }
}
