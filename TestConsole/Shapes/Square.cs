namespace TestConsole.Shape
{
    public class Square : Shape
    {
       // public double width{ get; set; }
        public override double Area()
        {
            return width * width;
        }
    }
}