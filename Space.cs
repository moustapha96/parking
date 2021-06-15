using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GestionParking
{
    class Space
    {
        public int voiture_id;
        public int place_id;
        public double temps;

        MySqlConnection myconnection;
        public Space() { }
        public Space(int voiture_id, int place_id, double temps)
        {
            this.voiture_id = voiture_id;
            this.place_id = place_id;
            this.temps = temps;
          
            myconnection = new MySqlConnection("Data Source=localhost;Initial Catalog=parking_db;User ID=root;Password=");
            myconnection.Open();
        }
        public void toString()
        {
            Console.WriteLine("vouture: + " + this.voiture_id + "\n place : " +this.place_id +  "temps de séjour : " + this.temps);
        }

        public void addCarDB()
        {
            MySqlConnection myconnection = new MySqlConnection("Data Source=localhost;Initial Catalog=parking_db;User ID=root;Password=");
            myconnection.Open();

            string query = string.Format(
                  "INSERT INTO space (voiture_id,place_id,temps) values ('{0}','{1}','{2}')",
                  this.voiture_id, this.place_id, this.temps);
            try
            {
                MySqlCommand mycommand = new MySqlCommand(query, myconnection);
                mycommand.ExecuteNonQuery();
                MessageBox.Show(" enregistrement réussie voiture place réussie !!");
                Voiture v = new Voiture(); v.updateEtat1(place_id);
                Place place = new Place(); place.updateEtat1(place_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur"+ ex.Message);
            }



        }
        public DataTable getDataAsync()
        {

            DataTable dts = new DataTable();
            MySqlConnection connect = new MySqlConnection("SERVER=localhost; user id=root; password=; database=parking_db");
            MySqlCommand cmd = new MySqlCommand("SELECT* from space");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;
            connect.Open();
            try
            {
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                dts.Load(dr);
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
            return dts;
        }
        public DataTable getDataCarPlaceTime()
        {
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
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                dts.Load(dr);
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
            return dts;
        }

        public void delete(int id)
        {

            MySqlConnection myconnection = new MySqlConnection("Data Source=localhost;Initial Catalog=parking_db;User ID=root;Password=");
            myconnection.Open();

            string query = string.Format(
                         "DELETE from space  where id ='{0}' ", id);
            try
            {
                MySqlCommand mycommand = new MySqlCommand(query, myconnection);
                mycommand.ExecuteNonQuery();
                MessageBox.Show("place liberer  !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur " + ex.Message);
            }
        }
    }
}
