using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase05.Models
{
    public class TaskToDo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
