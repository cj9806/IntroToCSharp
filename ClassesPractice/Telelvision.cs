using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysPractice
{
    class Telelvision
    {
        private int currentChannel = 3;
        private int currentVolume= 15;
        // increases the volume by one
        public void increaseVolume()
        {
            currentVolume += 1;
        }
        // decreases the volume by one
        public void decreaseVolume() 
        {
            currentVolume -= 1;
        }   
        // // returns the current volume
        public void volume()
        {
            Console.WriteLine(currentVolume);
        } 
        // increases the channel num by one
        public void increaseChannel()
        {
            currentChannel += 1;
        }
        // decreases the channel num by one
        public void decreaseChannel()
        {
            currentChannel -= 1;
        } 
        // returns the current channel 
        public void channel()
        {
            Console.WriteLine(currentChannel); 
        }
    }
}
