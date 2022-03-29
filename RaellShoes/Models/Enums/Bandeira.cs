using System.ComponentModel.DataAnnotations;

namespace RaellShoes.Models.Enums
{
    public enum Bandeira
    {
        Selecione,
        MasterCard,
        Visa,
        Elo,
        [Display(Name = "American Express")]
        AmericanExpress
    }
}
