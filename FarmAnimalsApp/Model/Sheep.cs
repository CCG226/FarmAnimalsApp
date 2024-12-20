using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimalsApp.Model
{
    internal class Sheep : Animal
    {
        public Sheep()
        {
            Name = "Sheep";
            SoundAsText = "Baaaaahhh";
            Photo = "sheep.png";
            string PathToSoundWav = AppDomain.CurrentDomain.BaseDirectory + @"Sounds\Sheep.wav";
            soundPlayer = new SoundPlayer(PathToSoundWav);
        }
     
    }
}
