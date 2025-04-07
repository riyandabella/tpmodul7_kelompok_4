using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_4
{
    class Course
    {
        public String code { get; set; }
        public String name { get; set; }
 
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
}
