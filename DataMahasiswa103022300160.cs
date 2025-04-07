using System;
using System.Data;
using System.Text;
using System.IO;
using System.Text.Json;

namespace tpmodul7_kelompok_4
{
    class Nama
    {
        public String depan { get; set; }
        public String belakang { get; set; }
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
}
