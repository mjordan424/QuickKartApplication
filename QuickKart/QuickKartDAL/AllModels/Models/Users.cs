using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace QuickKartDAL.AllModels.Models
{
    public class Users
    {
        public Users()
        {

        }
        [Key]//Used to make EmailId column as primary key using data annotation
        public string EmailId { get; set; }
        [MaxLength(50)]
        [Required]
        public string UserPassword { get; set; }
        public byte RoleId { get; set; }//this will confirm that foreign key is not null. Without this foreign key will be generated but it will be nullable.
        [Required]
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

        public Roles Role { get; set; }//This will create foreign key
    }
}
