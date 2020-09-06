using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class Municipio
    {
        private String nombre;
        private List<ZonaWifi> zonas;

        public Municipio(String nombre){
            this.nombre = nombre;
            zonas = new List<ZonaWifi>();
        }
        public String getNombre() {
            return nombre;
        }
        public List<ZonaWifi> Zonas {
            get => zonas;
        }

        public void addZona(String pUbicacion, String direccion, double latitud, double longitud) {
            zonas.Add(new ZonaWifi(pUbicacion, direccion, latitud, longitud));
        }
        
        public List<String> showPuntoUbicacion()
        {
            List<String> ms = new List<string>();
            for (int i = 0; i< zonas.Count; i++) {
                ms.Add(zonas[i].getPUbicacion());
            }
            return ms;
        }

        public List<String> showDireccion(String u) {
            List<String> ms = new List<string>();
            for (int i = 0; i < zonas.Count; i++)
            {
                if (zonas[i].getPUbicacion().Equals(u)) {
                    ms.Add(zonas[i].getDireccion());
                }
            }
            return ms;
        }
        public double showLatitud(String direccion, String u)
        {
            double ms = 0;
            for (int i = 0; i < zonas.Count; i++)
            {
                if (zonas[i].getDireccion().Equals(direccion)&& zonas[i].getPUbicacion().Equals(u))
                {
                    ms=zonas[i].getLatitud();
                }
            }
            return ms;
        }

        public double showLongitud(String direccion, String u)
        {
            double ms = 0;
            for (int i = 0; i < zonas.Count; i++)
            {
                if (zonas[i].getDireccion().Equals(direccion) && zonas[i].getPUbicacion().Equals(u))
                {
                    ms =zonas[i].getLongitud();
                }
            }
            return ms;
        }

        public ZonaWifi menorDistancia(double la, double lo) {
            ZonaWifi z = zonas[1];
            double aux = z.distance(la,lo);
            for (int i = 1; i < zonas.Count; i++)
            {
                if (aux>zonas[i].distance(la,lo))
                {
                    z = zonas[i];
                }
            }


            return z;
        }
        public ZonaWifi findZona(String pUbicacion, String direccion, double latitud, double longitud) {
            ZonaWifi z = null;
            for (int i = 0; i > zonas.Count; i++) {
                if (zonas[i].getDireccion()==direccion) {
                    if (zonas[i].getPUbicacion()==pUbicacion && zonas[i].getLatitud() == latitud && zonas[i].getLongitud()==longitud) {
                        z = zonas[1];
                    }
                }
            }

            return z;
        }

        public int cantidadZonas() {
            return zonas.Count;
        }
    }
}
