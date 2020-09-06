using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class MinTic
    {
        private List<Municipio> municipios;


        public MinTic() {
            municipios = new List<Municipio>();

        }
        public List<Municipio> getMunicipios() {
            return municipios;
        }

        public List<String> showMunicipios() {
            List<String> ms = new List<string>();
            for (int i = 0; i < municipios.Count; i++) {
                ms.Add(municipios[i].getNombre());
            }
            return ms;
        }

        public List<String> showUbicacion(String mu) {
            return findMunicipio(mu).showPuntoUbicacion();
        }

        public List<String> showDireccion(String mu, String ub) {
            return findMunicipio(mu).showDireccion(ub);
        }

        public double showLatitud(String mu, String ub, String di) {
            return findMunicipio(mu).showLatitud(ub, di);
        }

        public double showLongitud(String mu, String ub, String di) {
            return findMunicipio(mu).showLongitud(ub, di);
        }
        public Municipio findMunicipio(String mu) {
            Municipio m = null;
            for (int i = 0; i < municipios.Count; i++) {
                if (municipios[i].getNombre().Equals(mu)) {
                    m = municipios[i];
                }
            }
            return m;
        }

        public void addZona(String municipio, String pUbicacios, String direccion, double latitud, double longitud) {
            findMunicipio(municipio).addZona(pUbicacios, direccion, latitud, longitud);
        }

        public void addMunicipio(String mu) {
            if (findMunicipio(mu) == null) {
                municipios.Add(new Municipio(mu));
            }
        }

        public ZonaWifi findZona(String mu, String pUbicacion, String direccion, double latitud, double longitud) {
            return findMunicipio(mu).findZona(pUbicacion, direccion, latitud, longitud);
        }

        public int totalZonas() {
            int aux = 0;
            for (int i = 0; i < municipios.Count; i++) {
                aux += municipios[i].cantidadZonas();
            }
            return aux;
        }

        public List<double> pastel() {
            List<double> aux = new List<double>();
            for (int i = 0; i < municipios.Count; i++)
            {
                aux.Add(municipios[i].cantidadZonas() / totalZonas());
            }
            return aux;
        }
    }
}
