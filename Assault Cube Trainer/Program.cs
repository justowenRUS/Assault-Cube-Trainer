using ClickableTransparentOverlay;
using ImGuiNET;

namespace AC_Trainer
{
    public class Renderer : Overlay
    {
        public bool godMode = false;
        public bool unlimitedAmmo = false;

        protected override void Render()
        {
            ImGui.Begin("Menu");

            ImGui.Checkbox("Godmode", ref godMode);
            ImGui.Checkbox("Unlimited ammo", ref unlimitedAmmo);
        }
    }
}