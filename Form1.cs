using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
namespace GestionParking
{
    public partial class Form1 : Form
    {
        public MySqlConnection conn = null;
        public MySqlCommand mysqlCommand = null;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = new Voiture().getDataAsync();
            dataGridView3.DataSource = new Place().getDataAsync();
            dataGridView2.DataSource = new Space().getDataCarPlaceTime();
        }
        private void button_save_v_Click(object sender, EventArgs e)
        {
            double largeur = Double.Parse(textBox_largeur.Text);
            double longueur = Double.Parse(textBox_longueur.Text);
            double  t =  Double.Parse( textBox_temps.Text);
            Voiture v = new Voiture(longueur, largeur, t);
            v.addCarDB();
        }
        private void button_place_Click(object sender, EventArgs e)
        {
            double largeur = Double.Parse(textBox_longueur_place.Text);
            double longueur = Double.Parse(textBox_largeur_place.Text);
            Place p = new Place(longueur, largeur);

            p.addPlaceDB();
        }
        private void button_actualiser_l_a_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = new Voiture().getCarAttente();
        }
        private void button_liste_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Voiture().getDataAsync();
            dataGridView3.DataSource = new Place().getDataAsync();
            dataGridView2.DataSource = new Space().getDataCarPlaceTime();
            actualise_combo();
            actualise_combo_vp();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double longueur= 0, largeur= 0;
            int id_v = 0;
            int temps= 0;
            MySqlDataReader reader;
            Object selecte = comboBox_voiture.SelectedItem.ToString();
            MySqlConnection connect = new MySqlConnection("SERVER=localhost; user id=root; password=; database=parking_db");
            string commande = "SELECT * FROM voiture WHERE etat = 0 AND matricule = @matricule";
            MySqlCommand cmd = new MySqlCommand(commande);
            string sele = selecte.ToString();
            cmd.Parameters.AddWithValue("matricule", sele);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;
            connect.Open();
            try

            {

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show(reader.GetString(0) + "" + reader.GetString(1) + "--" + reader.GetString(2) + "--" + reader.GetString(3));
                    longueur = reader.GetDouble(1);
                    largeur = reader.GetDouble(2);
                    id_v = reader.GetInt32(0);
                    temps = reader.GetInt32(3);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }

            /* verification des place correspondant à la voiture  */
            DataTable place = new Place().getDataFreePlace();

            for (int i = 0; i < place.Rows.Count; i++)
            {
                double log = Double.Parse (place.Rows[i].ItemArray[1].ToString());
                double lag = Double.Parse (place.Rows[i].ItemArray[2].ToString());
                int place_id = Int16.Parse( place.Rows[i].ItemArray[0].ToString());
               
                if (  longueur <= log  &&  largeur <= lag)
                 {
                    Space space = new Space(id_v, place_id, temps);
                    space.addCarDB();
                    return;
                 }
                else
                {
                    MessageBox.Show("la place ne peut pas contenir cette voiture");
                }
            }
        }
        private void button_actualiser_place_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = new Place().getDataAsync();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void actualise_combo()
        {
            comboBox_voiture.Items.Clear();
            DataTable dts = new DataTable();
            MySqlConnection connect = new MySqlConnection("SERVER=localhost; user id=root; password=; database=parking_db");
            MySqlCommand cmd = new MySqlCommand("SELECT* from voiture where etat = 0 ");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;
            connect.Open();
            try
            {
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();

                DataTable schemaTable = reader.GetSchemaTable();

                while (reader.Read())
                {
                    comboBox_voiture.Items.Add(reader.GetString(4));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }
        public void actualise_combo_vp()
        {
            comboBox_liste_vp.Items.Clear();
            DataTable dts = new DataTable();
            MySqlConnection connect = new MySqlConnection("SERVER=localhost; user id=root; password=; database=parking_db");
            string requette = "SELECT space.id as N° , voiture.matricule ,voiture.id as N°V , place.id as N°Place, space.temps  ,place.longueur , place.largeur " +
                                "FROM  voiture " +
                                "JOIN space ON voiture.id = space.voiture_id JOIN place ON place.id = space.place_id";
            MySqlCommand cmd = new MySqlCommand(requette);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;
            connect.Open();
            try
            {
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();

                DataTable schemaTable = reader.GetSchemaTable();

                while (reader.Read())
                {
                    comboBox_liste_vp.Items.Add(reader.GetString(0)+" "+
                        reader.GetInt32(2)+" "+reader.GetInt32(3));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }
        private void button_liberer_v_Click(object sender, EventArgs e)
        {
            Object selecte = comboBox_liste_vp.SelectedItem.ToString();
            string s = comboBox_liste_vp.SelectedItem.ToString();
            string[] subs = s.Split(' ');
            int id_s =  int.Parse( subs[0]);
            MessageBox.Show("s" + id_s);  
            int id_v = int.Parse(subs[1]);
            MessageBox.Show("v" + id_v);
            int id_p =int.Parse (subs[2]);
            MessageBox.Show("p" + id_p);




            Voiture v = new Voiture();
            v.updateEtat0(id_v);
            Place p = new Place();
            p.updateEtat0(id_p);
            Space ps = new Space();
            ps.delete(id_s);


        }
    }
}
