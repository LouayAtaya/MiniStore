using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MiniStore.Items
{
    public class ItemDto : AuditedEntityDto<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int TotalQuantity { get; set; }

        public ItemType Type { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
