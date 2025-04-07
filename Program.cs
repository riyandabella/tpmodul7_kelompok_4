using System;
using System.IO;
using System.Text.Json;

class Nama { public string depan { get; set; } 
public string belakang { get; set; } }
 class DataMahasiswa103022300049
{
    public Nama nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("D:\\TP7_KPL\\tpmodul7_kelompok_4\\tp7_1_103022300049.json");
        var data = JsonSerializer.Deserialize<DataMahasiswa103022300049>(jsonString);

        Console.WriteLine($"Nama {data.nama.depan}{data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa103022300049.ReadJSON();
    }
}
