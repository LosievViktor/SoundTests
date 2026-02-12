using ATL;

namespace WavChecker
{
    public class AudioTests
    {
        private string actualResultAudioFile   = "..\\..\\..\\Audio\\AudioActualResult.wav";
        private string expectedResultAudioFile = "..\\..\\..\\Audio\\AudioExpectedResult.wav";
        private Track theTrack;

        [SetUp]
        public void Setup() 
        {
            theTrack = new Track(actualResultAudioFile);
        }

        [Test]
        public void FormatTest()
        {
            Console.WriteLine("Audio Format : " + theTrack.AudioFormat.Name);
            Assert.That(theTrack.AudioFormat.Name == "PCM (uncompressed audio) (Windows PCM)",
                "Check audio format.");
        }

        [Test]
        public void BitDepthTest()
        {
            Console.WriteLine("BitDepth : " + theTrack.BitDepth);
            Assert.That(theTrack.BitDepth == 32, 
                "Check Bit Depth.");
        }

        [Test]
        public void BitRateTest()
        {
            Console.WriteLine("BitRate : " + theTrack.Bitrate);
            Assert.That(theTrack.Bitrate == 49152,
                "Check Bit rate.");
        }

        [Test]
        public void BPMTest()
        {
            Console.WriteLine("BPM : " + theTrack.BPM);
            Assert.That(theTrack.BPM == 0,
               "Check BPM.");
        }

        [Test]
        public void ChannelsTest()
        {
            Console.WriteLine("Chanels : " + theTrack.ChannelsArrangement);
            Assert.That(theTrack.ChannelsArrangement.ToString() ==
              "Center front - Left front - Right front - Left surround - Right surround - Left rear - Right rear - Center front LFE (3/4.1)",
               "Check channels.");
        }

        [Test]
        public void CodecTest()
        {
            Console.WriteLine("Codec : " + theTrack.CodecFamily);
            Assert.That(theTrack.CodecFamily == 1,
               "Check Codec.");
        }

        [Test]
        public void CopyrightTest()
        {
            Console.WriteLine("Copyright : " + theTrack.Copyright);
            Assert.That(theTrack.Copyright == "",
               "Check Copyright.");
        }

        [Test]
        public void DurationTest()
        {
            Console.WriteLine("Duration : " + theTrack.Duration);
            Assert.That(theTrack.Duration == 6,
               "Check Duration.");
        }

        [Test]
        public void SampleRateTest()
        {
            Console.WriteLine("Sample Rate : " + theTrack.SampleRate);
            Assert.That(theTrack.SampleRate == 192000,
               "Check Sample Rate.");
        }

        [Test]
        public void TechnicalInformationAudioSizeTest()
        {
            Console.WriteLine("Technical Information : " + theTrack.TechnicalInformation.AudioDataSize);
            Assert.That(theTrack.TechnicalInformation.AudioDataSize== 36514880,
               "Check Technical Information Audio Data Size.");
        }

        [Test]
        public void TitleTest()
        {
            Console.WriteLine("Title : " + theTrack.Title);
            Assert.That(theTrack.Title == "AudioActualResult",
               "Check title.");  
        }


        [Test]
        public void Check2AudioFiles()
        {
            string hashActualResult = MD5Manager.GetMD5(actualResultAudioFile);
            string hashExpectedResult = MD5Manager.GetMD5(expectedResultAudioFile);

            Console.WriteLine("MD5 hash of test audio file : "+hashActualResult);
            Console.WriteLine("MD5 hash of reference audio : "+hashExpectedResult);

            Assert.That(hashActualResult == hashExpectedResult,
                "Check that MD5 hash of test audio file is equal of MD5 hash of reference audio file.");
        }
    }
}
