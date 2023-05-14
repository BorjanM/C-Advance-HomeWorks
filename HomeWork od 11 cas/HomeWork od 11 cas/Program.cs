
using HomeWork_od_11_cas.Entities;
using Newtonsoft.Json;

string folderPath = "../../../DogFolder";
string filePath = folderPath + "/dog.txt";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
}

void WriteToJson(string json)
{
    using (StreamWriter sw = new StreamWriter(filePath))
    {
        sw.WriteLine(json);
    }
}

void ReadFromJson()
{
    using (StreamReader sr = new StreamReader(filePath))
    {
        Console.WriteLine(sr.ReadToEnd());
    }
}




Console.Write("Vnesete ime na vaseto kuce: ");
string name = Console.ReadLine();

Console.Write("Vnesete godini na vaseto kuce: ");
int age = int.Parse(Console.ReadLine());

Console.Write("Vnesete bojata na vaseto kuce: ");
string color = Console.ReadLine();

Dog dog = new Dog()
{
    Name = name,
    Age = age,
    Color = color,
};

Dog[] kuceto = new Dog[] { dog };
kuceto[0] = dog;

string dogString = JsonConvert.SerializeObject(kuceto);
WriteToJson(dogString);

ReadFromJson();