﻿namespace Builder;

public class HtmlBuilder
{
    private readonly string rootName;
    HtmlElement root = new HtmlElement();

    public HtmlBuilder(string rootName)
    {
        root.Name = rootName;
        this.rootName = rootName;
    }

    public HtmlBuilder AddChild(string childName, string childText)
    {
        var childElement = new HtmlElement(childName, childText);
        root.Elements.Add(childElement);

        return this;
    }

    public override string ToString()
    {
        return root.ToString();
    }

    public void ClearString()
    {
        root = new HtmlElement{Name = rootName};
    }
}
