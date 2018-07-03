using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void EstBoton_Click(object sender, EventArgs e)
        {
            List<Player> jugadores = Metodos.desPlayers();
            string m= "Top\n";
            foreach (Player item in jugadores)
            {
                m += item.getName() + "Score" + item.getScore().ToString() + "\n";
            }
            MessageBox.Show(m);
            Metodos.serializarPlayers(jugadores);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 j = new Form2();
            
            string nb = NombreBox.Text;

            
            j.Show();
            j.name = nb;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
