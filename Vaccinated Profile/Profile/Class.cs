
using System.ComponentModel.DataAnnotations;
namespace Vaccinated_Profile.Profile
{
    public class Class
    {
        public int ID { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public string Gender { get; set; } = string.Empty;
        public int Contact { get; set; }

        public string Vaccine { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime Fdose{ get; set; }
        [DataType(DataType.Date)]

        public DateTime Sdose { get; set; }
        public decimal Price { get; set; }




    }
}
