using Terraria;
using Terraria.ModLoader;

namespace StaticMenu.Content.Menus
{
    public class Menu_Black : ModMenu
    {
        public override void Update(bool isOnTitleScreen)
        {
            Main.MenuXMovement = 1f;
            Main.dayTime = false;
            Main.menuBGChangedNight = false;
        }

        public override void SetStaticDefaults()
        {
            
        }
    }
}
