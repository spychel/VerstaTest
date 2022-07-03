using System.ComponentModel.DataAnnotations;
using VerstaTest.Validators;

namespace VerstaTest.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; } = Guid.Empty;

        public string OrderNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Данное поле обязательно к заполнению")]
        public string SenderCity { get; set; } = string.Empty;

        [Required(ErrorMessage = "Данное поле обязательно к заполнению")]
        public string SenderAddress { get; set; } = string.Empty;

        [Required(ErrorMessage = "Данное поле обязательно к заполнению")]
        public string ReceiverCity { get; set; } = string.Empty;

        [Required(ErrorMessage = "Данное поле обязательно к заполнению")]
        public string ReceiverAddress { get; set; } = string.Empty;

        [Required(ErrorMessage = "Данное поле обязательно к заполнению")]
        [Range(typeof(float), "0.01", "99999.99", ErrorMessage = "Вес груза от 0,01 кг до 99 999,99 кг")]
        public float CargoWeight { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно к заполнению")]
        [DateFromNow(ErrorMessage = "Дата забора груза не может быть раньше текущего дня")]
        [DataType(DataType.Date)]
        [Date(ErrorMessage = "Введите в поле дату формата дд.мм.гггг")]
        public DateOnly PickupDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }
}