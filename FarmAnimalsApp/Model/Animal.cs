using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimalsApp.Model
{
    internal abstract class Animal
    {

        public string? Name { get; set; }

        public string? SoundAsText { get; set; }

        public string? Photo { get; set; }

        protected SoundPlayer? soundPlayer;

        public void MakeSound()
        {
            if (soundPlayer != null)
            {

                soundPlayer.Play();
            }
            else
            {
                throw new Exception("Error: Sounder Player Not Found.");
            }
        }

    }
}
