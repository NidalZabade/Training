using System.Text.Json;

public class Person
{
    public string? Name { get; set; }
    public Person? Friend { get; set; }
}

public static class DeepCloner
{
    public static T? DeepClone<T>(T obj)
    {
        if (obj == null) return default;
        var json = JsonSerializer.Serialize(obj);
        // Console.WriteLine("Serialized JSON: " + json);
        return JsonSerializer.Deserialize<T>(json)!;
    }

}
