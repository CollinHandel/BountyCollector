
using System.Media;

namespace SpaceGameClassLibrary
{
    public class Music//Francisco: Below is the code that allows the music to be played in background.
    {
       public static void Menu() 
        {
            SoundPlayer player = new SoundPlayer("SpaceMenu.wav");
            player.Play();
        }
    }
}
