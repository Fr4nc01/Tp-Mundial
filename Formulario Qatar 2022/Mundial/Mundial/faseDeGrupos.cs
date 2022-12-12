
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
            btnCargaDatos.Visible = true;
            groupBoxCarga.Visible = true;
            btnCargar.Visible = false;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            btnVolver.Visible = true;



        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            BtnAyuda.Visible = false;
            btnCargaDatos.Visible = false;
            groupBoxCarga.Visible = false;
            btnCargar.Visible = true;
            btnEliminar.Visible = true;
            btnModificar.Visible = true;
            btnVolver.Visible = false;
        }

        private void btnCargaDatos_Click(object sender, EventArgs e) 
        {
            BtnAyuda.Visible = false;
            btnCargaDatos.Visible = false;
            groupBoxCarga.Visible = false;
            btnCargar.Visible = true;
            btnEliminar.Visible = true;
            btnModificar.Visible = true;
            btnVolver.Visible = false;

            if (consultado == false)
            {
                MessageBox.Show("consulte su pais antes de cargar.");
            }

            try
            {
                Partido partido = new Partido();

                partido.Cant_partidos = Convert.ToInt32(txtPartJugado.Text.Trim());
                partido.T_amarilla1 = Convert.ToInt32(txtTAmarilla.Text.Trim());
                partido.T_rojas1 = Convert.ToInt32(txtTRojas.Text.Trim());
                partido.Partidos_ganados = Convert.ToInt32(txtPartidosGanados.Text.Trim());
                partido.Partidos_perdidos = Convert.ToInt32(txtPerdidos.Text.Trim());
                partido.Partidos_empatados = Convert.ToInt32(txtEmpate.Text.Trim());
                partido.Dif_goles = Convert.ToInt32(txtDifGoles.Text.Trim());
                partido.Cant_goles_a_favor = Convert.ToInt32(txtGolesAfavor.Text.Trim());
                partido.Cant_goles_en_contra = Convert.ToInt32(txtGolesEnContra.Text.Trim());

                if (crudPartidos.actualizar(partido))
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
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           panelSeguroEliminar.Visible = true;
        }

        private void btnEliminarNo_Click(object sender, EventArgs e)
        {
            panelSeguroEliminar.Visible = false;
        }

        private void btnEliminarSi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos eliminados correctamente!");
            panelSeguroEliminar.Visible = false;
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
    }

}
