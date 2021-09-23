/*
 Dyson Smith
 Sept 23 2021
 Scam website
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace identety_theft
{
    public partial class id_theft_form : Form
    {
        String first_name;
        String last_name;
        String phone_num;
        String email;
        String credit_num;
        String expo_date;
        String pet_name;
        String blood_type;
        String b_day;
        String gamer_tag;
        public id_theft_form()
        {
            InitializeComponent();
        }

        private void id_theft_form_Load(object sender, EventArgs e)
        {
            String name = "Dyson";//Displaying a warning about website
            MessageBox.Show("Warning! Warning! May I have Cookies?");
        }

        private void title_lbl_Click(object sender, EventArgs e)
        {}
        private void submit_bttn_Click(object sender, EventArgs e)
        {
            first_name = first_name_txb.Text;//after sbmit button is hit desplay all the info gathered
            MessageBox.Show(@"Thank you "+first_name+". Per your request all money is now funding the giraffe mafia" +
                ""+first_name+" "+last_name+" ");
        }

        private void txb_TextChanged(object sender, EventArgs e)
        {
            gamer_tag = gamer_tag_txb.Text;
            b_day = b_day_txb.Text;
            blood_type = blood_type_txb.Text;
            pet_name = pet_name_txb.Text;
            expo_date = expo_date_txb.Text;
            credit_num = credit_num_txb.Text;
            email = email_txb.Text;
            phone_num = phone_num_txb.Text;
            last_name = last_name_txb.Text;
            first_name = first_name_txb.Text;
            MessageBox.Show("testing");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
