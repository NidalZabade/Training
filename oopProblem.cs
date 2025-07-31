using System.Text.Json;

[Serializable]
public class Person
{
    public string Name { get; set; }
    public Person Friend { get; set; }
}

public static class DeepCloner
{
    public static T? DeepClone<T>(T obj)
    {
        if (obj == null) return default;
        var json = JsonSerializer.Serialize(obj);
        return JsonSerializer.Deserialize<T>(json)!;
    }

}
