using Mundial.PARTIDOS;
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
        

        public static bool actualizar(Partido p) //tabla de equipos modificar
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
        public static bool InsertarPartidos(Partido p) //tabla de partidos modificar
        {

            try
            {
                conexion_Class con = new conexion_Class();
                string sql = "update partidos set res_eq_uno= " + p.Res_eq_uno + ", res_eq_dos  = " + p.Res_eq_dos + ", tar_amarilla_eq_uno = " + p.Tar_amarilla_eq_uno + ", tar_amarilla_eq_dos = " + p.Tar_amarilla_eq_dos + ", tar_roja_eq_uno = " + p.Tar_roja_eq_uno + ", tar_roja_eq_dos = " + p.Tar_roja_eq_dos+ "," + "   where id_partido = '" + p.Id_partido+ "'"; //fiajrse el tema de la FK

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                int cantidad = comando.ExecuteNonQuery();

                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;

                }
                else
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
            

        } //esta consulta se hace en base a la tabla todo ok

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
            


        }  //POSICIONES EN LA TABLA DE EQUIPOS

        public static void CargarEquipo1()
        {
            Partido partido = new Partido();
            //para el equipo1
            if(partido.Id_equipos1 == true)
                if (partido.Res_eq_uno < partido.Res_eq_dos) //cuando pierde
                {
                    partido.Cant_partidos =+1;
                
                    partido.Partidos_ganados = 0;
                    partido.Partidos_perdidos = +1;
                    partido.Partidos_empatados = 0;
                    partido.Puntos = 0;
                    //artido.Dif_goles = txtresultado1 - txtresultado2;
                    //artido.Cant_goles_a_favor = txtresultado1//aca va el txt 
                    //artido.Cant_goles_en_contra = txtresultado2//
                }
                else //cuando gana
                {
                    partido.Cant_partidos = +1;

                    partido.Partidos_ganados = 1;
                    partido.Partidos_perdidos = 0;
                    partido.Partidos_empatados = 0;
                    partido.Puntos = +3;
                    //artido.Dif_goles = txtresultado1 - txtresultado2;
                    //artido.Cant_goles_a_favor = txtresultado1//aca va el txt 
                    //artido.Cant_goles_en_contra = txtresultado2//
                }
                if (partido.Res_eq_uno== partido.Res_eq_dos) //cuando empata
                {
                    partido.Cant_partidos = +1;

                    partido.Partidos_ganados = 0;
                    partido.Partidos_perdidos = 0;
                    partido.Partidos_empatados = 1;
                    partido.Puntos = 1;
                    //artido.Dif_goles = txtresultado1 - txtresultado2;
                    //artido.Cant_goles_a_favor = txtresultado1//aca va el txt 
                    //artido.Cant_goles_en_contra = txtresultado2//
                } 
            
        }
        public void CargarEquipo2()
        {
            Partido partido = new Partido();
            //para el equipo2
            if (partido.Res_eq_dos < partido.Res_eq_uno)
            {
                partido.Cant_partidos = +1;

                partido.Partidos_ganados = 0;
                partido.Partidos_perdidos = +1;
                partido.Partidos_empatados = 0;
                partido.Puntos = 0;
                //artido.Dif_goles = txtresultado1 - txtresultado2;
                //artido.Cant_goles_a_favor = txtresultado1//aca va el txt 
                //artido.Cant_goles_en_contra = txtresultado2//
            }
            else //cuando gana
            {
                partido.Cant_partidos = +1;

                partido.Partidos_ganados = 1;
                partido.Partidos_perdidos = 0;
                partido.Partidos_empatados = 0;
                partido.Puntos = +3;
                //artido.Dif_goles = txtresultado1 - txtresultado2;
                //artido.Cant_goles_a_favor = txtresultado1//aca va el txt 
                //artido.Cant_goles_en_contra = txtresultado2//
            }
            if (partido.Res_eq_uno == partido.Res_eq_dos)
            {
                partido.Cant_partidos = +1;

                partido.Partidos_ganados = 0;
                partido.Partidos_perdidos = 0;
                partido.Partidos_empatados = 1;
                partido.Puntos = 1;
                //artido.Dif_goles = txtresultado1 - txtresultado2;
                //artido.Cant_goles_a_favor = txtresultado1//aca va el txt 
                //artido.Cant_goles_en_contra = txtresultado2//
            }



        }

    }
}
