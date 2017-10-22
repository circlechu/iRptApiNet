namespace iRpt.Data.Entities
{

    public class Client {
        public Client() { }
        public virtual long Clientid { get; set; }
        public virtual string Clientcode { get; set; }
        public virtual string Clientname { get; set; }
    }
}
