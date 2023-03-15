namespace liaqati_master.Services
{
    public static class Guid_Id
    {
        public static string Id_Guid()
        {
            string Id = Guid.NewGuid().ToString();
            return Id;

        }
    }
}
