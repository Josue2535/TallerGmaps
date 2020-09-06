using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class ZonaWifi
    {
        private String pUbicacion;
        private String direccion;
        private double latitud;
        private double longitud;

        public ZonaWifi( String pUbicacion, String direccion, double latitud, double longitud) { 
            this.pUbicacion = pUbicacion;
            this.direccion = direccion;
            this.latitud = latitud;
            this.longitud = longitud;
        }

        

        public String getPUbicacion() {
            return pUbicacion;
        }
        public String getDireccion() {
            return direccion;
        }

        public double getLatitud() {
            return latitud;
        }

        public double getLongitud() {
            return longitud;
        }

        public double distance(double la, double lo) {
            return Math.Sqrt(Math.Pow(la - latitud, 2) + Math.Pow(lo - longitud, 2));
        }

    }
}
