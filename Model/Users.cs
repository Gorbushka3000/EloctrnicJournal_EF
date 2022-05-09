using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloctrnicJournal_EF.Model
{
    public class Users
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? Email { get; set; }   
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public DateTime BirtDay { get; set; }
    }

    public class Students : Users
    {
        public int Id { get; set; }
        public int Class { get; set; }
        public Parents Parents { get; set; }
        public int ParentsId { get; set; }
    }
    public class Parents : Users
    {
        public int Id { get; set; }
        public List<Students> Students { get; set; }
    }
    public class Teachers : Users
    {
        public int Id { get; set; }
        public List<Students> Students { get; set; }
    }
}
