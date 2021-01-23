namespace Mazes
{
    public static class EmptyMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            MoveDown(robot, height - 3);
            MoveRight(robot, width - 3);
        }
        public static void MoveUp(Robot robot, int step)
        {
            for (int i = 0; i < step; i++)
                robot.MoveTo(Direction.Up);
        }
        public static void MoveRight(Robot robot, int step)
        {
            for (int i = 0; i < step; i++)
                robot.MoveTo(Direction.Right);
        }
        public static void MoveLeft(Robot robot, int step)
        {
            for (int i = 0; i < step; i++)
                robot.MoveTo(Direction.Left);
        }
        public static void MoveDown(Robot robot, int step)
        {
            for (int i = 0; i < step; i++)
                robot.MoveTo(Direction.Down);
        }
    }
}