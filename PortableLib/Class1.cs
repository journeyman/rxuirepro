using ReactiveUI;

namespace PortableLib
{
    public interface IPortableReactiveObject : IReactiveObject { }
    public class PortableReactiveObject : ReactiveObject, IPortableReactiveObject
    {
    }
}