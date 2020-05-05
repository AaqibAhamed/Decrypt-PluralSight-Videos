using System;
using System.IO;

namespace DecryptPluralSightVideos.Option
{
    public class Utils
    {
        private static ConsoleColor color_default;
        private static object console_lock = new object();

        static Utils()
        {
            color_default = Console.ForegroundColor;
        }

        public static void WriteToConsole(string Text, ConsoleColor color = ConsoleColor.Gray)
        {
            lock (console_lock)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(Text);
                Console.ForegroundColor = color_default;
            }
        }

        public static void HelpCommand()
        {
            WriteToConsole("This tool is published by Loc Nguyen and shared on J2Team");
            WriteToConsole(@"Source code of this tool published on: https://github.com/vinhloc1996/DecryptPluralSightVideos");

            WriteToConsole(Environment.NewLine + Environment.NewLine + "Flags: ");
            WriteToConsole("\t/F [PATH] Source path contains all downloaded courses. (Mandatory)");
            WriteToConsole("\t/RM\tRemoves courses in databases after decryption is complete. (Optional)");
            WriteToConsole("\t/DB [PATH] Use Database to rename folder course, module... (Mandatory)");
            WriteToConsole("\t/OUT [PATH] Specifies an output directory instead of using the same source path. (Optional)");
            WriteToConsole("\t/TRANS\tGenerate subtitles file (.srt) if the course are supported. (Optional)");
            WriteToConsole("\t/HELP\tSee usage of other commands. (Optional)");
            WriteToConsole("**Note**\nIf you want to use /RM flag, please make sure the output path that not the same with the source path.\n", ConsoleColor.Yellow);
        }

        public static DecryptorOptions ParseCommandLineArgs(string[] args)
        {
            DecryptorOptions options = new DecryptorOptions();
            int index = 0;
            int length = args.Length;

            foreach (string arg in args)
            {
                if (string.IsNullOrWhiteSpace(arg))
                {
                    index++;
                    continue;
                }

                switch (arg.ToUpper())
                {
                    case "/F": // All Folders Mode
                        if (length - 1 > index)
                        {
                            options.InputPath = args[index + 1];
                            WriteToConsole("Start to decrypt all courses...", ConsoleColor.Yellow);
                        }
                        else
                        {
                            WriteToConsole("The directory path is missing..." + Environment.NewLine,
                                ConsoleColor.Red);
                            throw new FileNotFoundException(
                                "Directory path is missing or specified directory was not found!");
                        }
                        break;

                    case "/DB": // Use Database
                        options.UseDatabase = true;

                        if (length - 1 > index)
                            options.DatabasePath = args[index + 1];
                        break;

                    case "/RM": // Remove encrypted folder(s) after decryption
                        options.RemoveFolderAfterDecryption = true;
                        break;

                    case "/OUT": // Output Folder Path
                        options.UseOutputFolder = true;

                        if (args.Length - 1 > index)
                            options.OutputPath = args[index + 1];
                        break;

                    case "/TRANS": // Create Transcript If course supportted
                        options.CreateTranscript = true;
                        break;

                    case "/HELP": // Open command explaination
                        options.UsageCommand = true;
                        break;
                }

                index++;
            }

            return options;
        }
    }
}