using System.Collections.Generic;

namespace TvMazeScraper.API.Models
{
    public class CastShowPublicResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Embedded _embedded { get; set; }
    }

    public class Embedded
    {
       public List<Person> cast { get; set; }
    }

    public class Person
    {
        public Cast person { get; set; }
    }
}
