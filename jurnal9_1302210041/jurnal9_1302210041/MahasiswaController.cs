
using Microsoft.AspNetCore.Mvc;

namespace jurnal9_1302210041
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswas = new List<Mahasiswa>
        {
            new Mahasiswa("Muhamad Ilham Nasrullah", "1302210041",new List<String>{"KPL","PBO"} , 2021 ),
            new Mahasiswa("Adam Rafif Faqih", "1302210008",new List<String>{"KPL","PBO"},2021),
            new Mahasiswa("Habli Zulvana Ath-Thaariq", "1302210024",new List<String>{"KPL","PBO"},2021),
            new Mahasiswa("Maximus Bayu", "1302210101",new List<String>{"KPL","PBO"},2021),
            new Mahasiswa("Muhammad Isa Al Anshori", "1302210014",new List<String>{"KPL","PBO"},2021)
        };
        //membuat get di controller
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswas;
        }

        //menambahkan object 
        [HttpPost(Name = "PostMahasiswa")]
        public IActionResult Post(Mahasiswa value)
        {
            mahasiswas.Add(value);
            return Ok(mahasiswas);
        }

        //get sesuia index
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswas[id];
        }

        //untuk mengahapus index
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswas.RemoveAt(id);
        }
    }
}