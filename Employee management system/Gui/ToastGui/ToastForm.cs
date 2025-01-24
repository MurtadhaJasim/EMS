namespace Employee_management_system.Gui.ToastGui
{
    public partial class ToastForm : Form
    {
        private static ToastForm? toastForm;
        public static string Title;
        public static string Description;


        public ToastForm()
        {
            InitializeComponent();

        }
        public static ToastForm Instance(string title, string description)
        {
            Title = title;
            Description = description;

            return toastForm ?? (toastForm = new ToastForm());
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void timerToast_Tick(object sender, EventArgs e)
        {
            this.Hide();
            timerToast.Enabled = false;
        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

        private void ToastForm_Activated(object sender, EventArgs e)
        {
            labelTitle.Text = Title;
            labelDescription.Text = Description;
            timerToast.Interval = Properties.Settings.Default.ToastDuration;
            timerToast.Enabled = true;
        }
    }
}
