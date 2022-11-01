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
    public partial class FormPetRegister : Form
    {
        private readonly FormPet _parent;
        public string ID, animaltype, petname, breed, colour, suburb, ownername;

        public FormPetRegister(FormPet parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            lblPetRegistration.Text = "Update Pet";
            buttonSave.Text = "Update";
            textType.Text = animaltype;
            textPName.Text = petname;
            textBreed.Text = breed;
            textColour.Text = colour;
            textSuburb.Text = suburb;
            textOName.Text = ownername;
        }

        public void SaveInfo()
        {
            lblPetRegistration.Text = "Add Pet";
            buttonSave.Text = "Save";
        }
        public void Clear()
        {
            textType.Text = textPName.Text = textBreed.Text = textColour.Text = textSuburb.Text = textOName.Text = string.Empty;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textType.Text.Trim().Length < 3)
            {
                MessageBox.Show("Animal Type is empty ( > 3).");
                return;
            }
            if (textPName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Pet name is empty ( > 3).");
                return;
            }
            if (textBreed.Text.Trim().Length < 3)
            {
                MessageBox.Show("Pet breed is empty ( > 3).");
                return;
            }
           
            if (textColour.Text.Trim().Length < 3)
            {
                MessageBox.Show("Pet colour is empty ( > 3).");
                return;
            }
            if (textSuburb.Text.Trim().Length < 3)
            {
                MessageBox.Show("Suburb is empty ( > 3).");
                return;
            }
            if (textOName.Text.Trim().Length < 2)
            {
                MessageBox.Show("Owner name is empty ( > 2).");
                return;
            }
            if(buttonSave.Text == "Save")
            {
                PetClass pet = new PetClass(textType.Text.Trim(), textPName.Text.Trim(), textBreed.Text.Trim(), textColour.Text.Trim(), textSuburb.Text.Trim(), textOName.Text.Trim());
                dbPetClass.AddPet(pet);
                Clear();
            }
            if(buttonSave.Text == "Update")
            {
                PetClass pet = new PetClass(textType.Text.Trim(), textPName.Text.Trim(), textBreed.Text.Trim(), textColour.Text.Trim(), textSuburb.Text.Trim(), textOName.Text.Trim());
                dbPetClass.UpdatePet(pet, ID);
            }

            _parent.Display();
        }
    }
}
