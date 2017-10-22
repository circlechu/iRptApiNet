namespace iRpt.Data.Entities
{

    public class Fund {
        public virtual long Fundid { get; set; }
        public virtual Client Client { get; set; }
        public virtual string Fundcode { get; set; }
        public virtual string Fundname { get; set; }
    }
}
