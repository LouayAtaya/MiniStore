using MiniStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MiniStore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MiniStoreController : AbpControllerBase
{
    protected MiniStoreController()
    {
        LocalizationResource = typeof(MiniStoreResource);
    }
}
