using System.Drawing;

namespace WindowsFormsBoats
{
    public interface IBoat
    {
        void SetPosition(int x, int y, int width, int height);
        void MoveTransport(Direction direction);
        void DrawBoat(Graphics g);
        void SetMainColor(Color color);
    }
}
