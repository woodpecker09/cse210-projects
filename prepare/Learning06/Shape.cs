//SetColor(string color) is not usefull. The atribute color change when a instance of the sub class is call.
//Example: new Circle(3,"black")
public abstract class Shape
{
    private string _color;
    
    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public abstract double GetArea();
    
}