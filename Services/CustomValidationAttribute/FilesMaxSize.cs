namespace liaqati_master.Services.CustomValidation
{

    public class FilesMaxSize : ValidationAttribute
    {
        private readonly int _maxFileSize;
        private readonly string _errormessage;
        public FilesMaxSize(int maxFileSize, string errormessage)
        {
            _maxFileSize = maxFileSize;
            _errormessage = errormessage;
        }

        protected override ValidationResult IsValid(
        object? value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file != null)
            {
                if (file.Length > _maxFileSize)
                {
                    return new ValidationResult(GetErrorMessage());
                }
            }

            return ValidationResult.Success ?? new ValidationResult(GetErrorMessage());
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format($"{0} Maximum allowed File size is {1} bytes.", name, _maxFileSize);
        }
        public string GetErrorMessage()
        {
            return _errormessage;
        }
    }
}
