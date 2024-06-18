using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace WPFCustomMessageBoxAdv
{
    /// <summary>
    /// View model for the custom message box.
    /// </summary>
    internal class CustomMessageBoxViewModel : INotifyPropertyChanged
    {
        #region Constants

        private static double ButtonMinWidth => 88;

        private static double ButtonMaxWidth => 160;

        private static double ButtonMinHeight => 26;

        private static double ButtonMaxHeight => 80;

        #endregion

        #region Properties that can be updated while the message box is open

        /// <summary>
        /// Gets or sets the caption of the message box.
        /// </summary>
        public string Caption
        {
            get => this.caption;
            set
            {
                this.caption = value;
                this.OnPropertyChanged(nameof(this.Caption));
            }
        }
        private string caption = "Message";

        /// <summary>
        /// Gets or sets the message of the message box.
        /// </summary>
        public string Message
        {
            get => this.message;
            set
            {
                this.message = value;
                this.OnPropertyChanged(nameof(this.Message));
            }
        }
        private string message = string.Empty;

        /// <summary>
        /// Gets or sets the caption of the cancel button.
        /// </summary>
        public string CancelButtonCaption
        {
            get => this.cancelButtonCaption;
            set
            {
                this.cancelButtonCaption = value;
                this.OnPropertyChanged(nameof(this.CancelButtonCaption));
            }
        }
        private string cancelButtonCaption = "Cancel";

        /// <summary>
        /// Gets or sets the caption of the no button.
        /// </summary>
        public string NoButtonCaption
        {
            get => this.noButtonCaption;
            set
            {
                this.noButtonCaption = value;
                this.OnPropertyChanged(nameof(this.NoButtonCaption));
            }
        }
        private string noButtonCaption = "No";

        /// <summary>
        /// Gets or sets the caption of the yes button.
        /// </summary>
        public string YesButtonCaption
        {
            get => this.yesButtonCaption;
            set
            {
                this.yesButtonCaption = value;
                this.OnPropertyChanged(nameof(this.YesButtonCaption));
            }
        }
        private string yesButtonCaption = "Yes";

        /// <summary>
        /// Gets or sets the caption of the OK button.
        /// </summary>
        public string OkButtonCaption
        {
            get => this.okButtonCaption;
            set
            {
                this.okButtonCaption = value;
                this.OnPropertyChanged(nameof(this.OkButtonCaption));
            }
        }
        private string okButtonCaption = "OK";

        /// <summary>
        /// Gets or sets the caption of the abort button.
        /// </summary>
        public string AbortButtonCaption
        {
            get => this.abortButtonCaption;
            set
            {
                this.abortButtonCaption = value;
                this.OnPropertyChanged(nameof(this.AbortButtonCaption));
            }
        }
        private string abortButtonCaption = "Abort";

        /// <summary>
        /// Gets or sets the caption of the retry button.
        /// </summary>
        public string RetryButtonCaption
        {
            get => this.retryButtonCaption;
            set
            {
                this.retryButtonCaption = value;
                this.OnPropertyChanged(nameof(this.RetryButtonCaption));
            }
        }
        private string retryButtonCaption = "Retry";

        /// <summary>
        /// Gets or sets the caption of the ignore button.
        /// </summary>
        public string IgnoreButtonCaption
        {
            get => this.ignoreButtonCaption;
            set
            {
                this.ignoreButtonCaption = value;
                this.OnPropertyChanged(nameof(this.IgnoreButtonCaption));
            }
        }
        private string ignoreButtonCaption = "Retry";

        #endregion

        #region Fixed properties

        /// <summary>
        /// Gets or sets the maximum width of the message box.
        /// </summary>
        public double MaxWidth { get; set; } = 800;

        /// <summary>
        /// Gets or sets the minimum width of the message box.
        /// </summary>
        public double MinWidth { get; set; } = 154;

        /// <summary>
        /// Gets or sets the maximum height of the message box.
        /// </summary>
        public double MaxHeight { get; set; } = 600;

        /// <summary>
        /// Gets or sets the minimum height of the message box.
        /// </summary>
        public double MinHeight { get; set; } = 155;

        /// <summary>
        /// Gets or sets the custom icon of the message box.
        /// </summary>
        public ImageSource CustomIcon { get; set; }

        /// <summary>
        /// Gets the visibility of the image.
        /// </summary>
        public Visibility ImageVisibility => (this.CustomIcon is null) ? Visibility.Collapsed : Visibility.Visible;

        /// <summary>
        /// Gets or sets the minimum height of the buttons.
        /// </summary>
        public double MinButtonHeight { get; set; } = ButtonMinHeight;

        /// <summary>
        /// Gets or sets the maximum height of the buttons.
        /// </summary>
        public double MaxButtonHeight { get; set; } = ButtonMaxHeight;

        /// <summary>
        /// Gets or sets the minimum width of the cancel button.
        /// </summary>
        public double CancelButtonMinWidth { get; set; } = ButtonMinWidth;

        /// <summary>
        /// Gets or sets the maximum width of the cancel button.
        /// </summary>
        public double CancelButtonMaxWidth { get; set; } = ButtonMaxWidth;

        /// <summary>
        /// Gets or sets the minimum width of the no button.
        /// </summary>
        public double NoButtonMinWidth { get; set; } = ButtonMinWidth;

        /// <summary>
        /// Gets or sets the maximum width of the no button.
        /// </summary>
        public double NoButtonMaxWidth { get; set; } = ButtonMaxWidth;

        /// <summary>
        /// Gets or sets the minimum width of the yes button.
        /// </summary>
        public double YesButtonMinWidth { get; set; } = ButtonMinWidth;

        /// <summary>
        /// Gets or sets the maximum width of the yes button.
        /// </summary>
        public double YesButtonMaxWidth { get; set; } = ButtonMaxWidth;

        /// <summary>
        /// Gets or sets the minimum width of the OK button.
        /// </summary>
        public double OkButtonMinWidth { get; set; } = ButtonMinWidth;

        /// <summary>
        /// Gets or sets the maximum width of the OK button.
        /// </summary>
        public double OkButtonMaxWidth { get; set; } = ButtonMaxWidth;

        /// <summary>
        /// Gets or sets the minimum width of the abort button.
        /// </summary>
        public double AbortButtonMinWidth { get; set; } = ButtonMinWidth;

        /// <summary>
        /// Gets or sets the maximum width of the abort button.
        /// </summary>
        public double AbortButtonMaxWidth { get; set; } = ButtonMaxWidth;

        /// <summary>
        /// Gets or sets the minimum width of the retry button.
        /// </summary>
        public double RetryButtonMinWidth { get; set; } = ButtonMinWidth;

        /// <summary>
        /// Gets or sets the maximum width of the retry button.
        /// </summary>
        public double RetryButtonMaxWidth { get; set; } = ButtonMaxWidth;

        /// <summary>
        /// Gets or sets the minimum width of the ignore button.
        /// </summary>
        public double IgnoreButtonMinWidth { get; set; } = ButtonMinWidth;

        /// <summary>
        /// Gets or sets the maximum width of the ignore button.
        /// </summary>
        public double IgnoreButtonMaxWidth { get; set; } = ButtonMaxWidth;

        /// <summary>
        /// Gets or sets the visibility of the cancel button.
        /// </summary>
        public Visibility CancelButtonVisibility { get; set; } = Visibility.Collapsed;

        /// <summary>
        /// Gets or sets the visibility of the no button.
        /// </summary>
        public Visibility NoButtonVisibility { get; set; } = Visibility.Collapsed;

        /// <summary>
        /// Gets or sets the visibility of the yes button.
        /// </summary>
        public Visibility YesButtonVisibility { get; set; } = Visibility.Collapsed;

        /// <summary>
        /// Gets or sets the visibility of the OK button.
        /// </summary>
        public Visibility OkButtonVisibility { get; set; } = Visibility.Collapsed;

        /// <summary>
        /// Gets or sets the visibility of the abort button.
        /// </summary>
        public Visibility AbortButtonVisibility { get; set; } = Visibility.Collapsed;

        /// <summary>
        /// Gets or sets the visibility of the retry button.
        /// </summary>
        public Visibility RetryButtonVisibility { get; set; } = Visibility.Collapsed;

        /// <summary>
        /// Gets or sets the visibility of the ignore button.
        /// </summary>
        public Visibility IgnoreButtonVisibility { get; set; } = Visibility.Collapsed;

        /// <summary>
        /// Gets or sets the command for the cancel button click event.
        /// </summary>
        public ButtonClickCommand CancelButtonClick { get; set; }

        /// <summary>
        /// Gets or sets the command for the no button click event.
        /// </summary>
        public ButtonClickCommand NoButtonClick { get; set; }

        /// <summary>
        /// Gets or sets the command for the yes button click event.
        /// </summary>
        public ButtonClickCommand YesButtonClick { get; set; }

        /// <summary>
        /// Gets or sets the command for the OK button click event.
        /// </summary>
        public ButtonClickCommand OkButtonClick { get; set; }

        /// <summary>
        /// Gets or sets the command for the abort button click event.
        /// </summary>
        public ButtonClickCommand AbortButtonClick { get; set; }

        /// <summary>
        /// Gets or sets the command for the retry button click event.
        /// </summary>
        public ButtonClickCommand RetryButtonClick { get; set; }

        /// <summary>
        /// Gets or sets the command for the ignore button click event.
        /// </summary>
        public ButtonClickCommand IgnoreButtonClick { get; set; }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the PropertyChanged event.
        /// </summary>
        /// <param name="name">The name of the property that changed.</param>
        public void OnPropertyChanged(string name)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
