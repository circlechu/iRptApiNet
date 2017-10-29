using System.ComponentModel.DataAnnotations;

namespace iRpt.Data.Entities
{

    public class Fund
    {
        public virtual long Fundid { get; set; }
        public virtual Client Client { get; set; }
        [Required]
        public virtual string Fundcode { get; set; }
        [Required]
        public virtual string Fundname { get; set; }

    }
}
