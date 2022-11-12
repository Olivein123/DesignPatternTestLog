using UserInterface;

internal class Program
{
    private static void Main(string[] args)
    {
        IRenderer r = new Renderer();
        Console.Write("Input theme (dark/light): ");
        var theme = Console.ReadLine();

        r.RenderUserInterface(theme);
    }
}

