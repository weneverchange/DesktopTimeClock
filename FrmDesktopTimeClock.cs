namespace DesktopTimeClock;

public partial class FrmDesktopTimeClock : Form
{
    private TimeSpan enterTime = TimeSpan.Zero;
    private TimeSpan exitTime = TimeSpan.Zero;

    public FrmDesktopTimeClock()
    {
        InitializeComponent();
    }

    private void OnTimeChange(object enterHourSender, object exitHourSender, object totalHourSender, object? previousExitHourSender = null)
    {
        DateTimePicker enterHourTimePicker = (DateTimePicker)enterHourSender;
        DateTimePicker exitHourTimePicker = (DateTimePicker)exitHourSender;
        DateTimePicker totalHourTimePicker = (DateTimePicker)totalHourSender;
        DateTimePicker? previousExitHourPicker = (DateTimePicker?)previousExitHourSender;

        TimeSpan enterHourTime = enterHourTimePicker.Value.TimeOfDay;
        TimeSpan exitHourTime = exitHourTimePicker.Value.TimeOfDay;
        TimeSpan? previousExitHourTime = previousExitHourPicker?.Value.TimeOfDay;

        if (previousExitHourTime != null && previousExitHourTime > enterHourTime)
        {
            enterHourTimePicker.Value = DateTime.Today.Add((TimeSpan)previousExitHourTime);
        }
        else if (exitHourTime >= enterHourTime || !exitHourTimePicker.Enabled || (previousExitHourTime != null && previousExitHourTime == enterHourTime))
        {
            TimeSpan currentTotalHours = exitHourTime - enterHourTime;

            totalHourTimePicker.Value = DateTime.Today.Add(currentTotalHours);

            UpdateHoursBalance();

            exitHourTimePicker.Enabled = true;

            enterTime = enterHourTime;
            exitTime = exitHourTime;
        }
        else
        {
            enterHourTimePicker.Value = DateTime.Today.Add(enterTime);
            exitHourTimePicker.Value = DateTime.Today.Add(exitTime);
        }
    }

    private void UpdateHoursBalance()
    {
        List<TimeSpan> timeEntries = [
            TimeTotalHour1.Value.TimeOfDay,
            TimeTotalHour2.Value.TimeOfDay,
            TimeTotalHour3.Value.TimeOfDay,
            TimeTotalHour4.Value.TimeOfDay
        ];
        TimeSpan hoursBalance = TimeSpan.Zero;

        foreach (var timeEntry in timeEntries)
        {
            hoursBalance += timeEntry;
        }

        TimeHoursBalance.Value = DateTime.Today.Add(hoursBalance);
    }

    private void TimeEnterHour1_ValueChanged(object sender, EventArgs e) => OnTimeChange(sender, TimeExitHour1, TimeTotalHour1);
    private void TimeEnterHour2_ValueChanged(object sender, EventArgs e) => OnTimeChange(sender, TimeExitHour2, TimeTotalHour2, TimeExitHour1);
    private void TimeEnterHour3_ValueChanged(object sender, EventArgs e) => OnTimeChange(sender, TimeExitHour3, TimeTotalHour3, TimeExitHour2);
    private void TimeEnterHour4_ValueChanged(object sender, EventArgs e) => OnTimeChange(sender, TimeExitHour4, TimeTotalHour4, TimeExitHour3);

    private void TimeExitHour1_ValueChanged(object sender, EventArgs e) => OnTimeChange(TimeEnterHour1, sender, TimeTotalHour1);
    private void TimeExitHour2_ValueChanged(object sender, EventArgs e) => OnTimeChange(TimeEnterHour2, sender, TimeTotalHour2, TimeExitHour1);
    private void TimeExitHour3_ValueChanged(object sender, EventArgs e) => OnTimeChange(TimeEnterHour3, sender, TimeTotalHour3, TimeExitHour2);
    private void TimeExitHour4_ValueChanged(object sender, EventArgs e) => OnTimeChange(TimeEnterHour4, sender, TimeTotalHour4, TimeExitHour3);
}
