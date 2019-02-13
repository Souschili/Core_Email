using System.ComponentModel.DataAnnotations;

namespace Core_Email.ViewModels
{
    public class DataInputViewModel
    {

        //тест стринг удалить!
        public string Title { get; set; } = "This is test string";
        [Required(ErrorMessage = "Input Login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Input password")]
        public string Password { get; set; }

    }
}
