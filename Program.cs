using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
class Nama
{
    public string depan { get; set; }
    public string belakang { get; set; }
}

class DataMahasiswa103022300001
{
    public Nama nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }
    public static void ReadJSON()
    {
        String jsonString = File.ReadAllText("C:\\Users\\riyan\\source\\repos\\tpmodul7_kelompok_4\\tp7_1_103022300001.json");

        var mahasiswa = JsonSerializer.Deserialize<DataMahasiswa103022300001>(jsonString);

        Console.WriteLine($"Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan nim {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
    }
}

class Courses
{
    public string code { get; set; }
    public string name { get; set; }
}

class KuliahMahasiswa103022300001
{

    public List<Courses> courses { get; set; }
    public static void ReadJSON()
    {
        String jsonString = File.ReadAllText("C:\\Users\\riyan\\source\\repos\\tpmodul7_kelompok_4\\tp7_2_103022300001.json");

        var matkul = JsonSerializer.Deserialize<KuliahMahasiswa103022300001>(jsonString);

        Console.WriteLine("Daftar mata kuliah yang diambil:");

        int i = 1;
        foreach (var courses in matkul.courses)
        {
            Console.WriteLine($"MK {i} {courses.code} - {courses.name}");
            i++;
        }
    }
}

class Program
{
    static void Main()
    {
        DataMahasiswa103022300001.ReadJSON();
        KuliahMahasiswa103022300001.ReadJSON();
    }
}