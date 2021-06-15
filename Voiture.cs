using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionParking
{
    class Voiture
    {
        public double longueur;
        public double largeur;
        public double temps;
        public string matricule;
        MySqlConnection myconnection;
        public Voiture() { }
        public Voiture(double longueur, double largeur, double temps)
        {
            this.longueur = longueur;
            this.largeur = largeur;
            this.temps = temps;
            this.matricule = "A" + (longueur + largeur)+"-"+temps+ "C";
            myconnection = new MySqlConnection("Data Source=localhost;Initial Catalog=parking_db;User ID=root;Password=");
            myconnection.Open();
        }
        public void updateEtat1(int id)
        {
            MySqlConnection myconnection = new MySqlConnection("Data Source=localhost;Initial Catalog=parking_db;User ID=root;Password=");
            myconnection.Open();

            string query = string.Format(
                         "UPDATE voiture SET etat = 1 where id ='{0}' ",id);
           

            try
            {
                MySqlCommand mycommand = new MySqlCommand(query, myconnection);
                mycommand.ExecuteNonQuery();
                MessageBox.Show(" etat voiture true !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur "+ ex.Message);
            }

        }
        public void updateEtat0(int id)
        {
            MySqlConnection myconnection = new MySqlConnection("Data Source=localhost;Initial Catalog=parking_db;User ID=root;Password=");
            myconnection.Open();

            string query = string.Format(
                         "UPDATE voiture SET etat = 0 where id ='{0}' ", id);


            try
            {
                MySqlCommand mycommand = new MySqlCommand(query, myconnection);
                mycommand.ExecuteNonQuery();
                MessageBox.Show(" etat voiture false !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur " + ex.Message);
            }

        }
        public void toString()
        {
            Console.WriteLine("vouture: + " + matricule + "\n Longeur : " + this.longueur + "largeur : " + this.largeur + "temps de séjour : " + this.temps);
        }

        public void addCarDB()
        {
            MySqlConnection myconnection = new MySqlConnection("Data Source=localhost;Initial Catalog=parking_db;User ID=root;Password=");
            myconnection.Open();

            string query = string.Format(
                  "INSERT INTO voiture (matricule,longueur,largeur,temps) values ('{0}','{1}','{2}','{3}')",
                  this.matricule, this.longueur, this.largeur, this.temps);
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
        public DataTable getDataAsync()
        {
            DataTable dts = new DataTable();
            MySqlConnection connect = new MySqlConnection("SERVER=localhost; user id=root; password=; database=parking_db");
            MySqlCommand cmd = new MySqlCommand("SELECT* from voiture");
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
        public DataTable getCarAttente()
        {
            DataTable dts = new DataTable();
            MySqlConnection connect = new MySqlConnection("SERVER=localhost; user id=root; password=; database=parking_db");
            MySqlCommand cmd = new MySqlCommand("SELECT* from voiture where etat = 0 ");
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
