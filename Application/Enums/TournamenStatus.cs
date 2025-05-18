using System.ComponentModel;

public enum TournamentStatus
{
    [Description("Scheduled")]
    Scheduled,

    [Description("Open")]
    Open,

    [Description("Locked")]
    Locked,

    [Description("Finished")]
    Finished
}