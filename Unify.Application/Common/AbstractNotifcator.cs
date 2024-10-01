namespace Unify.Application.Common
{
    public abstract class AbstractNotifcator
    {
        public abstract T ValidateAsync<T>(T model);
    }
}
