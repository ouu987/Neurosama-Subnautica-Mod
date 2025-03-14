using System.Collections.Generic;
using SCHIZO.SwarmControl.Redeems.Enums;

namespace SCHIZO.SwarmControl.Redeems.Audio;

internal static class NoiseRegistry
{
    public static readonly Dictionary<NormalNoise, string> Normal = new()
    {
        [NormalNoise.ErmfishAmbient] = "event:/SCHIZO/creatures/ermfish/ambient_world",
        [NormalNoise.ErmfishCook] = "event:/SCHIZO/creatures/ermfish/cook",
        [NormalNoise.ErmfishEat] = "event:/SCHIZO/creatures/ermfish/eat",
        [NormalNoise.AnneelAmbient] = "event:/SCHIZO/creatures/anneel/ambient",
        [NormalNoise.AnneelHurt] = "event:/SCHIZO/creatures/anneel/hurt",
        [NormalNoise.ErmsharkAmbient] = "event:/SCHIZO/creatures/ermshark/ambient",
        [NormalNoise.ErmsharkAttack] = "event:/SCHIZO/creatures/ermshark/attack",
        [NormalNoise.ErmsharkHurt] = "event:/SCHIZO/creatures/ermshark/hurt",
        [NormalNoise.TutelAmbient] = "event:/SCHIZO/creatures/tutel/ambient_world",
        [NormalNoise.TutelCook] = "event:/SCHIZO/creatures/tutel/cook",
        [NormalNoise.TutelEat] = "event:/SCHIZO/creatures/tutel/eat"
    };

    public static readonly Dictionary<TrollNoise, string> Troll = new()
    {
        [TrollNoise.SomeoneTellVedal] = "event:/SCHIZO/troll/someone_tell_vedal",
#if BELOWZERO
        [TrollNoise.Leviathan] = "event:/bz/creature/shadow_leviathan/post_kill_roar",
#else
        [TrollNoise.Leviathan] = "", // todo when i can be bothered
#endif
        [TrollNoise.UsbDisconnect] = "event:/SCHIZO/troll/usb_disconnect",
        [TrollNoise.UsbConnect] = "event:/SCHIZO/troll/usb_connect",
        [TrollNoise.DiscordDisconnect] = "event:/SCHIZO/troll/discord_dc",
        [TrollNoise.DiscordJoin] = "event:/SCHIZO/troll/discord_join",
        [TrollNoise.Grindr] = "event:/SCHIZO/troll/grindr",
        [TrollNoise.FilianScream] = "event:/SCHIZO/troll/filian_scream",
        [TrollNoise.ProgramInC] = "event:/SCHIZO/troll/programinc",
        [TrollNoise.StereoKnock] = "event:/SCHIZO/troll/knock",
    };
}
