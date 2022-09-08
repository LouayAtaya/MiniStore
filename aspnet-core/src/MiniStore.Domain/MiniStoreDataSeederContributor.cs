using MiniStore.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace MiniStore
{
    internal class MiniStoreDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Item, Guid> _itemRepository;
        public MiniStoreDataSeederContributor(IRepository<Item, Guid> itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            /*if (await _itemRepository.GetCountAsync() <= 0)
            {
                await _itemRepository.InsertAsync(
                    new Item
                    {
                        Code= "T000",
                        Name = "My Item 1",
                        Type = ItemType.ProductItem,
                        PublishDate = DateTime.Now,
                        Price = 1000f,
                        TotalQuantity=250,
                    },
                    autoSave: true
                );

                await _itemRepository.InsertAsync(
                    new Item
                    {
                        Code = "T001",
                        Name = "My Item 2",
                        Description="My Item Description",
                        Type = ItemType.ProductItem,
                        PublishDate = DateTime.Now,
                        Price = 2000f,
                        TotalQuantity = 50,
                    },
                    autoSave: true
                );
            }*/
        }
    }
}