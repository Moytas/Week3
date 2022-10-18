using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3
{
    public partial class Inventory : Form
    {
        List<Animal> animals = new List<Animal>();
        int maxCat = 4;
        int maxDog = 3;
        public Inventory()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                if (comboBox1.Text == "Cat")
                {
                    animals.Add(new Cat(textBox1.Text));
                }
                else
                {
                    animals.Add(new Dog(textBox1.Text));
                }
                listBox1.Items.Clear();
                for(int i = 0; i < animals.Count;i++)
                {
                    listBox1.Items.Add(animals[i].Name);
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string folder = @"C:\Tmp\";
            string fileName = "animals.txt";
            string path = folder + fileName;
            string fileContent = "";
            for(int i = 0; i < animals.Count;i++)
            {
                fileContent += animals[i].Name + "\t";
            }
            File.Create(path);
            File.WriteAllText(path, fileContent);
        }
    }
}
