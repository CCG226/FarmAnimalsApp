using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimalsApp.Model
{
    internal class Horse : Animal
    {
        public Horse()
        {
            Name = "Horse";
            SoundAsText = "Neeighhh";
            Photo = "horse.png";
            string PathToSoundWav = AppDomain.CurrentDomain.BaseDirectory + @"Sounds\Horse.wav";
            soundPlayer = new SoundPlayer(PathToSoundWav);
        }

    }
}
