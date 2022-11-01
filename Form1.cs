using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WFLearning1
{
    
    public partial class FormPet : Form

        
    {
        FormPetRegister form;

        public FormPet()
        {
            InitializeComponent();
            form = new FormPetRegister(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer timer1 = new Timer();
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .2;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            dbPetClass.DisplayAndSearch("SELECT ID, AnimalType, PetName,  Breed, Colour, Suburb, OwnerName FROM pet_table WHERE AnimalType LIKE'%" + textSearch.Text + "%'", dataGridView);
        }
        
        public void Display()
        {
            dbPetClass.DisplayAndSearch("SELECT ID, AnimalType, PetName, Breed, Colour, Suburb, OwnerName FROM pet_table", dataGridView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void FormPet_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                // Edit
                form.Clear();
                form.ID = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.animaltype = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.petname = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.breed = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.colour = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.suburb = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.ownername = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                // Delete
                string message = "Are you sure that you want to delete this pet record?";
                string title = "Delete Pet Record";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    dbPetClass.DeletePet(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                else
                {
                    return;
                }
            }
        }

    }
}
