using System;
using System.ComponentModel.DataAnnotations;

namespace K_DLab4.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.DateTime)] // need time & date
        public DateTime addDate { get; set; }
        public string Author { get; set; }
        public string Kind { get; set; }
    }
}
