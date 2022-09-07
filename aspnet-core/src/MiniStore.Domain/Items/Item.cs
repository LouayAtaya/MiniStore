using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace MiniStore.Items
{
    public class Item : AuditedAggregateRoot<Guid>
    {
    }
}
