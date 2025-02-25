using FotoSpelapp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoSpelApp.Models
{
    public class Member : User
    {
        [Ignore]
        public List<Comment> Comments { get; set; }
    }
}