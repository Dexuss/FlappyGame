namespace Game.Inputs
{
    public interface IInputSystemFacade
    {
        bool IsTouchReceived();
        bool IsDoubleTap();
    }
}