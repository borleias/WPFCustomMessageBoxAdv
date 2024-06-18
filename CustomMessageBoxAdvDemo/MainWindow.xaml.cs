using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using WPFCustomMessageBoxAdv;
using MessageBox = System.Windows.Forms.MessageBox;

namespace CustomMessageBoxDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the click event of the button_StandardMessage and shows a standard message box.
        /// </summary>
        private void Button_StandardMessage_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(string.Join("\n", Enumerable.Repeat("Hello World!", 12)));
            Debug.WriteLine(result.ToString());
        }

        /// <summary>
        /// Handles the click event of the button_StandardMessageNew and shows a custom message box.
        /// </summary>
        private void Button_StandardMessageNew_Click(object sender, RoutedEventArgs e)
        {
            var result = CustomMessageBox.Show(string.Join("\n", Enumerable.Repeat("Hello World!", 12)));
            Debug.WriteLine(result.ToString());
        }

        /// <summary>
        /// Handles the click event of the button_MessageWithCaption and shows a message box with a caption.
        /// </summary>
        private void Button_MessageWithCaption_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Hello World!", "Hello World the title.");
            Debug.WriteLine(result.ToString());
        }

        /// <summary>
        /// Handles the click event of the button_MessageWithCaptionNew and shows a custom message box with a caption.
        /// </summary>
        private void Button_MessageWithCaptionNew_Click(object sender, RoutedEventArgs e)
        {
            var result = CustomMessageBox.Show("Hello world!", "Hello World the title.", MessageBoxButtons.RetryCancel);
            Debug.WriteLine(result.ToString());
        }

        /// <summary>
        /// Handles the click event of the button_MessageWithCaptionAndButton and shows a message box with a caption and buttons.
        /// </summary>
        private void Button_MessageWithCaptionAndButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Hello World!", "Hello World the title.", MessageBoxButtons.OKCancel);
            Debug.WriteLine(result.ToString());
        }

        /// <summary>
        /// Handles the click event of the button_MessageWithCaptionAndButtonNew and shows a custom message box with a caption and buttons.
        /// </summary>
        private void Button_MessageWithCaptionAndButtonNew_Click(object sender, RoutedEventArgs e)
        {
            var result = CustomMessageBox.Show("Hello World!", "Hello World the title.", MessageBoxButtons.OKCancel);
            Debug.WriteLine(result.ToString());
        }

        /// <summary>
        /// Handles the click event of the button_MessageWithCaptionButtonImage and shows a message box with a caption, buttons, and an image.
        /// </summary>
        private void Button_MessageWithCaptionButtonImage_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to eject the nuclear fuel rods?",
                "Confirm Fuel Ejection",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation);
            Debug.WriteLine(result.ToString());
        }

        /// <summary>
        /// Handles the click event of the button_MessageWithCaptionButtonImageNew and shows a custom message box with a caption, buttons, and an image.
        /// </summary>
        private void Button_MessageWithCaptionButtonImageNew_Click(object sender, RoutedEventArgs e)
        {
            var result = CustomMessageBox.Show("This is a message.", "This is a caption", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            Debug.WriteLine(result.ToString());
        }

        /// <summary>
        /// Handles the click event of the button_MessageWithCaptionButtonCustomImageNew and shows a custom message box with a caption, buttons, and a custom image.
        /// </summary>
        private void Button_MessageWithCaptionButtonCustomImageNew_Click(object sender, RoutedEventArgs e)
        {
            var shield = Imaging.CreateBitmapSourceFromHIcon(
                SystemIcons.Shield.Handle,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            var msgBox = new MessageBoxModel()
            {
                Message = "This is a wide message with a windows shield beside it.",
                Caption = "This is a caption",
                Width = 900,
                MinButtonWidth = 100,
                RetryButtonWidth = 300,
                Buttons = MessageBoxButtons.RetryCancel,
                CustomIcon = shield
            };
            var result = msgBox.ShowDialog();

            Debug.WriteLine(result.ToString());
        }

        /// <summary>
        /// Handles the click event of the button_SelfUpdatingMessage and shows a self-updating message box.
        /// </summary>
        private void Button_SelfUpdatingMessage_Click(object sender, RoutedEventArgs e)
        {
            var stopwatch = Stopwatch.StartNew();
            var msgBox = new MessageBoxModel()
            {
                Message = $"This message box is open since {(int)stopwatch.Elapsed.TotalSeconds}s",
                Caption = $"Open since {(int)stopwatch.Elapsed.TotalSeconds}s",
                Buttons = MessageBoxButtons.OK
            };
            var task = msgBox.Show();

            while (task.Status == TaskStatus.Running)
            {
                msgBox.Message = $"This message box is open since {(int)stopwatch.Elapsed.TotalSeconds}s";
                msgBox.Caption = $"Open since {(int)stopwatch.Elapsed.TotalSeconds}s";
                Task.Delay(100).Wait();
            }

            Debug.WriteLine(task.Result.ToString());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Handles the click event of the button1 and shows a custom message box with Abort, Retry, Ignore buttons.
        /// </summary>
        private void Button_CustomText_Click(object sender, RoutedEventArgs e)
        {
            var result = CustomMessageBox.ShowAbortRetryIgnore(
                "You have unsaved changes.",
                "Unsaved Changes!",
                "This is a long text that wraps around",
                "Don't Save",
                "Cancel",
                MessageBoxIcon.Exclamation);

            Debug.WriteLine(result.ToString());
        }
    }
}
