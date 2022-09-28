using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ODataBookStore.EDM
{
    public class Address
    {
        public string City { get; set; }
        public string Stress { get; set; }
    }
}
