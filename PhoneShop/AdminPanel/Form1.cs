using AdminPanel.AdminPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel
{
    public partial class Form1 : Form
    {
        //List of phones
        public static List<Phone> phones = new List<Phone>();

        public Form1()
        {
            InitializeComponent();

            //Parse phones from list to listBox
            foreach(Phone phone in phones)
            {
                listBox1.Items.Add(phone.Id + " : " + phone.Producer + " : " + phone.Model + " : " + phone.Price);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Add phone to list
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Phone phone = new Phone();

                //Id
                if(phones.Count == 0)
                phone.Id = 1;
                else
                phone.Id = phones[phones.Count - 1].Id + 1;

                //Producer
                if (textBox1.Text.Equals("") || textBox1.Text.Contains(':'))
                {
                    MessageBox.Show("Producer can not be empty or with bad character!");
                    return;
                }
                else
                    phone.Producer = textBox1.Text;

                //Model
                if (textBox2.Text.Equals("") || textBox2.Text.Contains(':'))
                {
                    MessageBox.Show("Model can not be empty or with bad character!");
                    return;
                }
                else
                    phone.Model = textBox2.Text;

                //Price
                if (textBox3.Text.Equals("") || textBox3.Text.Contains(':'))
                {
                    MessageBox.Show("Price can not be empty or with bad character!");
                    return;
                }
                else
                    phone.Price = Double.Parse(textBox3.Text);

                phones.Add(phone);

                listBox1.Items.Add(phone.Id + " : " + phone.Producer + " : " + phone.Model + " : " + phone.Price);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Remove phone from list
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<Phone> tempPhones = new List<Phone>();
                foreach (Phone phone in phones)
                {
                    if(int.Parse(listBox1.SelectedItem.ToString().Split(':')[0].Replace(' ', '\0')) != phone.Id)
                    tempPhones.Add(phone);
                }

                phones.Clear();
                listBox1.Items.Clear();

                foreach (Phone phone in tempPhones)
                {
                    phones.Add(phone);
                }

                foreach (Phone phone in phones)
                {
                    listBox1.Items.Add(phone.Id + " : " + phone.Producer + " : " + phone.Model + " : " + phone.Price);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
