<<<<<<< HEAD
namespace Unity.Services.Core.Telemetry.Internal
{
    interface ICachePersister<TPayload>
        where TPayload : ITelemetryPayload
    {
        bool CanPersist { get; }

        void Persist(CachedPayload<TPayload> cache);

        bool TryFetch(out CachedPayload<TPayload> persistedCache);

        void Delete();
    }
}
=======
namespace Unity.Services.Core.Telemetry.Internal
{
    interface ICachePersister<TPayload>
        where TPayload : ITelemetryPayload
    {
        bool CanPersist { get; }

        void Persist(CachedPayload<TPayload> cache);

        bool TryFetch(out CachedPayload<TPayload> persistedCache);

        void Delete();
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
