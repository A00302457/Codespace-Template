namespace TestConsole.Shape
{
    public abstract class Shape
    {
       protected double width{ get; set; }
       protected double height{ get; set;}
        public virtual double Area()
        {
            return width * height;
        }
    }
}