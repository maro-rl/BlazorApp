using MudBlazor;

namespace BlazorApp.Themes
{
    public class LigthTheme : MudTheme
    {
        public LigthTheme()
        {
            Palette = new Palette()
            {
                Primary = "#090979",
                //DrawerBackground = "linear-gradient(90deg, rgba(2,0,36,1) 0%, rgba(9,9,121,0.9416141456582633) 35%, rgba(0,212,255,1) 100%);",
                Secondary = " #4D7CFE",
                Background = "#09097945"
            };
        }
    }
}
