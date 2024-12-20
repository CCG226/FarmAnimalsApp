using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimalsApp.Model
{
    internal class Pig : Animal
    {
        public Pig()
        {
            Name = "Pig";
            SoundAsText = "Oink Oink";
            Photo = "pig.png";
            string PathToSoundWav = AppDomain.CurrentDomain.BaseDirectory + @"Sounds\Pig.wav";
            soundPlayer = new SoundPlayer(PathToSoundWav);
        }
      
    }
}
