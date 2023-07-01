namespace AttendanceSystem.WinFormUI;

public static class Extensions
{
    public static void SetSize(this ListView lv)
    {
        lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
    }

    public static void SetHeaders(this ListView lv, String[] headers)
    {
        foreach (var item in headers)
        {
            lv.Columns.Add(item);
        }
    }
}
