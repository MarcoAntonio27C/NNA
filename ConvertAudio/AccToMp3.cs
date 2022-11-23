using System;
using System.Collections.Generic;
using System.Text;
using NAudio.Wave;
using System.Media;

namespace ConvertAudio
{
    public class AccToMp3
    {
        public string Convert()
        {
            using (var reader = new MediaFoundationReader("myfile.aac"))
            {
                WaveFileWriter.CreateWaveFile("pcm.wav", reader);
            }

            return "sdsd";
        }
    }
}
