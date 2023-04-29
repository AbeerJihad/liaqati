namespace liaqati_master.ViewModels
{
    public class Menu
    {

        public List<PageLink>? SubMenus { get; set; }
        public PageLink? PageLink { get; set; }
    }

    public class PageLink
    {
        public string? LinkName { get; set; }
        public string? LinkURL { get; set; }
        public string? LinkIcon { get; set; }
    }

}
