namespace Mazes
{
    public static class DiagonalMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {

            if (width > height)
            {
                MoveRight(robot, width / height + 1);
                for (int i = 0; i < height - 3; i++)
                {
                    MoveDown(robot, 1);
                    MoveRight(robot, width / height + 1);

                }

            } else
            {
                MoveDown(robot, (height + 1) / width);
                for (int i = 0; i < width - 3; i++)
                {
                    MoveRight(robot, 1);
                    MoveDown(robot, (height + 1) / width);

                }
            }

        }
            public static void Circle(Robot robot, int width, int height)
            {
                MoveDown(robot, 2);
                MoveRight(robot, width - 3);
                MoveDown(robot, 2);
                MoveLeft(robot, width - 3);
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