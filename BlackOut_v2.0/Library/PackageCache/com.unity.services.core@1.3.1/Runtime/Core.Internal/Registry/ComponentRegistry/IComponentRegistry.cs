<<<<<<< HEAD
using System.Collections.Generic;
using NotNull = JetBrains.Annotations.NotNullAttribute;

namespace Unity.Services.Core.Internal
{
    interface IComponentRegistry
    {
        void RegisterServiceComponent<TComponent>(
            [NotNull] TComponent component)
            where TComponent : IServiceComponent;

        TComponent GetServiceComponent<TComponent>()
            where TComponent : IServiceComponent;

        void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance);
    }
}
=======
using System.Collections.Generic;
using NotNull = JetBrains.Annotations.NotNullAttribute;

namespace Unity.Services.Core.Internal
{
    interface IComponentRegistry
    {
        void RegisterServiceComponent<TComponent>(
            [NotNull] TComponent component)
            where TComponent : IServiceComponent;

        TComponent GetServiceComponent<TComponent>()
            where TComponent : IServiceComponent;

        void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance);
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
