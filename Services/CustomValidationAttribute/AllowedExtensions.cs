namespace liaqati_master.Services.CustomValidationAttribute
{
    public class AllowedExtensions : ValidationAttribute
    {
        private readonly string[] _extensions;
        public AllowedExtensions(string[] extensions)
        {
            _extensions = extensions;
        }

        protected override ValidationResult IsValid(
        object value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName);
                if (!_extensions.Contains(extension.ToLower()))
                {
                    return new ValidationResult(GetErrorMessage());
                }
            }

            return ValidationResult.Success;
        }

        public string GetErrorMessage()
        {
            return $"This photo extension is not allowed!";
        }
    }
    //public class FileType : ValidationAttribute
    //{
    //    private readonly string _FileType;
    //    private readonly string? _errormessage;
    //    public FileType(string FileType, string? errormessage = null)
    //    {
    //        _FileType = FileType;
    //        _errormessage = errormessage;
    //    }

    //    protected override ValidationResult IsValid(
    //    object? value, ValidationContext validationContext)
    //    {
    //        var file = value as IFormFile;
    //        if (file != null)
    //        {
    //            string[] listOFtypes = _FileType.ToLower().Split(',');
    //            var Extension = Path.GetExtension(file.FileName);
    //            if (listOFtypes.Contains(Extension))
    //            {
    //                return new ValidationResult(GetErrorMessage());
    //            }
    //        }

    //        return ValidationResult.Success;
    //    }

    //    public override string FormatErrorMessage(string name)
    //    {
    //        return string.Format($"{0} انواع الملفات المسموحة {1} .", name, _FileType);
    //    }
    //    public string? GetErrorMessage()
    //    {
    //        return _errormessage;
    //    }
    //}

}
