using Microsoft.AspNetCore.Components;

namespace BlazorApp.Data
{
    public class PersonModel
    {
        public int ID { get; set; }

        public string Naam { get; set; } = "";
        public string Foto { get; set; }
        public string Functie { get; set; } = "";
        public string Email { get; set; } = "";
        public string Organisatie { get; set; } = "";
    }
}