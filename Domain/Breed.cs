namespace CatAsService.Domain
{
    public class Breed
    {
        public Weight weight { get; set; }
        public string id { get; set; } //"abys"
        public string name { get; set; } //"Abyssinian"
        public string cfa_url { get; set; } //"http://cfa.org/Breeds/BreedsAB/Abyssinian.aspx"
        public string vetstreet_url { get; set; } //"http://www.vetstreet.com/cats/abyssinian"
        public string vcahospitals_url { get; set; } //"https://vcahospitals.com/know-your-pet/cat-breeds/abyssinian"
        public string temperament { get; set; } //"Active, Energetic, Independent, Intelligent, Gentle"
        public string origin { get; set; } //"Egypt"
        public string country_codes { get; set; } //"EG"
        public string country_code { get; set; } //"EG"
        public string description { get; set; } //"The Abyssinian is easy to care for, and a joy to have in your home. They’re affectionate cats and love both people and other animals."
        public string life_span { get; set; } //"14 - 15"
        public int indoor { get; set; } //0
        public int lap { get; set; } //1
        public string alt_names { get; set; } //""
        public int adaptability { get; set; } //5
        public int affection_level { get; set; } //5
        public int child_friendly { get; set; } //3
        public int dog_friendly { get; set; } //4
        public int energy_level { get; set; } //5
        public int grooming { get; set; } //1
        public int health_issues { get; set; } //2
        public int intelligence { get; set; } //5
        public int shedding_level { get; set; } //2
        public int social_needs { get; set; } //5
        public int stranger_friendly { get; set; } //5
        public int vocalisation { get; set; } //1
        public int experimental { get; set; } //0
        public int hairless { get; set; } //0
        public int natural { get; set; } //1
        public int rare { get; set; } //0
        public int rex { get; set; } //0
        public int suppressed_tail { get; set; } //0
        public int short_legs { get; set; } //0
        public string wikipedia_url { get; set; } //"https://en.wikipedia.org/wiki/Abyssinian_(cat)"
        public int hypoallergenic { get; set; } //0
        public string reference_image_id { get; set; } //"0XYvRd7oD"
    }
}