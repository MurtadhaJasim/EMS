namespace Employee_management_system.Code.Helper
{
    internal class PageHelper(Main main)
    {
        private readonly Main _main = main;

        //Set New Page
        public void SetPage(UserControl PageUserControl)
        {
            //Get The Current Page
            var oldPage = _main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();

            // Remove the old Page
            if (oldPage != null && oldPage != PageUserControl)
                _main.panelContainer.Controls.Remove(oldPage);

            //Add new Page
            if (oldPage != PageUserControl)
            {
                PageUserControl.Dock = DockStyle.Fill;
                _main.panelContainer.Controls.Add(PageUserControl);
            }
              


        }
    }
}
