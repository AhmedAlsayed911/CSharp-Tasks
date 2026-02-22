namespace Singleton
{
    internal class NIC
    {
        public string Manufacture { get; }
        public string MacAddress { get; }
        public string Type { get; }

        private static NIC instance;

        private NIC(string manufacture, string macAddress, string type)
        {
            Manufacture = manufacture;
            MacAddress = macAddress;
            Type = type;
        }

        public static NIC GetInstance(string manufacture, string macAddress, string type)
        {
            if (instance is null)
                instance = new NIC(manufacture, macAddress, type);

            return instance;
        }

    }
}
