using System.Threading.Tasks;

namespace Cartel.Common.Commands
{
    public interface ICommandHandler<in T> where T: ICommand
    {
         Task HandleAsync(T Command);
    }
}