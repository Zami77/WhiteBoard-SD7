using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayers
{
    public interface IStreamingDevice
    {
        public string DeviceName { get; set; }
        public bool IsPlaying { get; set; }
        bool Play();
        void Pause();
        void Ffwd();
        void Rewind();
        bool Stop();
    }
    
    public class DVDPlayer : IStreamingDevice
    {
        
        public string DeviceName { get; set; }
        public bool IsPlaying { get; set; }

        public void Ffwd()
        {
            Console.WriteLine($"FFwd {DeviceName}");
        }
        public DVDPlayer()
        {
            DeviceName = "Generic DVD Player";
            IsPlaying = false;
        }
        public void Pause()
        {
            if (IsPlaying)
            {
                Console.WriteLine($"{DeviceName} paused");
                IsPlaying = false;
                return;
            }
            Console.WriteLine($"{DeviceName} is not playing");
        }

        public bool Play()
        {
            if (IsPlaying) 
            { 
                Console.WriteLine($"{DeviceName} is already playing");
                return IsPlaying;
            }
            Console.WriteLine($"{DeviceName} is now playing");
            IsPlaying = true;
            return IsPlaying;
        }

        public void Rewind()
        {
            Console.WriteLine($"Rewind {DeviceName}");
        }
        public bool Stop()
        {
            if(!IsPlaying)
            {
                Console.WriteLine($"{DeviceName} is already stopped");
                return IsPlaying;
            }
            Console.WriteLine($"Stop {DeviceName}");
            IsPlaying = false;
            return IsPlaying;

        }
    }
}
