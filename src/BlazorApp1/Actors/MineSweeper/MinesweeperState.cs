namespace BlazorApp1.Actors.MineSweeper;

public record MinesweeperState(int Width, int Height, IEnumerable<Cell> Cells)
{

}

public record Cell()
