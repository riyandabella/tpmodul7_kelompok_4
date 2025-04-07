using System;
using System.IO;
using System.Text.Json;

public class Nama
{
    public string depan { get; set; }
    public string belakang { get; set; }
}

public class DataMahasiswa_103022300099
{
    public Nama nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }

    public void ReadJSON()
    {
        try
        {
            string jsonData = File.ReadAllText("D:\\Tp_103022300099\\tpmodul7_kelompok_4\\tp7_1_103022300099.json");
            DataMahasiswa_103022300099 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_103022300099>(jsonData);

            Console.WriteLine($"Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan nim {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan saat membaca file JSON: {ex.Message}");
        }
    }
}

class Program
{
    static void Main()
    {
        var data = new DataMahasiswa_103022300099();
        data.ReadJSON();
    }
}
