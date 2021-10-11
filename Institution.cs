
namespace readfromexcel_01
{
    class Institution
    {
        
        public string INST_NAVN { get; set; }

        public string INST_ADR { get; set; }
        public string POSTNR { get; set; }
        public string POSTDISTRIKT { get; set; }
        public string TLF_NR { get; set; }

        public override string ToString()
        {
            
            string insName = string.Format("{0,-65}", INST_NAVN);
            string address = string.Format("{0,-30}", INST_ADR);
            string zipcode = string.Format("{0,-4}", POSTNR);
            string postd = string.Format("{0,-15}", POSTDISTRIKT);
            string phonenumber = string.Format("{0,-8}", TLF_NR);

            return insName + " " + address + " " + zipcode +
                " " + postd + " " + phonenumber;
        }



    }
}
