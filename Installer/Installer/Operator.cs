using System;
namespace Installer
{
    public class Operator
    {
        public int Id { get; set; }
        public int MCCMNC { get; set; }
        public int MCC { get; set; }
        public int MNC { get; set; }
        public string Country { get; set; }
        public string Network { get; set; }
    }

    public class TowerDetail
    {
        public int Id { get; set; }
        public int Mcc { get; set; }
        public int Mnc { get; set; }
        public int Tac { get; set; }
        public int Pci { get; set; }
        public float Lat { get; set; }
        public float Lon { get; set; }
        public float Range_meter { get; set; }
        public int Aged { get; set; }
        public float Rsrp_per_meter { get; set; }
    }

}
