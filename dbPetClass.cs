using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFLearning1
{
    internal class dbPetClass
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=mysql_pet_places";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("My SQL Connection!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        public static void AddPet(PetClass pet)
        {
            string sql = "INSERT INTO pet_table VALUES (NULL, @AnimalType, @PetName, @Breed, @Colour, @Suburb, @OwnerName, NULL)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@AnimalType", MySqlDbType.VarChar).Value = pet.AnimalType;
            cmd.Parameters.Add("@PetName", MySqlDbType.VarChar).Value = pet.PetName;
            cmd.Parameters.Add("@Breed", MySqlDbType.VarChar).Value = pet.Breed;
            cmd.Parameters.Add("@Colour", MySqlDbType.VarChar).Value = pet.Colour;
            cmd.Parameters.Add("@Suburb", MySqlDbType.VarChar).Value = pet.Suburb;
            cmd.Parameters.Add("@OwnerName", MySqlDbType.VarChar).Value = pet.OwnerName;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Pet not inserted. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void UpdatePet(PetClass pet, string ID)
        {
            string sql = "UPDATE pet_table SET AnimalType = @AnimalType, PetName = @PetName, Breed = @Breed, Colour = @Colour, Suburb = @Suburb, OwnerName = @OwnerName WHERE ID = @PetID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@PetID", MySqlDbType.VarChar).Value = ID;
            cmd.Parameters.Add("@AnimalType", MySqlDbType.VarChar).Value = pet.AnimalType;
            cmd.Parameters.Add("@PetName", MySqlDbType.VarChar).Value = pet.PetName;
            cmd.Parameters.Add("@Breed", MySqlDbType.VarChar).Value = pet.Breed;
            cmd.Parameters.Add("@Colour", MySqlDbType.VarChar).Value = pet.Colour;
            cmd.Parameters.Add("@Suburb", MySqlDbType.VarChar).Value = pet.Suburb;
            cmd.Parameters.Add("@OwnerName", MySqlDbType.VarChar).Value = pet.OwnerName;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Pet not updated. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

        }
        public static void DeletePet(string id)
        {
            string sql = "DELETE FROM pet_table WHERE ID = @PetID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@PetID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Pet not deleted. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            conn.Close();
        }
    }
}
