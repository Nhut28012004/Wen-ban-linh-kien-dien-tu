using System.ComponentModel.DataAnnotations;

namespace QLBH.Repository.Validation
{
    public class FileExtentionAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is IFormFile file)
            {
                var extension = Path.GetExtension(file.FileName);
                string[] extensions = { ".jpg", ".jpeg", ".png"};
                bool result = extensions.Any(x => extension.EndsWith(x));
                if (!result)
                {
                    return new ValidationResult("Chỉ chấp nhận file ảnh với định dạng .jpg, .jpeg, .png");
                }
            }
            return ValidationResult.Success;
        }
    }
}
