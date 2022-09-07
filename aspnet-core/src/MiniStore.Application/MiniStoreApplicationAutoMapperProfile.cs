using AutoMapper;
using MiniStore.Items;

namespace MiniStore;

public class MiniStoreApplicationAutoMapperProfile : Profile
{
    public MiniStoreApplicationAutoMapperProfile()
    {
        CreateMap<Item, ItemDto>();
        CreateMap<ItemForCreationDto, Item>();
        CreateMap<ItemForUpdateDto, Item>();

        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
