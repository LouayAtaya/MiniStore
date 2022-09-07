using System;
using System.Collections.Generic;
using System.Text;
using MiniStore.Localization;
using Volo.Abp.Application.Services;

namespace MiniStore;

/* Inherit your application services from this class.
 */
public abstract class MiniStoreAppService : ApplicationService
{
    protected MiniStoreAppService()
    {
        LocalizationResource = typeof(MiniStoreResource);
    }
}
