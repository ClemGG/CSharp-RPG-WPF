using System;
using Models;
namespace Actions
{
    public interface IAction
    {
        event EventHandler<string> OnActionPerformed;
        void Execute(LivingEntity actor, LivingEntity target);
    }
}