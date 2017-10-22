using FluentNHibernate.Mapping;
using iRpt.Data.Entities;


namespace iRpt.Data.Dal.Mapping {
    
    
    public class FundMap : ClassMap<Fund> {
        
        public FundMap() {
			Table("Fund");
			LazyLoad();
			Id(x => x.Fundid).GeneratedBy.Identity().Column("FundId");
			References(x => x.Client).Column("ClientId");
			Map(x => x.Fundcode).Column("FundCode").Not.Nullable();
			Map(x => x.Fundname).Column("FundName").Not.Nullable();
        }
    }
}
