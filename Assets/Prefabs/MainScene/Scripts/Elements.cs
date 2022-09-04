using System;

public enum ElementTypes : byte
{ 
    Common = 0,
    Blaze = 1,
    Frost = 2
}

public class ElementController
{
    public static IElement GetElement(ElementTypes elementType)
    {
        IElement element;

        switch (elementType)
        {
            case ElementTypes.Common: 
                element = new CommonElement(); 
                break;
            case ElementTypes.Blaze: 
                element = new BlazeElement(); 
                break;
            case ElementTypes.Frost: 
                element = new FrostElement(); 
                break;
            default:
                throw new ArgumentException("The specified element does not exist.");
        }

        return element;
    }
}

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