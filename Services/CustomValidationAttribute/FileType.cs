namespace liaqati_master.Services.CustomValidationAttribute
{
    public class FileType : ValidationAttribute
    {
        private readonly string _FileType;
        private readonly string _errormessage;
        public FileType(string FileType, string errormessage)
        {
            _FileType = FileType;
            _errormessage = errormessage;
        }

        protected override ValidationResult IsValid(
        object? value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file != null)
            {
                string[] listOFtypes = _FileType.ToLower().Split(',');
                if (listOFtypes.Contains(Path.GetExtension(file.FileName.ToLower())))
                {
                    return new ValidationResult(GetErrorMessage());
                }
            }

            return ValidationResult.Success ?? new ValidationResult(GetErrorMessage());
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format($"{0} انواع الملفات المسموحة {1} .", name, _FileType);
        }
        public string GetErrorMessage()
        {
            return _errormessage;
        }
    }

}
