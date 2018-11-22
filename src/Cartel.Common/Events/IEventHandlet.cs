using System.Threading.Tasks;

namespace Cartel.Common.Events
{
    public interface IEventHandlet<in T> where T: IEvent
    {
         Task HandleAsync(T @event);
    }
}