using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MiniStore.Items
{
    public class ItemAppService : CrudAppService<
            Item,
            ItemDto,
            Guid,
            PagedAndSortedResultRequestDto,
            ItemForCreationDto,
            ItemForUpdateDto>,
         IItemAppService 

    {
        public ItemAppService(IRepository<Item, Guid> repository)
            : base(repository)
        {

        }

    }
}
