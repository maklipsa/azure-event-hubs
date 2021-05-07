using CommandLine;

namespace WindTurbineDataGenerator
{
    public class CommandLineOptions
    {
        [Option(shortName: 'n', longName: "name", Required = true, HelpText = "Event Hub Name.")]
        public string Name { get; set; }

        [Option(shortName: 'c', longName: "connection", Required = true, HelpText = "Connection string to Event Hub")]
        public string Connection { get; set; }
    }
}