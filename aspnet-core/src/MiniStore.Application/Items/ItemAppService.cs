using Microsoft.AspNetCore.Authorization;
using MiniStore.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Features;

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
        private readonly IRepository<Item, Guid> _itemRepository;
        private readonly IFeatureChecker _featureChecker;


        public ItemAppService(IRepository<Item, Guid> repository, IFeatureChecker featureChecker)
            : base(repository)
        {
            GetPolicyName = MiniStorePermissions.Items.Default;
            GetListPolicyName = MiniStorePermissions.Items.Default;
            CreatePolicyName = MiniStorePermissions.Items.Create;
            UpdatePolicyName = MiniStorePermissions.Items.Edit;
            DeletePolicyName = MiniStorePermissions.Items.Delete;

            _itemRepository = repository;
            _featureChecker = featureChecker;

        }

        [Authorize(MiniStorePermissions.Items.Create)]
        public async Task<ItemDto> CreateWithFeatureCheck(ItemForCreationDto itemForCreationDto)
        {
            var currentItemsCount = await this._itemRepository.CountAsync();

             var maxItemsCountLimit = await _featureChecker.GetOrNullAsync("MiniStore.MaxItemsCount");

            if (currentItemsCount >= Convert.ToInt32(maxItemsCountLimit))
            {
                throw new BusinessException(
                    "MiniStore:ReachToMaxItemCountLimit",
                    $"You can not create more than {maxItemsCountLimit} items!"
                );
            }

            var item= ObjectMapper.Map<ItemForCreationDto, Item>(itemForCreationDto);

            await _itemRepository.InsertAsync(item);

            return ObjectMapper.Map<Item, ItemDto>(item);

        }




    }
}
