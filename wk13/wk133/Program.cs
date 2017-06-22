using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk133
{
    // Fail @ i302
    using Microsoft.Speech.Synthesis;
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer SP = new SpeechSynthesizer();
            
            SP.SpeakAsync("This is a test.");
            Console.ReadLine();
        }
    }
}
