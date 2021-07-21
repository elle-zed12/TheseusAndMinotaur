

namespace GazelleLowcay_Final_Portfolio.Interface
{
    public interface ILevelState
    {
        void SetLevelName(string levelName);

        void MoveCount();

        void SetLevel();

        void DrawMaze(Controller controller, int height, int width);

    }
}
