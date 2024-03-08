using AC_Trainer;
using Swed32;

Renderer renderer = new Renderer();
renderer.Start().Wait();

Swed swed = new Swed("ac_client");
IntPtr moduleBase = swed.GetModuleBase("ac_client.exe");

IntPtr healthInstructionAddress = moduleBase + 0x1C223;
IntPtr ammoInstructionAddress = moduleBase + 0xC73EF;

while(true)
{
    if (renderer.godMode)
    {
        swed.WriteBytes(healthInstructionAddress, "90 90 90");
    }
    else
    {
        swed.WriteBytes(healthInstructionAddress, "29 7B 04");

    }
    if (renderer.unlimitedAmmo)
    {
        swed.WriteBytes(ammoInstructionAddress, "90 90");
    }
    else
    {
        swed.WriteBytes(ammoInstructionAddress, "FF 08");
    }
    Thread.Sleep(20);
}