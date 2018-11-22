using System;

namespace Cartel.Common.Commands
{
    public interface IAuthenticatedCommand:ICommand
    {
        Guid UserID {get; set;}         
    }
}