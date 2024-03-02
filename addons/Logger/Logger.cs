using Godot;

public static class Logger
{
    public static bool DebugMode { get; set; } = true;

    public enum LogTypeEnum
    {
        Info,
        Warning,
        Error,
        EnterTree,
        ExitTree,
        Ready
    }

    public static void Log(string message, LogTypeEnum logType = LogTypeEnum.Info)
    {
        if (DebugMode)
        {
            var color = logType switch
            {
                LogTypeEnum.Warning => "yellow",
                LogTypeEnum.Error => "red",
                LogTypeEnum.EnterTree => "magenta",
                LogTypeEnum.ExitTree => "pink",
                LogTypeEnum.Ready => "green",
                _ => "gray"
            };

            var prefix = logType switch
            {
                LogTypeEnum.Warning => "(!)",
                LogTypeEnum.Error => "!",
                LogTypeEnum.EnterTree => ">",
                LogTypeEnum.ExitTree => "<",
                _ => ""
            };

            GD.PrintRich($"[color={color}]{prefix} {message}[/color]");
        }
    }
}