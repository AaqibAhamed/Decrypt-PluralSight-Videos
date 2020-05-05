namespace DecryptPluralSightVideos.Option
{
    public class DecryptorOptions
    {
        public bool UseDatabase { get; set; }
        public bool UseOutputFolder { get; set; }
        public bool RemoveFolderAfterDecryption { get; set; }
        public bool UsageCommand { get; set; }
        public bool CreateTranscript { get; set; }

        public string InputPath { get; set; }
        public string DatabasePath { get; set; }
        public string OutputPath { get; set; }

    }
}
