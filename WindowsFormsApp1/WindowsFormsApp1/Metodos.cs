using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Metodos
    {
        public static void serializarPlayers(List<Player> best)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\data.bin");
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, best);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message); 
            }
        }
        public static List<Player> desPlayers()
        {
            List<Player> best;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\data.bin");
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    best = (List<Player>)bin.Deserialize(stream);
                }
                return best;
            }
            catch (Exception e)
            {
                
                return null;
            }
            
        }

    }

}
