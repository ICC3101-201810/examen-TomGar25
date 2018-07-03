using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Player
    {
        int puntos;
        string nombre;
        public Player(string n, int p)
        {
            nombre = n;
            puntos = p;
        }
        public string getName()
        {
            return this.nombre;
        }
        public int getScore()
        {
            return this.puntos;
        }
    }
}
