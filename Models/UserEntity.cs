using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorLivro.API.Models
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}