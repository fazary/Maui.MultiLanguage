namespace MultiLanguage.Resources;
public class Language(string name, string code)
{
    public string Name { get; private set; } = name;
    public string Code { get; private set; } = code;
}
