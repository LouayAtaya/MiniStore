using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MiniStore.Items
{
    public interface IItemAppService :
        ICrudAppService<
            ItemDto,
            Guid,
            PagedAndSortedResultRequestDto,
            ItemForCreationDto,
            ItemForUpdateDto>
    {
        Task<ItemDto> CreateWithFeatureCheck(ItemForCreationDto itemForCreationDto);


    }
}