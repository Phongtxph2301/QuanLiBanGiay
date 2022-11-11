using System.ComponentModel;

namespace C_GUI.RJControls
{
    public class RJDropdownMenu : ContextMenuStrip
    {
        private Bitmap menuItemHeaderSize;

        //Constructor
        public RJDropdownMenu(IContainer container)
            : base(container)
        {

        }

        //Properties
        //Optionally, hide the properties in the toolbox to avoid the problem of displaying and/or 
        //saving control property changes in the designer at design time in Visual Studio.
        //If the problem I mention does not occur you can expose the properties and manipulate them from the toolbox.
        [Browsable(false)]
        public bool IsMainMenu { get; set; }

        [Browsable(false)]
        public int MenuItemHeight { get; set; } = 25;

        [Browsable(false)]
        public Color MenuItemTextColor { get; set; } = Color.Empty;

        [Browsable(false)]
        public Color PrimaryColor { get; set; } = Color.Empty;

        //Private methods
        private void LoadMenuItemHeight()
        {
            menuItemHeaderSize = IsMainMenu ? new Bitmap(25, 45) : new Bitmap(20, MenuItemHeight);

            foreach (ToolStripMenuItem menuItemL1 in Items)
            {
                menuItemL1.ImageScaling = ToolStripItemImageScaling.None;
                menuItemL1.Image ??= menuItemHeaderSize;

                foreach (ToolStripMenuItem menuItemL2 in menuItemL1.DropDownItems)
                {
                    menuItemL2.ImageScaling = ToolStripItemImageScaling.None;
                    menuItemL2.Image ??= menuItemHeaderSize;

                    foreach (ToolStripMenuItem menuItemL3 in menuItemL2.DropDownItems)
                    {
                        menuItemL3.ImageScaling = ToolStripItemImageScaling.None;
                        menuItemL3.Image ??= menuItemHeaderSize;

                        foreach (ToolStripMenuItem menuItemL4 in menuItemL3.DropDownItems)
                        {
                            menuItemL4.ImageScaling = ToolStripItemImageScaling.None;
                            menuItemL4.Image ??= menuItemHeaderSize;
                            ///Level 5++
                        }
                    }
                }
            }
        }

        //Overrides
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (DesignMode == false)
            {
                Renderer = new MenuRenderer(IsMainMenu, PrimaryColor, MenuItemTextColor);
                LoadMenuItemHeight();
            }
        }
    }
}
