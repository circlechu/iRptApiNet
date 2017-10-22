using FluentNHibernate.Mapping;
using iRpt.Data.Entities;

namespace iRpt.Data.Dal.Mapping
{


    public class ClientMap : ClassMap<Client> {
        
        public ClientMap() {
			Table("Client");
			LazyLoad();
			Id(x => x.Clientid).GeneratedBy.Identity().Column("ClientId");
			Map(x => x.Clientcode).Column("ClientCode").Not.Nullable();
			Map(x => x.Clientname).Column("ClientName").Not.Nullable();
        }
    }
}
