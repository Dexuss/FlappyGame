namespace Game.Inputs
{
    public interface IInputSystem
    {
        bool IsTouchReceived();
        bool IsDoubleTap();
    }
}