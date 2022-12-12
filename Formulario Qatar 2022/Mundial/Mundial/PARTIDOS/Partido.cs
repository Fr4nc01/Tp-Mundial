using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundial.PARTIDOS
{
    internal class Partido
    {
        private string id_equipos;
        private string nombre_de_grupo;
        private string pais;
        private int cant_partidos;
        private int T_amarilla;
        private int T_rojas;
        private int partidos_ganados;
        private int partidos_perdidos;
        private int partidos_empatados;
        private int puntos;
        private int dif_goles;
        private int cant_goles_a_favor;
        private int cant_goles_en_contra;

        public Partido()
        {
            Id_equipos = "";
            Nombre_de_grupo = "";
            Pais = "";
            Cant_partidos = 0;
            T_amarilla1 = 0;
            T_rojas1 = 0;
            Partidos_ganados = 0;
            Partidos_perdidos = 0;
            Partidos_empatados = 0;
            Puntos = 0;
            Dif_goles = 0;
            Cant_goles_a_favor = 0;
            Cant_goles_en_contra = 0;

        }

        public string Id_equipos { get => id_equipos; set => id_equipos = value; }
        public string Nombre_de_grupo { get => nombre_de_grupo; set => nombre_de_grupo = value; }
        public string Pais { get => pais; set => pais = value; }
        public int Cant_partidos { get => cant_partidos; set => cant_partidos = value; }
        public int T_amarilla1 { get => T_amarilla; set => T_amarilla = value; }
        public int T_rojas1 { get => T_rojas; set => T_rojas = value; }
        public int Partidos_ganados { get => partidos_ganados; set => partidos_ganados = value; }
        public int Partidos_perdidos { get => partidos_perdidos; set => partidos_perdidos = value; }
        public int Partidos_empatados { get => partidos_empatados; set => partidos_empatados = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public int Dif_goles { get => dif_goles; set => dif_goles = value; }
        public int Cant_goles_a_favor { get => cant_goles_a_favor; set => cant_goles_a_favor = value; }
        public int Cant_goles_en_contra { get => cant_goles_en_contra; set => cant_goles_en_contra = value; }
    }
}
