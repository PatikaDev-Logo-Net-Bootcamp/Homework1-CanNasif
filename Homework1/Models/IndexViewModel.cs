using System.ComponentModel.DataAnnotations;


namespace Homework1.Models
{
    public class IndexViewModel
    {


        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu alan gereklidir!")]
        [DataType(DataType.Text)]
        [Display(Name = "İsim")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Lütfen geçerli bir ad giriniz!")]
        public string Name { get; set; }


        
        [Required(ErrorMessage = "Bu alan gereklidir!")]
        [DataType(DataType.Text)]
        [Display(Name = "Soyadi")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Lütfen geçerli bir soyad giriniz!")]
        public string SurName { get; set; }


        [Required(ErrorMessage = "Bu alan gereklidir!")]
        [Display(Name = "E-mail")]
        [RegularExpression("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{8,32}$", ErrorMessage = "Lütfen geçerli bir e-mail adresi giriniz! Örn: asd@fgh.com ")]
        [DataType(DataType.EmailAddress)]
        public string EPosta { get; set; }


        [Required(ErrorMessage = "Bu alan gereklidir!")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$", ErrorMessage = "Şifre en az 8 karakter olmalıdır! En az 1 büyük harf, en az 1 karakter ve en az 1 sayı içermelidir!")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


    }
}
