namespace Fishley;

public partial class Fishley
{
	public static GuildEmote WarnEmoji => SmallFishServer.Emotes.FirstOrDefault(x => x.Name == "warn");
	public static GuildEmote SDollarEmoji => SmallFishServer.Emotes.FirstOrDefault(x => x.Name == "sdollar");
}