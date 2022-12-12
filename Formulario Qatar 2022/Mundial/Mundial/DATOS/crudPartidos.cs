﻿using Mundial.PARTIDOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mundial.DATOS
{
    internal class crudPartidos
    {
        

        public static bool actualizar(Partido p)
        {

            try
            {                
                conexion_Class con = new conexion_Class();
                string sql = "update equipos set cant_partidos = "+p.Cant_partidos+", T_amarilla = "+p.T_amarilla1+", T_rojas = "+p.T_rojas1+", partidos_ganados = "+p.Partidos_ganados+", partidos_perdidos = "+p.Partidos_perdidos+", partidos_empatados = "+p.Partidos_empatados+","+
                "puntos = "+p.Puntos+", dif_goles = "+p.Dif_goles+", cant_goles_a_favor = "+p.Cant_goles_a_favor+", cant_goles_en_contra = "+p.Cant_goles_en_contra+"   where id_equipos = '"+p.Id_equipos+"'";

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                int cantidad = comando.ExecuteNonQuery();

              

                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;

                } else
                {
                    con.desconectar();
                    return false;

                }
               
            }
            catch (Exception ex)
            {
                return false;
            }
           

        }

        public static Partido consultar_pais(string id_equipos)
        {

            MessageBox.Show(id_equipos);
            
            try
            {               

                conexion_Class con = new conexion_Class();

                string sql = "select * from equipos where id_equipos = '"+id_equipos+"'";

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                SqlDataReader leer = comando.ExecuteReader();

                Partido partido = new Partido();

               


                if (leer.Read())
                {
                    partido.Id_equipos = leer["id_equipos"].ToString(); //que me lo retorne como un string
                  //  partido.Nombre_de_grupo = leer["nombre_de_grupo"].ToString();
                  //  partido.Pais = leer["pais"].ToString();
                    partido.Cant_partidos = Convert.ToInt32(leer["cant_partidos"].ToString());
                    partido.T_amarilla1 = Convert.ToInt32(leer["T_amarilla"].ToString());
                    partido.T_rojas1 = Convert.ToInt32(leer["T_rojas"].ToString());
                    partido.Partidos_ganados = Convert.ToInt32(leer["partidos_ganados"].ToString());
                    partido.Partidos_perdidos = Convert.ToInt32(leer["partidos_perdidos"].ToString());
                    partido.Partidos_empatados = Convert.ToInt32(leer["partidos_empatados"].ToString());
                    partido.Dif_goles = Convert.ToInt32(leer["dif_goles"].ToString());
                    partido.Cant_goles_a_favor = Convert.ToInt32(leer["cant_goles_a_favor"].ToString());
                    partido.Cant_goles_en_contra = Convert.ToInt32(leer["cant_goles_en_contra"].ToString());
                    con.desconectar();
                    return partido;
                    

                }
                else
                {
                    con.desconectar();
                    return null;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
            

        }

        public static DataTable posiciones()
        {

            try
            {
                conexion_Class con = new conexion_Class();
                string sql = "select * from equipos";

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                SqlDataReader leer = comando.ExecuteReader(CommandBehavior.CloseConnection);//se cierre la connecion luego de la lectura

                DataTable dt = new DataTable();

                dt.Load(leer);
                con.desconectar();
                return dt;

            }catch(Exception ex)
            {
                return null;
            }
            


        }


    }
}