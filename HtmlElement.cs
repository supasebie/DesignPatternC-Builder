using System.Text;

namespace Builder;

public class HtmlElement
{
    public string? Name, Text;
    public List<HtmlElement> Elements = new List<HtmlElement>();
    private const int indentSize = 2;

    public HtmlElement()
    {
    }

    public HtmlElement(string name, string text)
    {
        Name = name ?? throw new ArgumentException($"'{nameof(name)}' cannot be null or empty.", nameof(name));
        Text = text ?? throw new ArgumentException($"'{nameof(text)}' cannot be null or empty.", nameof(text));
    }

    private string ToStringImp(int indent)
    {
        var sb = new StringBuilder();
        var i = new string(' ', indentSize * indent);

        sb.AppendLine($"{i}<{Name}>");

        if (!string.IsNullOrWhiteSpace(Text))
        {
            sb.Append(new string(' ', indentSize * (indent + 1)));
            sb.AppendLine(Text);
        }

        foreach (var item in Elements)
        {
            sb.Append(item.ToStringImp(indent + 1));
        }

        sb.AppendLine($"{i}</{Name}>");

        return sb.ToString();
    }

    public override string ToString()
    {
        return ToStringImp(0);
    }
}