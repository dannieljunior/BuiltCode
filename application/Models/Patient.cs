using System;
namespace application.Models
{
    public class Patient : ModelBase
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Cpf { get; set; }
    }
}