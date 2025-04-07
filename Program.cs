public class Nama

using System;
using System.IO;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;

using tpmodul7_kelompok_4;

class Nama
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

class DataMahasiswa103022300049
{

    public Nama nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }
  
    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("D:\\TP7_KPL\\tpmodul7_kelompok_4\\tp7_1_103022300049.json");
        var data = JsonSerializer.Deserialize<DataMahasiswa103022300049>(jsonString);

        Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
    }
}

class DataMahasiswa103022300160
{
        public Nama nama { get; set; }
        public long nim { get; set; }
        public String fakultas { get; set; }

        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\Praktikum Konstruksi PL\\TpMod7_kelompok\\tpmodul7_kelompok_4\\tp7_1_103022300160.json");
            DataMahasiswa103022300160 data = JsonSerializer.Deserialize<DataMahasiswa103022300160>(jsonString);

            Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas} ");
        }
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

public class KuliahMahasiswa103022300099
{
    public List<Courses> courses{ get; set; }

    public void ReadJSON()
    {
        string jsonString = File.ReadAllText("D:\\Tp7_103022300099\\tpmodul7_kelompok_4\\tp7_2_103022300099.json");
        var matkul = JsonSerializer.Deserialize<KuliahMahasiswa103022300099>(jsonString);
    }
}
  
class KuliahMahasiswa103022300049
{
    public List<Courses> courses { get; set; }

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("D:\\TP7_KPL\\tpmodul7_kelompok_4\\tp7_2_103022300049.json");
        var matkul = JsonSerializer.Deserialize<KuliahMahasiswa103022300049>(jsonString);

        Console.WriteLine("Daftar mata kuliah yang diambil:");
        int i = 1;
        foreach (var mk in matkul.courses)
        {
            Console.WriteLine($"MK {i} <{mk.code}> - <{mk.name}>");
        }
            Console.WriteLine($"MK {i++} <{mk.code}> - <{mk.name}>");
        }
    }
}

class KuliahMahasiswa103022300160
{
        public List<Course> courses { get; set; }

        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\Praktikum Konstruksi PL\\TpMod7_kelompok\\tpmodul7_kelompok_4\\tp7_2_103022300160.json");
            KuliahMahasiswa103022300160 kuliah = JsonSerializer.Deserialize<KuliahMahasiswa103022300160>(jsonString);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var matkul in kuliah.courses)
            {
                Console.WriteLine($"MK {i} {matkul.code} - {matkul.name}");
                i++;
            }
        }
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
        var data = new DataMahasiswa_103022300099();
        data.ReadJSON();

        var kuliah = new KuliahMahasiswa103022300099();
        kuliah.ReadJSON();

        DataMahasiswa103022300049.ReadJSON();
        KuliahMahasiswa103022300049.ReadJSON();
  
        DataMahasiswa103022300160.ReadJSON();
        KuliahMahasiswa103022300160.ReadJSON();

        DataMahasiswa103022300001.ReadJSON();
        KuliahMahasiswa103022300001.ReadJSON();
    }
}
