namespace CopaClicker.Outputs;

public class Button
{
    public string Text { get; set; }
    public bool Selected { get; set; }
    public ConsoleColor BackgroundColor { get; set; }
    public ConsoleColor ForegroundColor { get; set; }
    public void Draw()
    {
        if (Selected)
        {
            Console.BackgroundColor = this.ForegroundColor;
            Console.ForegroundColor = this.BackgroundColor;
        }
        else
        {
            Console.BackgroundColor = this.BackgroundColor;
            Console.ForegroundColor = this.ForegroundColor;
        }
    }
}