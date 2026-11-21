using Universal_x86_Tuning_Utility.Properties;

namespace Universal_x86_Tuning_Utility.Services;

public interface IAutomationSettings
{
    string acPreset { get; set; }
    string dcPreset { get; set; }
    string resumePreset { get; set; }
    string acCommandString { get; set; }
    string dcCommandString { get; set; }
    string resumeCommandString { get; set; }
    string lockPreset { get; set; }
    string unlockPreset { get; set; }
    string lockCommandString { get; set; }
    string unlockCommandString { get; set; }
    void Save();
}

public sealed class AutomationSettings : IAutomationSettings
{
    public string acPreset { get => Settings.Default.acPreset; set => Settings.Default.acPreset = value; }
    public string dcPreset { get => Settings.Default.dcPreset; set => Settings.Default.dcPreset = value; }
    public string resumePreset { get => Settings.Default.resumePreset; set => Settings.Default.resumePreset = value; }
    public string acCommandString { get => Settings.Default.acCommandString; set => Settings.Default.acCommandString = value; }
    public string dcCommandString { get => Settings.Default.dcCommandString; set => Settings.Default.dcCommandString = value; }
    public string resumeCommandString { get => Settings.Default.resumeCommandString; set => Settings.Default.resumeCommandString = value; }
    public string lockPreset { get => Settings.Default.lockPreset; set => Settings.Default.lockPreset = value; }
    public string unlockPreset { get => Settings.Default.unlockPreset; set => Settings.Default.unlockPreset = value; }
    public string lockCommandString { get => Settings.Default.lockCommandString; set => Settings.Default.lockCommandString = value; }
    public string unlockCommandString { get => Settings.Default.unlockCommandString; set => Settings.Default.unlockCommandString = value; }
    public void Save() => Settings.Default.Save();
}
