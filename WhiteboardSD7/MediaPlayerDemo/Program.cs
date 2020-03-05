using System;
using MediaPlayers;

namespace MediaPlayerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Media Player Interface Demo");

            DVDPlayer mediaPlayer1 = new DVDPlayer();
            Console.WriteLine($"{mediaPlayer1.DeviceName}");
            mediaPlayer1.DeviceName = "DVD Player";
            Console.WriteLine($"{mediaPlayer1.DeviceName}");
            string input;
            Console.WriteLine(">.Press Play\nP.Press Pause\nF.Press FFwd\nR.Press Rewind\nS.Press Stop\n0.To Exit");
            while (true)
            {
                input = Console.ReadLine();
                switch(input)
                {
                    case ">":
                        mediaPlayer1.Play();
                        break;
                    case "P":
                        mediaPlayer1.Pause();
                        break;
                    case "F":
                        mediaPlayer1.Ffwd();
                        break;
                    case "R":
                        mediaPlayer1.Rewind();
                        break;
                    case "S":
                        mediaPlayer1.Stop();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Incorrect Input, try again...");
                        break;
                }
            }



        }
    }
}
