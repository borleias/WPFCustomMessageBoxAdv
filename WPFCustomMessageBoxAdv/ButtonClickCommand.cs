using System;
using System.Windows.Forms;
using System.Windows.Input;

namespace WPFCustomMessageBoxAdv
{
    /// <summary>
    /// Represents a command that is executed when a button is clicked.
    /// </summary>
    internal class ButtonClickCommand : ICommand
    {
#pragma warning disable CS0067 // The event is never used
        public event EventHandler CanExecuteChanged;
#pragma warning restore CS0067

        /// <summary>
        /// Gets or sets the action to be executed when the button is clicked.
        /// </summary>
        public Action<DialogResult> Action { get; set; }

        /// <summary>
        /// Gets or sets the result of the button click.
        /// </summary>
        public DialogResult Result { get; set; } = DialogResult.None;

        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonClickCommand"/> class.
        /// </summary>
        public ButtonClickCommand()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonClickCommand"/> class with the specified action and result.
        /// </summary>
        /// <param name="action">The action to be executed when the button is clicked.</param>
        /// <param name="result">The result of the button click.</param>
        public ButtonClickCommand(Action<DialogResult> action, DialogResult result)
        {
            this.Action = action;
            this.Result = result;
        }

        /// <summary>
        /// Determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">The parameter for the command.</param>
        /// <returns><c>true</c> if the command can execute; otherwise, <c>false</c>.</returns>
        public bool CanExecute(object parameter)
            => (this.Action != null);

        /// <summary>
        /// Executes the command.
        /// </summary>
        /// <param name="parameter">The parameter for the command.</param>
        public void Execute(object parameter)
            => this.Action.Invoke(this.Result);
    }
}
