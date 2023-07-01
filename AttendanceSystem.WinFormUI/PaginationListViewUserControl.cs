using AttendanceSystem.Models.Ado_SqlServer.Views;
using AttendanceSystem.Presenter.IPresenter.User_Controls_View;
using System.Data;

namespace AttendanceSystem.WinFormUI;

public partial class PaginationListViewUserControl : UserControl, IPaginationListViewUCView
{
    public PaginationListViewUserControl()
    {
        InitializeComponent();
    }

    public DataTable DataTable { get; set; }
    public Type ModelType { get; set; }
    public string TableName { get; set; }
    public string OrderBy_ColumnName { get; set; }
    public string SearchBy_ColumnName { get; set; }
    public string SearchString { get; set; }

    public event EventHandler LoadData;



    private void PaginationListViewUserControl_Load(object sender, EventArgs e)
    {
        CreateRadioButtonsForModel();
        LoadDataInDataGridView();
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
        LoadDataInDataGridView();
    }

    private void LoadDataInDataGridView()
    {
        var fetchCount = 20;
        var offset = (int)numericUpDown1.Value * fetchCount;

        OrderBy_ColumnName = GetSelectedRadioButton(OrderByFlowLayoutPanel);
        SearchBy_ColumnName = GetSelectedRadioButton(SearchByFlowLayoutPanel);
        SearchString = SearchStringTextBox.Text;

        LoadData?.Invoke((offset, fetchCount), new EventArgs());
        dataGridView1.DataSource = DataTable;
        dataGridView1.Refresh();
    }

    private static string GetSelectedRadioButton(FlowLayoutPanel MyFlowLayoutPanel)
    {
        foreach (var control in MyFlowLayoutPanel.Controls)
        {
            if (control is RadioButton button && button.Checked)
            {
                return button.Text;
            }
        }
        return string.Empty;
    }


    public void CreateRadioButtonsForModel()
    {
        var properties = ModelType.GetProperties();
        bool flag1 = false, flag2 = false;
        foreach (var property in properties)
        {
            var radioButton1 = new RadioButton
            {
                Text = property.Name
            };
            if (flag1 is false)
            {
                radioButton1.Checked = true;
                flag1 = true;
            }
            radioButton1.CheckedChanged += (object? sender, EventArgs args) =>
            {
                if (sender is RadioButton button && button.Checked)
                {
                    LoadDataInDataGridView();
                }
            };
            OrderByFlowLayoutPanel.Controls.Add(radioButton1);

            var radioButton2 = new RadioButton
            {
                Text = property.Name
            };
            if (flag2 is false)
            {
                radioButton2.Checked = true;
                flag2 = true;
            }
            radioButton2.CheckedChanged += (object? sender, EventArgs args) =>
            {
                if (sender is RadioButton button && button.Checked)
                {
                    LoadDataInDataGridView();
                }
            };
            SearchByFlowLayoutPanel.Controls.Add(radioButton2);
        }
    }

    private void SearchStringTextBox_TextChanged(object sender, EventArgs e)
    {
        LoadDataInDataGridView();
    }
}
