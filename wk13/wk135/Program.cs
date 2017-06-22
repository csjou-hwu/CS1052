using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk135
{
    using System.Speech.Recognition;
    using Microsoft.Kinect;
    using Microsoft.Speech.AudioFormat;
    class Program
    {
        //private static KinectSensor sensor;
        static void Main(string[] args)
        {
            //sensor = KinectSensor.KinectSensors[0];
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
            sre.SetInputToDefaultAudioDevice();
            Choices CH = new Choices();
            CH.Add(new string[] { "sun", "shiao", "zhou", "you" });
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(CH);
            Grammar g = new Grammar(gb);
            sre.LoadGrammar(g);
            sre.SpeechRecognized += sre_SpeechRecognized;
            //sre.SetInputToAudioStream(sensor.AudioSource.Start(), new System.Speech.AudioFormat.SpeechAudioFormatInfo
           
                    //sensor.AudioSource.Start(), new SpeechAudioFormatInfo(EncodingFormat.Pcm, 16000, 16, 1, 32000, 2, null));
            sre.RecognizeAsync(RecognizeMode.Multiple);
            Console.ReadLine();
        }

        static void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "sun") Console.WriteLine("上");
            if (e.Result.Text == "you") Console.WriteLine("右");
        }
    }
}
