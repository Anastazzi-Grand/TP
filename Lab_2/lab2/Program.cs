using System.IO;
using System.Text.Json;

public class Pizza
{
    public byte Id { get; set; }

    public string Title { get; set; }

    public decimal Price { get; set; }

    public string Unit_of_measurement { get; set; }

    public Pizza() { }

    public Pizza(byte Id, string Title, decimal Price, string Unit_of_measurement)
    {
        this.Id = Id;
        this.Title = Title;
        this.Price = Price;
        this.Unit_of_measurement = Unit_of_measurement;
    }
}

public class LineNumber
{
    public byte Order_line_number { get; set; }

    public byte Order_number { get; set; }

    public byte Count { get; set; }

    public Pizza pizza { get; set; }

    public LineNumber() { }

    public LineNumber(byte Order_line_number, byte Order_number, byte Count, Pizza pizza)
    {
        this.Order_line_number = Order_line_number;
        this.Order_number = Order_number;
        this.Count = Count;
        this.pizza = pizza;
    }
}



public class JsonHandler<T> where T : class
{
    private string fileName;
    JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };


    public JsonHandler() { }

    public JsonHandler(string fileName)
    {
        this.fileName = fileName;
    }


    public void SetFileName(string fileName)
    {
        this.fileName = fileName;
    }

    public void Write(List<T> list)
    {
        string jsonString = JsonSerializer.Serialize(list, options);

        if (new FileInfo(fileName).Length == 0)
        {
            File.WriteAllText(fileName, jsonString);
        }
        else
        {
            Console.WriteLine("Specified path file is not empty");
        }
    }

    public void Delete()
    {
        File.WriteAllText(fileName, string.Empty);
    }

    public void Rewrite(List<T> list)
    {
        string jsonString = JsonSerializer.Serialize(list, options);

        File.WriteAllText(fileName, jsonString);
    }

    public void Read(ref List<T> list)
    {
        if (File.Exists(fileName))
        {
            if (new FileInfo(fileName).Length != 0)
            {
                string jsonString = File.ReadAllText(fileName);
                list = JsonSerializer.Deserialize<List<T>>(jsonString);
            }
            else
            {
                Console.WriteLine("Specified path file is empty");
            }
        }
    }

    public void OutputJsonContents()
    {
        string jsonString = File.ReadAllText(fileName);

        Console.WriteLine(jsonString);
    }

    public void OutputSerializedList(List<T> list)
    {
        Console.WriteLine(JsonSerializer.Serialize(list, options));
    }
}



class Program
{
    static void Main(string[] args)
    {
        List<LineNumber> ordersList = new List<LineNumber>();

        JsonHandler<LineNumber> ordersHandler = new JsonHandler<LineNumber>("ordersFile.json");

        ordersList.Add(new LineNumber(2, 5, 1, new Pizza(10, "one", 100, "nice")));
        ordersList.Add(new LineNumber(3, 4, 2, new Pizza(20, "two", 200, "good")));
        ordersList.Add(new LineNumber(4, 3, 3, new Pizza(30, "three", 300, "perfect")));
        ordersList.Add(new LineNumber(5, 2, 4, new Pizza(40, "four", 400, "bad")));
        ordersHandler.Rewrite(ordersList);
        ordersHandler.OutputJsonContents();
    }
}

/*
 * [
  {
    "Order_line_number": 2,
    "Order_number": 5,
    "Count": 1,
    "pizza": {
      "Id": 10,
      "Title": "one",
      "Price": 100,
      "Unit_of_measurement": "nice"
    }
  },
  {
    "Order_line_number": 3,
    "Order_number": 4,
    "Count": 2,
    "pizza": {
      "Id": 20,
      "Title": "two",
      "Price": 200,
      "Unit_of_measurement": "good"
    }
  },
  {
    "Order_line_number": 4,
    "Order_number": 3,
    "Count": 3,
    "pizza": {
      "Id": 30,
      "Title": "three",
      "Price": 300,
      "Unit_of_measurement": "perfect"
    }
  },
  {
    "Order_line_number": 5,
    "Order_number": 2,
    "Count": 4,
    "pizza": {
      "Id": 40,
      "Title": "four",
      "Price": 400,
      "Unit_of_measurement": "bad"
    }
  }
]
*/