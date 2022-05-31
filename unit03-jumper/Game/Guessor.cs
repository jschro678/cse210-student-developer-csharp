using System;
using System.Collections.Generic;

namespace unit03_jumper-Game
{
    /// <summary>
    /// <para>The person guessing the word.</para>
    /// <para>
    /// The responsibility of a guessor is to guess a letter.
    /// </para>
    /// </summary>
    public class Guessor
    {
        private Char letter;
        private TerminalService terminalService = new TerminalService();
        
        private List<string> jumper = new List<string>();
        /// <summary>
        /// Constructs a new instance of Jumper.
        /// </summary>
        public Guessor()
        {
jumper
        }
        public void guess()
        {
        letter =TerminalService.WriteText("\nEnter a letter: ");
        }
        public void display_jumper()
        {

        }


    }
}