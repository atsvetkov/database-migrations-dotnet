using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseMigrationsTest.EntityFramework
{
    public class Person
    {
        public int PersonId { get; set; }

        [Required]
        [StringLength(500)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
