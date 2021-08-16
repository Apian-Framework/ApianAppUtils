namespace ModalApplication
{
    public interface IModalApp
    {
        void Start(int initialMode);
        void End();

        bool IsRunning { get; }
    }

    public interface ILoopingApp : IModalApp
    {
        bool Loop(float frameSecs); // returns true is still running
    }


}