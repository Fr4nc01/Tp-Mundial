﻿
using Mundial.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using Mundial.PARTIDOS;
using Mundial.DATOS;
using System.Data;
using System.Runtime.Versioning;

namespace Mundial
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class faseDeGrupos : Form
	{
        public string id_equipos ="";


		public faseDeGrupos()
		{
			InitializeComponent();
            lbPais.Text = "";			
			
		}
        bool consultado = false;
        private void MainForm_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

		private void ElegirGrupo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ElegirGrupo.SelectedIndex == 0) // GRUPO A
            {
				ElegirPais.Items.Clear();
				ElegirPais.Items.Add("Qatar");
                ElegirPais.Items.Add("Ecuador");
                ElegirPais.Items.Add("Senegal");
                ElegirPais.Items.Add("Paises Bajos");
                pictureBox1.Image = Resources.bandera_blanca;
                lbPais.Text = "";
                lbSpais.Visible = true;
				ElegirPais.Visible = true;
			}
			if (ElegirGrupo.SelectedIndex == 1) // GRUPO B
            {
                ElegirPais.Items.Clear();
                ElegirPais.Items.Add("Inglaterra");
                ElegirPais.Items.Add("Iràn");
                ElegirPais.Items.Add("Estados Unidos");
                ElegirPais.Items.Add("Gales");
                pictureBox1.Image = Resources.bandera_blanca;
                lbPais.Text = "";
                lbSpais.Visible = true;
				ElegirPais.Visible = true;
			}
            if (ElegirGrupo.SelectedIndex == 2) // GRUPO C
            {
                ElegirPais.Items.Clear();
                ElegirPais.Items.Add("Argentina");
                ElegirPais.Items.Add("Arabia Saudita");
                ElegirPais.Items.Add("Mexico");
                ElegirPais.Items.Add("Polonia");
                pictureBox1.Image = Resources.bandera_blanca;
                lbPais.Text = "";
                lbSpais.Visible = true;
                ElegirPais.Visible = true;
            }
            if (ElegirGrupo.SelectedIndex == 3) // GRUPO D
            {
                ElegirPais.Items.Clear();
                ElegirPais.Items.Add("Francia");
                ElegirPais.Items.Add("Australia");
                ElegirPais.Items.Add("Dinamarca");
                ElegirPais.Items.Add("Tùnez");
                pictureBox1.Image = Resources.bandera_blanca;
                lbPais.Text = "";
                lbSpais.Visible = true;
                ElegirPais.Visible = true;
            }
            if (ElegirGrupo.SelectedIndex == 4) // GRUPO E
            {
                ElegirPais.Items.Clear();
                ElegirPais.Items.Add("España");
                ElegirPais.Items.Add("Costa Rica");
                ElegirPais.Items.Add("Alemania");
                ElegirPais.Items.Add("Japón");
                pictureBox1.Image = Resources.bandera_blanca;
                lbPais.Text = "";
                lbSpais.Visible = true;
                ElegirPais.Visible = true;
            }
            if (ElegirGrupo.SelectedIndex == 5) // GRUPO F
            {
                ElegirPais.Items.Clear();
                ElegirPais.Items.Add("Bélgica");
                ElegirPais.Items.Add("Canadá");
                ElegirPais.Items.Add("Marruecos");
                ElegirPais.Items.Add("Croacia");
                pictureBox1.Image = Resources.bandera_blanca;
                lbPais.Text = "";
                lbSpais.Visible = true;
                ElegirPais.Visible = true;
            }
            if (ElegirGrupo.SelectedIndex == 6) // GRUPO G
            {
                ElegirPais.Items.Clear();
                ElegirPais.Items.Add("Brasil");
                ElegirPais.Items.Add("Serbia");
                ElegirPais.Items.Add("Suiza");
                ElegirPais.Items.Add("Camerún");
                pictureBox1.Image = Resources.bandera_blanca;
                lbPais.Text = "";
                lbSpais.Visible = true;
                ElegirPais.Visible = true;
            }
            if (ElegirGrupo.SelectedIndex == 7) // GRUPO H
            {
                ElegirPais.Items.Clear();
                ElegirPais.Items.Add("Portugal");
                ElegirPais.Items.Add("Ghana");
                ElegirPais.Items.Add("Uruguay");
                ElegirPais.Items.Add("Corea del Sur");
                pictureBox1.Image = Resources.bandera_blanca;
                lbPais.Text = "";
                lbSpais.Visible = true;
                ElegirPais.Visible = true;
            }

        }

        private void ElegirPais_SelectedIndexChanged(object sender, EventArgs e) // PAISES
        {

            if (ElegirPais.SelectedIndex == 0) // Primer opcion del ComboBox
            {
                if (ElegirPais.Items.Contains("Qatar"))
                {
                    lbPais.Text = "Qatar";
                    pictureBox1.Image = Resources.BanQatar;
                    id_equipos = "A1";

                }
                if (ElegirPais.Items.Contains("Inglaterra"))
                {
                    lbPais.Text = "Inglaterra";
                    pictureBox1.Image = Resources.BanInglaterra;
                    id_equipos = "B1";

                }
                if (ElegirPais.Items.Contains("Argentina"))
                {
                    lbPais.Text = "Argentina";
                    pictureBox1.Image = Resources.BanArgentina;
                    id_equipos = "C1";

                }
                if (ElegirPais.Items.Contains("Francia"))
                {
                    lbPais.Text = "Francia";
                    pictureBox1.Image = Resources.BanFrancia;
                    id_equipos = "D1";

                }
                if (ElegirPais.Items.Contains("España"))
                {
                    lbPais.Text = "España";
                    pictureBox1.Image = Resources.BanEspaña;
                    id_equipos = "E1";

                }
                if (ElegirPais.Items.Contains("Bélgica"))
                {
                    lbPais.Text = "Bélgica";
                    pictureBox1.Image = Resources.BanBelgica;
                    id_equipos = "F1";

                }
                if (ElegirPais.Items.Contains("Brasil"))
                {
                    lbPais.Text = "Brasil";
                    pictureBox1.Image = Resources.BanBrasil;
                    id_equipos = "G1";

                }
                if (ElegirPais.Items.Contains("Portugal"))
                {
                    lbPais.Text = "Portugal";
                    pictureBox1.Image = Resources.BanPortugal;
                    id_equipos = "H1";

                }

            }

            if (ElegirPais.SelectedIndex == 1) // Segunda opcion del ComboBox
            {
                if (ElegirPais.Items.Contains("Ecuador"))
                {
                    lbPais.Text = "Ecuador";
                    pictureBox1.Image = Resources.BanEcuador;
                    id_equipos = "A2";

                }
                if (ElegirPais.Items.Contains("Iràn"))
                {
                    lbPais.Text = "Iràn";
                    pictureBox1.Image = Resources.BanIràn;
                    id_equipos = "B2";

                }
                if (ElegirPais.Items.Contains("Arabia Saudita"))
                {
                    lbPais.Text = "Arabia Saudita";
                    pictureBox1.Image = Resources.BanArabiaSaudita;
                    id_equipos = "C2";

                }
                if (ElegirPais.Items.Contains("Australia"))
                {
                    lbPais.Text = "Australia";
                    pictureBox1.Image = Resources.BanAustralia;
                    id_equipos = "D2";

                }
                if (ElegirPais.Items.Contains("Costa Rica"))
                {
                    lbPais.Text = "Costa Rica";
                    pictureBox1.Image = Resources.BanCostaRica;
                    id_equipos = "E2";

                }
                if (ElegirPais.Items.Contains("Canadá"))
                {
                    lbPais.Text = "Canadá";
                    pictureBox1.Image = Resources.BanCanada;
                    id_equipos = "F2";

                }
                if (ElegirPais.Items.Contains("Serbia"))
                {
                    lbPais.Text = "Serbia";
                    pictureBox1.Image = Resources.BanSerbia;
                    id_equipos = "G2";

                }
                if (ElegirPais.Items.Contains("Ghana"))
                {
                    lbPais.Text = "Ghana";
                    pictureBox1.Image = Resources.BanGhana;
                    id_equipos = "H2";

                }

            }

            if (ElegirPais.SelectedIndex == 2) // Tercer opcion del ComboBox
            {
                if (ElegirPais.Items.Contains("Senegal"))
                {
                    lbPais.Text = "Senegal";
                    pictureBox1.Image = Resources.BanSenegal;
                    id_equipos = "A3";

                }
                if (ElegirPais.Items.Contains("Estados Unidos"))
                {
                    lbPais.Text = "Estados Unidos";
                    pictureBox1.Image = Resources.BanEEUU;
                    id_equipos = "B3";

                }
                if (ElegirPais.Items.Contains("Mexico"))
                {
                    lbPais.Text = "Mexico";
                    pictureBox1.Image = Resources.BanMex;
                    id_equipos = "C3";

                }
                if (ElegirPais.Items.Contains("Dinamarca"))
                {
                    lbPais.Text = "Dinamarca";
                    pictureBox1.Image = Resources.BanDinamarca;
                    id_equipos = "D3";

                }
                if (ElegirPais.Items.Contains("Alemania"))
                {
                    lbPais.Text = "Alemania";
                    pictureBox1.Image = Resources.BanAlemania;
                    id_equipos = "E3";

                }
                if (ElegirPais.Items.Contains("Marruecos"))
                {
                    lbPais.Text = "Marruecos";
                    pictureBox1.Image = Resources.BanMarruecos;
                    id_equipos = "F3";

                }
                if (ElegirPais.Items.Contains("Suiza"))
                {
                    lbPais.Text = "Suiza";
                    pictureBox1.Image = Resources.BanSuiza;
                    id_equipos = "G3";

                }
                if (ElegirPais.Items.Contains("Uruguay"))
                {
                    lbPais.Text = "Uruguay";
                    pictureBox1.Image = Resources.BanUruguay;
                    id_equipos = "H3";

                }

            }

            if (ElegirPais.SelectedIndex == 3) // Cuarta opcion del ComboBox
            {
                if (ElegirPais.Items.Contains("Paises Bajos"))
                {
                    lbPais.Text = "Paises Bajos";
                    pictureBox1.Image = Resources.BanPaisesBajos;
                    id_equipos = "A4";

                }
                if (ElegirPais.Items.Contains("Gales"))
                {
                    lbPais.Text = "Gales";
                    pictureBox1.Image = Resources.BanGales;
                    id_equipos = "B4";

                }
                if (ElegirPais.Items.Contains("Polonia"))
                {
                    lbPais.Text = "Polonia";
                    pictureBox1.Image = Resources.BanPolonia;
                    id_equipos = "C4";

                }
                if (ElegirPais.Items.Contains("Tùnez"))
                {
                    lbPais.Text = "Túnez";
                    pictureBox1.Image = Resources.BanTunez;
                    id_equipos = "D4";

                }
                if (ElegirPais.Items.Contains("Japón"))
                {
                    lbPais.Text = "Japón";
                    pictureBox1.Image = Resources.BanJapon;
                    id_equipos = "E4";

                }
                if (ElegirPais.Items.Contains("Croacia"))
                {
                    lbPais.Text = "Croacia";
                    pictureBox1.Image = Resources.BanCroacia;
                    id_equipos = "F4";

                }
                if (ElegirPais.Items.Contains("Camerún"))
                {
                    lbPais.Text = "Camerún";
                    pictureBox1.Image = Resources.BanCamerun;
                    id_equipos = "G4";

                }
                if (ElegirPais.Items.Contains("Corea del Sur"))
                {
                    lbPais.Text = "Corea del Sur";
                    pictureBox1.Image = Resources.BanCoreaDelSur;
                    id_equipos = "H4";

                }

            }

        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            panelAyuda.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            panelAyuda.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnMostrar.Visible = true;
            BtnAyuda.Visible = true;
            groupBoxCarga.Visible = true;
            btnCargar.Visible = false;
            btnConsultar.Visible = false;
            btnVolver.Visible = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            BtnAyuda.Visible = false;
            groupBoxCarga.Visible = false;
            btnCargar.Visible = true;
            btnConsultar.Visible = true;
            btnVolver.Visible = false;
            btnMostrar.Visible =false;
        }

        private void btnCargaDatos_Click(object sender, EventArgs e)
        {
            BtnAyuda.Visible = false;
            btnCargaDatos.Visible = false;
            groupBoxCarga.Visible = false;
            btnCargar.Visible = true;
            btnConsultar.Visible = true;
            btnVolver.Visible = false;
            btnMostrar.Visible = false;

            /*  if (consultado == false)
              {
                  MessageBox.Show("consulte su pais antes de cargar.");
              }*/
            //para el equipo1 tiene que estar en un boton 
            try
            {
                Partido partido = crudPartidos.consultar_pais(id_equipos);
                CargarEquipo1();
                partido.Cant_partidos = Convert.ToInt32(txtPartJugado.Text.Trim());
                partido.T_amarilla1 = Convert.ToInt32(txtTAmarilla.Text.Trim());
                partido.T_rojas1 = Convert.ToInt32(txtTRojas.Text.Trim());
                partido.Partidos_ganados = Convert.ToInt32(txtPartidosGanados.Text.Trim());
                partido.Partidos_perdidos = Convert.ToInt32(txtPerdidos.Text.Trim());
                partido.Partidos_empatados = Convert.ToInt32(txtEmpate.Text.Trim());
                partido.Dif_goles = Convert.ToInt32(txtDifGoles.Text.Trim());
                partido.Cant_goles_a_favor = Convert.ToInt32(txtGolesAfavor.Text.Trim());
                partido.Cant_goles_en_contra = Convert.ToInt32(txtGolesEnContra.Text.Trim());

                if (crudPartidos.actualizar())
                {
                    //llenamos el grid y limpiamos
                    llenarGrid();
                    limpiarCampos();
                    MessageBox.Show("Datos guardados.");
                    consultado = false; //
                }
                else
                {
                    MessageBox.Show("No se puedo guardar los datos.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            //para el equipo2 esto tiene que estar en otro boton
            try
            {
                Partido partido = crudPartidos.consultar_pais(id_equipos);
                CargarEquipo2();
                partido.Cant_partidos = Convert.ToInt32(txtPartJugado.Text.Trim());
                partido.T_amarilla1 = Convert.ToInt32(txtTAmarilla.Text.Trim());
                partido.T_rojas1 = Convert.ToInt32(txtTRojas.Text.Trim());
                partido.Partidos_ganados = Convert.ToInt32(txtPartidosGanados.Text.Trim());
                partido.Partidos_perdidos = Convert.ToInt32(txtPerdidos.Text.Trim());
                partido.Partidos_empatados = Convert.ToInt32(txtEmpate.Text.Trim());
                partido.Dif_goles = Convert.ToInt32(txtDifGoles.Text.Trim());
                partido.Cant_goles_a_favor = Convert.ToInt32(txtGolesAfavor.Text.Trim());
                partido.Cant_goles_en_contra = Convert.ToInt32(txtGolesEnContra.Text.Trim());

                if (crudPartidos.actualizar())
                {
                    //llenamos el grid y limpiamos
                    llenarGrid();
                    limpiarCampos();
                    MessageBox.Show("Datos guardados.");
                    consultado = false; //
                }
                else
                {
                    MessageBox.Show("No se puedo guardar los datos.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }



        private void button1_Click(object sender, EventArgs e) // MOSTRAR
        { 
            Partido partido = crudPartidos.consultar_pais(id_equipos);

            if (partido == null)
            {
                MessageBox.Show("No existe el pais.");
                limpiarCampos();
                consultado = false;
            }
            else
            {
                txtPartJugado.Text = partido.Cant_partidos.ToString();
                txtTAmarilla.Text = partido.T_amarilla1.ToString();
                txtTRojas.Text = partido.T_rojas1.ToString();
                txtPartidosGanados.Text = partido.Partidos_ganados.ToString();
                txtPerdidos.Text = partido.Partidos_perdidos.ToString();
                txtEmpate.Text = partido.Partidos_empatados.ToString();
                txtDifGoles.Text = partido.Dif_goles.ToString();
                txtGolesAfavor.Text = partido.Cant_goles_a_favor.ToString();
                txtGolesEnContra.Text = partido.Cant_goles_en_contra.ToString();
                consultado= true;

            }

        }

        private void llenarGrid()
        {
                DataTable datos = crudPartidos.posiciones();
                if (datos == null)
                {
                    MessageBox.Show("No se logro generar la tabla");
                }
                else
                {
                    dataGridView1.DataSource = datos.DefaultView; //retorna a una lista el default es la vista por defecto de la base
                }
        }
        private void limpiarCampos()
        {
            txtEmpate.Text = "";
            txtGolesAfavor.Text = "";
            txtGolesEnContra.Text = "";
            txtPartidosGanados.Text = "";
            txtPartJugado.Text = "";
            txtPerdidos.Text = "";
            txtTAmarilla.Text = "";
            txtTRojas.Text = "";
            txtDifGoles.Text = "";

        }

        private void comboBoxPartido_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxPais1.Visible = true;
            pictureBoxPais2.Visible = true;

            txtGrupo1.Visible = true;
            txtGrupo1.Enabled = false;

            txtGrupo2.Visible = true;
            txtGrupo2.Enabled = false;

            txtPais1.Visible = true;
            txtPais1.Enabled = false;

            txtPais2.Visible = true;
            txtPais2.Enabled = false;

            lbFecha.Visible = true;
            txtFecha.Visible = true;

            txtGoles1.Visible = true;
            txtGoles2.Visible = true;
            txtTa1.Visible = true;
            txtTA2.Visible = true;
            txtTR1.Visible = true;
            txtTR2.Visible = true;

            cantGoles1.Visible = true;
            cantGoles2.Visible = true;
            cantTA1.Visible = true;
            cantTA2.Visible = true;
            cantTR1.Visible = true;
            cantTR2.Visible = true;


            if (ElegirPartido.SelectedIndex == 0) // PARTIDO [1] GRUPO A
            {
                pictureBoxPais1.Image = Resources.BanQatar;
                pictureBoxPais2.Image = Resources.BanEcuador;

                txtPais1.Text = "Qatar";
                txtPais2.Text = "Ecuador";

                txtFecha.Text = "20/11";

                txtGrupo1.Text = "Grupo A";
                txtGrupo2.Text = "Grupo A";
            }

            if (ElegirPartido.SelectedIndex == 1) // PARTIDO [2] GRUPO B
            {
                pictureBoxPais1.Image = Resources.BanInglaterra;
                pictureBoxPais2.Image = Resources.BanIràn;

                txtPais1.Text = "Inglaterra";
                txtPais2.Text = "Irán";

                txtFecha.Text = "21/11";

                txtGrupo1.Text = "Grupo B";
                txtGrupo2.Text = "Grupo B";
            }

            if (ElegirPartido.SelectedIndex == 2) // PARTIDO [3] GRUPO A
            {
                pictureBoxPais1.Image = Resources.BanSenegal;
                pictureBoxPais2.Image = Resources.BanPaisesBajos;

                txtPais1.Text = "Senegal";
                txtPais2.Text = "Paises Bajos";

                txtFecha.Text = "21/11";

                txtGrupo1.Text = "Grupo A";
                txtGrupo2.Text = "Grupo A";
            }

            if (ElegirPartido.SelectedIndex == 3) // PARTIDO [4] GRUPO B
            {
                pictureBoxPais1.Image = Resources.BanEEUU;
                pictureBoxPais2.Image = Resources.BanGales;

                txtPais1.Text = "Estados Unidos";
                txtPais2.Text = "Gales";

                txtFecha.Text = "21/11";

                txtGrupo1.Text = "Grupo B";
                txtGrupo2.Text = "Grupo B";
            }

            if (ElegirPartido.SelectedIndex == 4) // PARTIDO [5] GRUPO C
            {
                pictureBoxPais1.Image = Resources.BanArgentina;
                pictureBoxPais2.Image = Resources.BanArabiaSaudita;

                txtPais1.Text = "Argentina";
                txtPais2.Text = "Arabia Saudita";

                txtFecha.Text = "22/11";

                txtGrupo1.Text = "Grupo C";
                txtGrupo2.Text = "Grupo C";
            }

            if (ElegirPartido.SelectedIndex == 5) // PARTIDO [6] GRUPO D
            {
                pictureBoxPais1.Image = Resources.BanDinamarca;
                pictureBoxPais2.Image = Resources.BanTunez;

                txtPais1.Text = "Dinamarca";
                txtPais2.Text = "Tunez";

                txtFecha.Text = "22/11";

                txtGrupo1.Text = "Grupo D";
                txtGrupo2.Text = "Grupo D";
            }

            if (ElegirPartido.SelectedIndex == 6) // PARTIDO [7] GRUPO C
            {
                pictureBoxPais1.Image = Resources.BanMex;
                pictureBoxPais2.Image = Resources.BanPolonia;

                txtPais1.Text = "Mexico";
                txtPais2.Text = "Polonia";

                txtFecha.Text = "22/11";

                txtGrupo1.Text = "Grupo C";
                txtGrupo2.Text = "Grupo C";
            }

            if (ElegirPartido.SelectedIndex == 7) // PARTIDO [8] GRUPO D
            {
                pictureBoxPais1.Image = Resources.BanFrancia;
                pictureBoxPais2.Image = Resources.BanAustralia;

                txtPais1.Text = "Francia";
                txtPais2.Text = "Australia";

                txtFecha.Text = "22/11";

                txtGrupo1.Text = "Grupo D";
                txtGrupo2.Text = "Grupo D";
            }

            if (ElegirPartido.SelectedIndex == 8) // PARTIDO [9] GRUPO F
            {
                pictureBoxPais1.Image = Resources.BanMarruecos;
                pictureBoxPais2.Image = Resources.BanCroacia;

                txtPais1.Text = "Marruecos";
                txtPais2.Text = "Croacia";

                txtFecha.Text = "23/11";

                txtGrupo1.Text = "Grupo F";
                txtGrupo2.Text = "Grupo F";
            }

            if (ElegirPartido.SelectedIndex == 9) // PARTIDO [10] GRUPO E
            {
                pictureBoxPais1.Image = Resources.BanAlemania;
                pictureBoxPais2.Image = Resources.BanJapon;

                txtPais1.Text = "Alemania";
                txtPais2.Text = "Japon";

                txtFecha.Text = "23/11";

                txtGrupo1.Text = "Grupo E";
                txtGrupo2.Text = "Grupo E";
            }

            if (ElegirPartido.SelectedIndex == 10) // PARTIDO [11] GRUPO E
            {
                pictureBoxPais1.Image = Resources.BanEspaña;
                pictureBoxPais2.Image = Resources.BanCostaRica;

                txtPais1.Text = "España";
                txtPais2.Text = "Costa Rica";

                txtFecha.Text = "23/11";

                txtGrupo1.Text = "Grupo E";
                txtGrupo2.Text = "Grupo E";
            }

            if (ElegirPartido.SelectedIndex == 11) // PARTIDO [12] GRUPO F
            {
                pictureBoxPais1.Image = Resources.BanBelgica;
                pictureBoxPais2.Image = Resources.BanCanada;

                txtPais1.Text = "Belgica";
                txtPais2.Text = "Canada";

                txtFecha.Text = "23/11";

                txtGrupo1.Text = "Grupo F";
                txtGrupo2.Text = "Grupo F";
            }

            if (ElegirPartido.SelectedIndex == 12) // PARTIDO [13] GRUPO G
            {
                pictureBoxPais1.Image = Resources.BanSuiza;
                pictureBoxPais2.Image = Resources.BanCamerun;

                txtPais1.Text = "Suiza";
                txtPais2.Text = "Camerun";

                txtFecha.Text = "24/11";

                txtGrupo1.Text = "Grupo G";
                txtGrupo2.Text = "Grupo G";
            }

            if (ElegirPartido.SelectedIndex == 13) // PARTIDO [14] GRUPO H
            {
                pictureBoxPais1.Image = Resources.BanUruguay;
                pictureBoxPais2.Image = Resources.BanCoreaDelSur;

                txtPais1.Text = "Uruguay";
                txtPais2.Text = "Corea del Sur";

                txtFecha.Text = "24/11";

                txtGrupo1.Text = "Grupo H";
                txtGrupo2.Text = "Grupo H";
            }

            if (ElegirPartido.SelectedIndex == 14) // PARTIDO [15] GRUPO H
            {
                pictureBoxPais1.Image = Resources.BanPortugal;
                pictureBoxPais2.Image = Resources.BanGhana;

                txtPais1.Text = "Portugal";
                txtPais2.Text = "Ghana";

                txtFecha.Text = "24/11";

                txtGrupo1.Text = "Grupo H";
                txtGrupo2.Text = "Grupo H";
            }

            if (ElegirPartido.SelectedIndex == 15) // PARTIDO [16] GRUPO G
            {
                pictureBoxPais1.Image = Resources.BanBrasil;
                pictureBoxPais2.Image = Resources.BanSerbia;

                txtPais1.Text = "Brasil";
                txtPais2.Text = "Serbia";

                txtFecha.Text = "28/11";

                txtGrupo1.Text = "Grupo G";
                txtGrupo2.Text = "Grupo G";
            }

            if (ElegirPartido.SelectedIndex == 16) // PARTIDO [17] GRUPO B
            {
                pictureBoxPais1.Image = Resources.BanIràn;
                pictureBoxPais2.Image = Resources.BanGales;

                txtPais1.Text = "Iran";
                txtPais2.Text = "Gales";

                txtFecha.Text = "25/11";

                txtGrupo1.Text = "Grupo B";
                txtGrupo2.Text = "Grupo B";
            }

            if (ElegirPartido.SelectedIndex == 17) // PARTIDO [18] GRUPO A
            {
                pictureBoxPais1.Image = Resources.BanQatar;
                pictureBoxPais2.Image = Resources.BanSenegal;

                txtPais1.Text = "Qatar";
                txtPais2.Text = "Senegal";

                txtFecha.Text = "25/11";

                txtGrupo1.Text = "Grupo A";
                txtGrupo2.Text = "Grupo A";
            }

            if (ElegirPartido.SelectedIndex == 18) // PARTIDO [19] GRUPO A
            {
                pictureBoxPais1.Image = Resources.BanPaisesBajos;
                pictureBoxPais2.Image = Resources.BanEcuador;

                txtPais1.Text = "Paises Bajos";
                txtPais2.Text = "Ecuador";

                txtFecha.Text = "25/11";

                txtGrupo1.Text = "Grupo A";
                txtGrupo2.Text = "Grupo A";
            }

            if (ElegirPartido.SelectedIndex == 19) // PARTIDO [20] GRUPO B
            {
                pictureBoxPais1.Image = Resources.BanInglaterra;
                pictureBoxPais2.Image = Resources.BanEEUU;

                txtPais1.Text = "Inglaterra";
                txtPais2.Text = "Estados Unidos";

                txtFecha.Text = "25/11";

                txtGrupo1.Text = "Grupo B";
                txtGrupo2.Text = "Grupo B";
            }

            if (ElegirPartido.SelectedIndex == 20) // PARTIDO [21] GRUPO D
            {
                pictureBoxPais1.Image = Resources.BanAustralia;
                pictureBoxPais2.Image = Resources.BanTunez;

                txtPais1.Text = "Australia";
                txtPais2.Text = "Tunez";

                txtFecha.Text = "26/11";

                txtGrupo1.Text = "Grupo D";
                txtGrupo2.Text = "Grupo D";
            }

            if (ElegirPartido.SelectedIndex == 21) // PARTIDO [22] GRUPO C
            {
                pictureBoxPais1.Image = Resources.BanArabiaSaudita;
                pictureBoxPais2.Image = Resources.BanPolonia;

                txtPais1.Text = "Arabia Saudita";
                txtPais2.Text = "Polonia";

                txtFecha.Text = "26/11";

                txtGrupo1.Text = "Grupo C";
                txtGrupo2.Text = "Grupo C";
            }

            if (ElegirPartido.SelectedIndex == 22) // PARTIDO [23] GRUPO D
            {
                pictureBoxPais1.Image = Resources.BanFrancia;
                pictureBoxPais2.Image = Resources.BanDinamarca;

                txtPais1.Text = "Francia";
                txtPais2.Text = "Dinamarca";

                txtFecha.Text = "26/11";

                txtGrupo1.Text = "Grupo D";
                txtGrupo2.Text = "Grupo D";
            }

            if (ElegirPartido.SelectedIndex == 23) // PARTIDO [24] GRUPO C
            {
                pictureBoxPais1.Image = Resources.BanArgentina;
                pictureBoxPais2.Image = Resources.BanMex;

                txtPais1.Text = "Argentina";
                txtPais2.Text = "Mexico";

                txtFecha.Text = "26/11";

                txtGrupo1.Text = "Grupo C";
                txtGrupo2.Text = "Grupo C";
            }

            if (ElegirPartido.SelectedIndex == 24) // PARTIDO [25] GRUPO E
            {
                pictureBoxPais1.Image = Resources.BanCostaRica;
                pictureBoxPais2.Image = Resources.BanJapon;

                txtPais1.Text = "Costa Rica";
                txtPais2.Text = "Japon";

                txtFecha.Text = "27/11";

                txtGrupo1.Text = "Grupo E";
                txtGrupo2.Text = "Grupo E";
            }

            if (ElegirPartido.SelectedIndex == 25) // PARTIDO [26] GRUPO F
            {
                pictureBoxPais1.Image = Resources.BanBelgica;
                pictureBoxPais2.Image = Resources.BanMarruecos;

                txtPais1.Text = "Belgica";
                txtPais2.Text = "Marruecos";

                txtFecha.Text = "27/11";

                txtGrupo1.Text = "Grupo F";
                txtGrupo2.Text = "Grupo F";
            }

            if (ElegirPartido.SelectedIndex == 26) // PARTIDO [27] GRUPO F
            {
                pictureBoxPais1.Image = Resources.BanCanada;
                pictureBoxPais2.Image = Resources.BanCroacia;

                txtPais1.Text = "Canada";
                txtPais2.Text = "Croacia";

                txtFecha.Text = "27/11";

                txtGrupo1.Text = "Grupo F";
                txtGrupo2.Text = "Grupo F";
            }

            if (ElegirPartido.SelectedIndex == 27) // PARTIDO [28] GRUPO E
            {
                pictureBoxPais1.Image = Resources.BanEspaña;
                pictureBoxPais2.Image = Resources.BanAlemania;

                txtPais1.Text = "España";
                txtPais2.Text = "Alemania";

                txtFecha.Text = "27/11";

                txtGrupo1.Text = "Grupo E";
                txtGrupo2.Text = "Grupo E";
            }

            if (ElegirPartido.SelectedIndex == 28) // PARTIDO [29] GRUPO G
            {
                pictureBoxPais1.Image = Resources.BanSerbia;
                pictureBoxPais2.Image = Resources.BanCamerun;

                txtPais1.Text = "Serbia";
                txtPais2.Text = "Camerun";
                txtFecha.Text = "28/11";

                txtGrupo1.Text = "Grupo G";
                txtGrupo2.Text = "Grupo G";
            }

            if (ElegirPartido.SelectedIndex == 29) // PARTIDO [30] GRUPO H
            {
                pictureBoxPais1.Image = Resources.BanGhana;
                pictureBoxPais2.Image = Resources.BanCoreaDelSur;

                txtPais1.Text = "Ghana";
                txtPais2.Text = "Corea del Sur";

                txtFecha.Text = "28/11";

                txtGrupo1.Text = "Grupo H";
                txtGrupo2.Text = "Grupo H";
            }

            if (ElegirPartido.SelectedIndex == 30) // PARTIDO [31] GRUPO G
            {
                pictureBoxPais1.Image = Resources.BanBrasil;
                pictureBoxPais2.Image = Resources.BanSuiza;

                txtPais1.Text = "Brasil";
                txtPais2.Text = "Suiza";

                txtFecha.Text = "28/11";

                txtGrupo1.Text = "Grupo G";
                txtGrupo2.Text = "Grupo G";
            }

            if (ElegirPartido.SelectedIndex == 31) // PARTIDO [32] GRUPO H
            {
                pictureBoxPais1.Image = Resources.BanPortugal;
                pictureBoxPais2.Image = Resources.BanUruguay;

                txtPais1.Text = "Portugal";
                txtPais2.Text = "Uruguay";

                txtFecha.Text = "28/11";

                txtGrupo1.Text = "Grupo H";
                txtGrupo2.Text = "Grupo H";
            }

            if (ElegirPartido.SelectedIndex == 32) // PARTIDO [33] GRUPO A
            {
                pictureBoxPais1.Image = Resources.BanQatar;
                pictureBoxPais2.Image = Resources.BanPaisesBajos;

                txtPais1.Text = "Qatar";
                txtPais2.Text = "Paises Bajos";

                txtFecha.Text = "29/11";

                txtGrupo1.Text = "Grupo A";
                txtGrupo2.Text = "Grupo A";
            }

            if (ElegirPartido.SelectedIndex == 33) // PARTIDO [34] GRUPO A
            {
                pictureBoxPais1.Image = Resources.BanEcuador;
                pictureBoxPais2.Image = Resources.BanSenegal;

                txtPais1.Text = "Ecuador";
                txtPais2.Text = "Senegal";

                txtFecha.Text = "29/11";

                txtGrupo1.Text = "Grupo A";
                txtGrupo2.Text = "Grupo A";
            }

            if (ElegirPartido.SelectedIndex == 34) // PARTIDO [35] GRUPO B
            {
                pictureBoxPais1.Image = Resources.BanInglaterra;
                pictureBoxPais2.Image = Resources.BanGales;

                txtPais1.Text = "Inglaterra";
                txtPais2.Text = "Gales";

                txtFecha.Text = "29/11";

                txtGrupo1.Text = "Grupo B";
                txtGrupo2.Text = "Grupo B";
            }

            if (ElegirPartido.SelectedIndex == 35) // PARTIDO [36] GRUPO B
            {
                pictureBoxPais1.Image = Resources.BanIràn;
                pictureBoxPais2.Image = Resources.BanEEUU;

                txtPais1.Text = "Irán";
                txtPais2.Text = "Estados Unidos";

                txtFecha.Text = "29/11";

                txtGrupo1.Text = "Grupo B";
                txtGrupo2.Text = "Grupo B";
            }

            if (ElegirPartido.SelectedIndex == 36) // PARTIDO [37] GRUPO D
            {
                pictureBoxPais1.Image = Resources.BanAustralia;
                pictureBoxPais2.Image = Resources.BanDinamarca;

                txtPais1.Text = "Australia";
                txtPais2.Text = "Dinamarca";

                txtFecha.Text = "30/11";

                txtGrupo1.Text = "Grupo D";
                txtGrupo2.Text = "Grupo D";
            }

            if (ElegirPartido.SelectedIndex == 37) // PARTIDO [38] GRUPO D
            {
                pictureBoxPais1.Image = Resources.BanFrancia;
                pictureBoxPais2.Image = Resources.BanTunez;

                txtPais1.Text = "Francia";
                txtPais2.Text = "Tunez";

                txtFecha.Text = "30/11";

                txtGrupo1.Text = "Grupo D";
                txtGrupo2.Text = "Grupo D";
            }

            if (ElegirPartido.SelectedIndex == 38) // PARTIDO [39] GRUPO C
            {
                pictureBoxPais1.Image = Resources.BanPolonia;
                pictureBoxPais2.Image = Resources.BanArgentina;

               txtPais1.Text = "Polonia";
                txtPais2.Text = "Argentina";

                txtFecha.Text = "30/11";

                txtGrupo1.Text = "Grupo C";
                txtGrupo2.Text = "Grupo C";
            }

            if (ElegirPartido.SelectedIndex == 39) // PARTIDO [40] GRUPO C
            {
                pictureBoxPais1.Image = Resources.BanArabiaSaudita;
                pictureBoxPais2.Image = Resources.BanMex;

                txtPais1.Text = "Arabia Saudita";
                txtPais2.Text = "Mexico";

                txtFecha.Text = "30/11";

                txtGrupo1.Text = "Grupo C";
                txtGrupo2.Text = "Grupo C";
            }

            if (ElegirPartido.SelectedIndex == 40) // PARTIDO [41] GRUPO F
            {
                pictureBoxPais1.Image = Resources.BanBelgica;
                pictureBoxPais2.Image = Resources.BanCroacia;

                txtPais1.Text = "Belgica";
                txtPais2.Text = "Croacia";

                txtFecha.Text = "1/12";

                txtGrupo1.Text = "Grupo F";
                txtGrupo2.Text = "Grupo F";
            }

            if (ElegirPartido.SelectedIndex == 41) // PARTIDO [42] GRUPO F
            {
                pictureBoxPais1.Image = Resources.BanCanada;
                pictureBoxPais2.Image = Resources.BanMarruecos;

                txtPais1.Text = "Canada";
                txtPais2.Text = "Marruecos";

                txtFecha.Text = "1/12";

                txtGrupo1.Text = "Grupo F";
                txtGrupo2.Text = "Grupo F";
            }

            if (ElegirPartido.SelectedIndex == 42) // PARTIDO [43] GRUPO E
            {
                pictureBoxPais1.Image = Resources.BanEspaña;
                pictureBoxPais2.Image = Resources.BanJapon;
    
                txtPais1.Text = "España";
                txtPais2.Text = "Japon";

                txtFecha.Text = "1/12";

                txtGrupo1.Text = "Grupo E";
                txtGrupo2.Text = "Grupo E";
            }

            if (ElegirPartido.SelectedIndex == 43) // PARTIDO [44] GRUPO E
            {
                pictureBoxPais1.Image = Resources.BanCostaRica;
                pictureBoxPais2.Image = Resources.BanAlemania;

                txtPais1.Text = "Costa Rica";
                txtPais2.Text = "Alemania";

                txtFecha.Text = "1/12";

                txtGrupo1.Text = "Grupo E";
                txtGrupo2.Text = "Grupo E";
            }

            if (ElegirPartido.SelectedIndex == 44) // PARTIDO [45] GRUPO H
            {
                pictureBoxPais1.Image = Resources.BanGhana;
                pictureBoxPais2.Image = Resources.BanUruguay;

                txtPais1.Text = "Ghana";
                txtPais2.Text = "Uruguay";

                txtFecha.Text = "2/12";

                txtGrupo1.Text = "Grupo H";
                txtGrupo2.Text = "Grupo H";
            }

            if (ElegirPartido.SelectedIndex == 45) // PARTIDO [46] GRUPO H
            {
                pictureBoxPais1.Image = Resources.BanPortugal;
                pictureBoxPais2.Image = Resources.BanCoreaDelSur;

                txtPais1.Text = "Portugal";
                txtPais2.Text = "Corea del Sur";

                txtFecha.Text = "2/12";

                txtGrupo1.Text = "Grupo H";
                txtGrupo2.Text = "Grupo H";
            }

            if (ElegirPartido.SelectedIndex == 46) // PARTIDO [47] GRUPO G
            {
                pictureBoxPais1.Image = Resources.BanSerbia;
                pictureBoxPais2.Image = Resources.BanSuiza;

               txtPais1.Text = "Serbia";
                txtPais2.Text = "Suiza";

                txtFecha.Text = "2/12";

                txtGrupo1.Text = "Grupo G";
                txtGrupo2.Text = "Grupo G";
            }

            if (ElegirPartido.SelectedIndex == 47) // PARTIDO [48] GRUPO G
            {
                pictureBoxPais1.Image = Resources.BanSerbia;
                pictureBoxPais2.Image = Resources.BanSuiza;

                txtPais1.Text = "Serbia";
                txtPais2.Text = "Suiza";

                txtFecha.Text = "2/12";

                txtGrupo1.Text = "Grupo G";
                txtGrupo2.Text = "Grupo G";
            }

        
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ControlSection.SelectedIndex = 1;
        }


        public static void CargarEquipo1()
        {
            Partido partido = new Partido();
            //para el equipo1

            /*  if (txtRes_eq_uno < txtRes_eq_dos) //cuando pierde
                  {
                  partido.Cant_partidos = +1;

                  partido.Partidos_ganados = 0;
                  partido.Partidos_perdidos = +1;
                  partido.Partidos_empatados = 0;
                  partido.Puntos = 0;
                  partido.Dif_goles = txtresultado1 - txtresultado2;
                  partido.Cant_goles_a_favor = txtresultado1//aca va el txt 
                  partido.Cant_goles_en_contra = txtresultado2//

              }
              else //cuando gana
              {
                  partido.Cant_partidos = +1;

                  partido.Partidos_ganados = 1;
                  partido.Partidos_perdidos = 0;
                  partido.Partidos_empatados = 0;
                  partido.Puntos = +3;
                  partido.Dif_goles = txtresultado1 - txtresultado2;
                  partido.Cant_goles_a_favor = txtresultado1//aca va el txt 
                  partido.Cant_goles_en_contra = txtresultado2//
              }
              if (txtRes_eq_uno == txtRes_eq_dos) //cuando empata
              {
                  partido.Cant_partidos = +1;

                  partido.Partidos_ganados = 0;
                  partido.Partidos_perdidos = 0;
                  partido.Partidos_empatados = 1;
                  partido.Puntos = 1;
                  partido.Dif_goles = txtresultado1 - txtresultado2;
                  partido.Cant_goles_a_favor = txtresultado1//aca va el txt 
                  partido.Cant_goles_en_contra = txtresultado2//
              }

          }
          public void CargarEquipo2()
          {
              Partido partido = new Partido();
              //para el equipo2
              if (partido.Res_eq_dos < partido.Res_eq_uno)
              {
                  partido.Cant_partidos ++;

                  partido.Partidos_ganados = 0;
                  partido.Partidos_perdidos ++;
                  partido.Partidos_empatados = 0;
                  partido.Puntos = 0;
                  //partido.Dif_goles = txtresultado1 - txtresultado2;
                  //partido.Cant_goles_a_favor = txtresultado1//aca va el txt 
                  //partido.Cant_goles_en_contra = txtresultado2//
              }
              else //cuando gana
              {
                  partido.Cant_partidos ++;

                  partido.Partidos_ganados ++;
                  partido.Partidos_perdidos = 0;
                  partido.Partidos_empatados = 0;
                  partido.Puntos +=3;
                  //partido.Dif_goles = txtresultado1 - txtresultado2;
                  //partido.Cant_goles_a_favor = txtresultado1//aca va el txt 
                  //partido.Cant_goles_en_contra = txtresultado2//
              }
              if (partido.Res_eq_uno == partido.Res_eq_dos)
              {
                  partido.Cant_partidos ++;

                  partido.Partidos_ganados = 0;
                  partido.Partidos_perdidos = 0;
                  partido.Partidos_empatados ++;
                  partido.Puntos ++;
                  //partido.Dif_goles = txtresultado1 - txtresultado2;
                  //partido.Cant_goles_a_favor = txtresultado1//aca va el txt 
                  //partido.Cant_goles_en_contra = txtresultado2//
              }*/
        }
    }
}
