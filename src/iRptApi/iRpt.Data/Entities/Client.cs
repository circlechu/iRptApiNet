using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iRpt.Data.Entities
{

    public class Client
    {
        public Client()
        {
            Fund = new List<Fund>();
        }
        public virtual long Clientid { get; set; }
        [Required]
        public virtual string Clientcode { get; set; }
        [Required]
        public virtual string Clientname { get; set; }
        public virtual IList<Fund> Fund { get; set; }
    }
}
