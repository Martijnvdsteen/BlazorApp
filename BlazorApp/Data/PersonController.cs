namespace BlazorApp.Data
{
    public class PersonController
    {
        private static readonly string[] Naam = new[]
        {
        "Martijn", "Henk", "Joris", "John"
        };
        private static readonly string[] Mail = new[]
        {
        "MartijnvdSteen@florisoft.nl", "HenkvanDijk@florisoft.nl", "JorisdeJong@florisoft.nl","JohnvanHulst@florisoft.nl"
        };
        private static readonly string[] Functie = new[]
        {
        "Web developer", "Web developer", "Consultant","Backend developer"
        };

        public static Task<PersonModel[]> GetPersonsAsync()
        {
            return Task.FromResult(Enumerable.Range(0, 4).Select(index => new PersonModel
            {
                Organisatie = "Florisoft",
                Functie = Functie[index],
                Naam = Naam[index],
                Email = Mail[index],
                Foto = "../Person_placeholder_man.jpg",
                ID = Random.Shared.Next(200, 555)

            }).ToArray());
        }
    }
}