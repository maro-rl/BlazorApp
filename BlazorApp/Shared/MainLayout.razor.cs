namespace BlazorApp.Shared
{
    public partial class MainLayout
    {
        public bool _isOpenDrawer = true;

        void DrawerToggle() => _isOpenDrawer = !_isOpenDrawer;
    }
}
