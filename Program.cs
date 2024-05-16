using System.Text;
using Builder;

var sb = new StringBuilder();

sb.Append("<p>");
sb.Append("Hello");
sb.Append("</p>");

Console.WriteLine(sb);

var words = new[] { "Hello", "world" };
sb.Clear();

sb.Append("<ul>");
foreach (var word in words)
{
    sb.AppendFormat("<li>{0}</li>", word);
}
sb.Append("</ul>");

Console.WriteLine(sb);

var builder = new HtmlBuilder("ul");


builder.AddChild("li", "hello").AddChild("li", "world");

Console.WriteLine(builder.ToString());