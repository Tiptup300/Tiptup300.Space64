namespace KristofferStrube.Blazor.WebAudio.WasmExample.Pages;


public class AudioPlayerPageState
{
    public bool Playing;
    public bool IsCurrentTrackLoaded;
    public int CurrentTrack;
    public double PlayTime;
    public double StartTime;
    public double? PauseTime;
    public double Offset;
    public double TrackDuration;
    public int Interactions;
}
