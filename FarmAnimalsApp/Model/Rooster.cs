using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimalsApp.Model
{
    internal class Rooster : Animal
    {
        public Rooster()
        {
            Name = "Rooster";
            SoundAsText = "Cock-A-Doodle-Doo";
            Photo = "rooster.png";
            soundPlayer = new SoundPlayer();
            string PathToSoundWav = AppDomain.CurrentDomain.BaseDirectory + @"Sounds\Rooster.wav";
            soundPlayer = new SoundPlayer(PathToSoundWav);
        }
    
       
    }
}
