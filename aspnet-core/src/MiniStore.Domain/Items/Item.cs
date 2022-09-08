using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace MiniStore.Items
{
    public class Item : AuditedAggregateRoot<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; set; } 

        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int TotalQuantity { get; set; }


        public ItemType Type { get; set; }

        public DateTime PublishDate { get; set; }

    }
}
