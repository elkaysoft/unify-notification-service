namespace Unify.Application.Common
{
    public abstract class AbstractNotifcator<TRequest>
    {
        public abstract TResponse ValidateAsync<TResponse>(TRequest model);
    }
}
