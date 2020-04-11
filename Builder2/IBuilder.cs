
namespace Builder2
{
    public interface IBuilder
    {
       void BuildMaze();
       void BuildRoom();
       void BuildDoor();
       Maze GetMaze();
    }
}
