using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;


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
            string jsonData = File.ReadAllText("D:\\Tp7_103022300099\\tpmodul7_kelompok_4\\tp7_1_103022300099.json");
            DataMahasiswa_103022300099 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_103022300099>(jsonData);

            Console.WriteLine($"Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan nim {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan saat membaca file JSON: {ex.Message}");
        }
    }
}






public class Courses
{
    public string code { get; set; }
    public string name { get; set; }
}


public class KuliahMahasiswa103022300099
{
    public List<Courses> courses{ get; set; }

    public void ReadJSON()
    {
        string jsonString = File.ReadAllText("D:\\Tp7_103022300099\\tpmodul7_kelompok_4\\tp7_2_103022300099.json");
        var matkul = JsonSerializer.Deserialize<KuliahMahasiswa103022300099>(jsonString);

        Console.WriteLine("Daftar mata kuliah yang diambil:");
        int i = 1;
        foreach (var mk in matkul.courses)
        {
            Console.WriteLine($"MK {i} <{mk.code}> - <{mk.name}>");
            i++;
        }
    }
}


class Program
{
    static void Main()
    {
        var data = new DataMahasiswa_103022300099();
        data.ReadJSON();

        var kuliah = new KuliahMahasiswa103022300099();
        kuliah.ReadJSON();

    }
}
