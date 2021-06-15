using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GestionParking
{
    class Place
    {
		public double longueur;
		public double largeur;
		public int id;
		MySqlConnection myconnection;
	
		public Place() { }
		public Place(double longueur, double largeur)
		{
			this.longueur = longueur;
			this.largeur = largeur;
			myconnection = new MySqlConnection("Data Source=localhost;Initial Catalog=parking_db;User ID=root;Password=");
			myconnection.Open();
		}
		
		public void addPlaceDB()
		{

            string query = string.Format(
                  "INSERT INTO place (longueur,largeur) values ('{0}','{1}')",
                   this.longueur, this.largeur);
            try
            {
                MySqlCommand mycommand = new MySqlCommand(query, myconnection);
                mycommand.ExecuteNonQuery();
                MessageBox.Show(" enregistrement réussie !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible d'etablir la connexion avec le serveur ! ");
            }

        }

        public void updateEtat1(int id)
        {
            MySqlConnection myconnection = new MySqlConnection("Data Source=localhost;Initial Catalog=parking_db;User ID=root;Password=");
            myconnection.Open();

            string query = string.Format(
                         "UPDATE place SET etat = 1 where id ='{0}' ", id);


            try
            {
                MySqlCommand mycommand = new MySqlCommand(query, myconnection);
                mycommand.ExecuteNonQuery();
                MessageBox.Show(" etat place true !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur " + ex.Message);
            }

        }
        public void updateEtat0(int id)
        {
            MySqlConnection myconnection = new MySqlConnection("Data Source=localhost;Initial Catalog=parking_db;User ID=root;Password=");
            myconnection.Open();

            string query = string.Format(
                         "UPDATE place SET etat = 0 where id ='{0}' ", id);


            try
            {
                MySqlCommand mycommand = new MySqlCommand(query, myconnection);
                mycommand.ExecuteNonQuery();
                MessageBox.Show(" etat place false !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur " + ex.Message);
            }

        }
        public DataTable getDataAsync()
        {

            DataTable dts = new DataTable();
            MySqlConnection connect = new MySqlConnection("SERVER=localhost; user id=root; password=; database=parking_db");
            MySqlCommand cmd = new MySqlCommand("SELECT* from place");
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
        public DataTable getDataFreePlace()
        {

            DataTable dts = new DataTable();
            MySqlConnection connect = new MySqlConnection("SERVER=localhost; user id=root; password=; database=parking_db");
            MySqlCommand cmd = new MySqlCommand("SELECT* from place where etat = 0");
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
    }
}
