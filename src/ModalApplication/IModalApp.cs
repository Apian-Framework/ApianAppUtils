using System;

namespace ModalApplication
{
    public interface IModalApp
    {
        void Start(int initialMode);
        void End();

    }

    public interface IFsmApp : IModalApp
    {
        bool IsRunning { get; }
    }

    public interface ILoopingApp : IModalApp
    {
        bool Loop(float frameSecs); // returns true if still running
    }


}