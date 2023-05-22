namespace liaqati_master.ViewModels
{
    public class VmConsultation
    {

        [ Display(Name = "عنوان الاستشارة")]
        public string? Title { get; set; }

        [Display(Name = " وصف الاستشارة")]
        public string? Description { get; set; }


        [Display(Name = "تاريخ النشر")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Display(Name = "صورة الامستشار ")]
        public string? imgUrl { get; set; } = "";
        [Display(Name = "تخصص الامستشار ")]
        public string? Specialization { get; set; } = "";
   
        public string? Category { get; set; }

        public string? User { get; set; }


    }
}
