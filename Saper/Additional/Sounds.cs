using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Saper
{
    static class Sounds
    {
        public static SoundPlayer startGame = new SoundPlayer(@".\Sounds\startGame.wav");
        public static SoundPlayer gameOver = new SoundPlayer(@".\Sounds\gameOver.wav");
        public static void PlayStartGame()
        {
            startGame.Play();
        }
        public static void PlayGameOver()
        {
            gameOver.Play();
        }
    }
}
