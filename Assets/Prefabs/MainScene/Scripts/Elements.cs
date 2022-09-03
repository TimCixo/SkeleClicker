public interface IElement
{
    public float GetIndex(IElement element);
}

public class CommonElement : IElement
{
    public float GetIndex(IElement element)
    {
        return 1;
    }
}
public class BlazeElement : IElement
{
    public float GetIndex(IElement element)
    {
        if (element is FrostElement)
        {
            return 2;
        }
        else if (element is BlazeElement)
        {
            return 0.5f;
        }
        else
        {
            return 1;
        }
    }
}
public class FrostElement : IElement
{
    public float GetIndex(IElement element)
    {
        if (element is FrostElement)
        {
            return 0.5f;
        }
        else
        {
            return 1;
        }
    }
}