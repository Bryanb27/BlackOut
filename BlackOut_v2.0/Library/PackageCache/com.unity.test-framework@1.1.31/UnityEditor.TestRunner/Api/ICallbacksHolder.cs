<<<<<<< HEAD
namespace UnityEditor.TestTools.TestRunner.Api
{
    internal interface ICallbacksHolder
    {
        void Add(ICallbacks callback, int priority);
        void Remove(ICallbacks callback);
        ICallbacks[] GetAll();
        void Clear();
    }
=======
namespace UnityEditor.TestTools.TestRunner.Api
{
    internal interface ICallbacksHolder
    {
        void Add(ICallbacks callback, int priority);
        void Remove(ICallbacks callback);
        ICallbacks[] GetAll();
        void Clear();
    }
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
}