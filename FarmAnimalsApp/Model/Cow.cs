using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimalsApp.Model
{
    internal class Cow : Animal
    {
        public Cow() 
        {
            Name = "Cow";
            SoundAsText = "Moo Moo";
            Photo = "cow.png";
            string PathToSoundWav = AppDomain.CurrentDomain.BaseDirectory + @"Sounds\Cow.wav";
            soundPlayer = new SoundPlayer(PathToSoundWav);
        }
     
    }
}
