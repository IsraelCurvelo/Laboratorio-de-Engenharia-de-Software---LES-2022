using System.ComponentModel.DataAnnotations;

namespace RaellShoes.Models.Enums
{
    public enum Bandeira
    {
        MasterCard,
        Visa,
        Elo,
        [Display(Name = "American Express")]
        AmericanExpress
    }
}
