using NLog.Fluent;
using ProcessText.Commands;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace ProcessText.ViewModels
{
    /// <summary>
    /// ViewModel for the main window of the application. Manages the user interface, properties, and commands.
    /// </summary>
    public class MainWindowsViewModel : INotifyPropertyChanged
    {
        #region Fields

        // Fields for various properties
        private string _tittle;
        private string _closeButtonContent;
        private ulong _numberOfHyphen;
        private ulong _numberOfWhiteSpaces;
        private string _numberOfHyphenTittle;
        private string _numberOfWordsTittle;
        private string _numberOfWhiteSpacesTittle;
        private string _textToProcess;
        private string _insertTextTittle;
        private string _orderTittle;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowsViewModel"/> class.
        /// </summary>
        public MainWindowsViewModel()
        {
            Tittle = $"Process Text App";
            CloseButtonContent = $"Cerrar";
            InsertTextTittle = $"Insertar texto en el cuadro";
            NumberOfHyphenTittle = $"Cantidad de guiones";
            NumberOfWordsTittle = $"Cantidad de palabras";
            NumberOfWhiteSpacesTittle = $"Cantidad de espacios";
            OrderTittle = $"Orden";

            NumberOfHyphen = ulong.MinValue;
            NumberOfWords = ulong.MinValue;
            NumberOfWhiteSpaces = ulong.MinValue;

            // Initializes commands.
            CloseAppCommand = new RelayCommand<object>(CanExecuteCloseAppCommand, ExecuteCloseAppCommand);
        }

        /// <summary>
        /// Subscribe for property changed events.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets a text value of app tittle.
        /// </summary>
        public string Tittle
        {
            get => _tittle;
            set
            {
                if (_tittle != value)
                {
                    _tittle = value;
                    NotifyPropertyChanged(nameof(Tittle));
                }
            }
        }

        /// <summary>
        /// Gets or sets a text to process.
        /// </summary>
        public string TextToProcess
        {
            get => _textToProcess;
            set
            {
                if (_textToProcess != value)
                {
                    _textToProcess = value;
                    NotifyPropertyChanged(nameof(TextToProcess));
                }
            }
        }

        /// <summary>
        /// Gets or sets a insert text tittle.
        /// </summary>
        public string InsertTextTittle
        {
            get => _insertTextTittle;
            set
            {
                if (_insertTextTittle != value)
                {
                    _insertTextTittle = value;
                    NotifyPropertyChanged(nameof(InsertTextTittle));
                }
            }
        }

        /// <summary>
        /// Gets or sets a text value of number of hyphen tittle.
        /// </summary>
        public string NumberOfHyphenTittle
        {
            get => _numberOfHyphenTittle;
            set
            {
                if (_numberOfHyphenTittle != value)
                {
                    _numberOfHyphenTittle = value;
                    NotifyPropertyChanged(nameof(NumberOfHyphenTittle));
                }
            }
        }

        /// <summary>
        /// Gets or sets number of words tittle.
        /// </summary>
        public string NumberOfWordsTittle
        {
            get => _numberOfWordsTittle;
            set
            {
                if (_numberOfWordsTittle != value)
                {
                    _numberOfWordsTittle = value;
                    NotifyPropertyChanged(nameof(NumberOfWordsTittle));
                }
            }
        }

        /// <summary>
        /// Gets or sets number of white spaces tittle.
        /// </summary>
        public string NumberOfWhiteSpacesTittle
        {
            get => _numberOfWhiteSpacesTittle;
            set
            {
                if (_numberOfWhiteSpacesTittle != value)
                {
                    _numberOfWhiteSpacesTittle = value;
                    NotifyPropertyChanged(nameof(NumberOfWhiteSpacesTittle));
                }
            }
        }

        /// <summary>
        /// Gets or sets order tittle.
        /// </summary>
        public string OrderTittle
        {
            get => _orderTittle;
            set
            {
                if (_orderTittle != value)
                {
                    _orderTittle = value;
                    NotifyPropertyChanged(nameof(OrderTittle));
                }
            }
        }

        /// <summary>
        /// Gets or sets number of hyphen type characters.
        /// </summary>
        public ulong NumberOfHyphen
        {
            get => _numberOfHyphen;
            set
            {
                if (_numberOfHyphen != value)
                {
                    _numberOfHyphen = value;
                    NotifyPropertyChanged(nameof(NumberOfHyphen));
                }
            }
        }

        /// <summary>
        /// Gets or sets number of words.
        /// </summary>
        public ulong NumberOfWords
        {
            get => _numberOfHyphen;
            set
            {
                if (_numberOfHyphen != value)
                {
                    _numberOfHyphen = value;
                    NotifyPropertyChanged(nameof(NumberOfWords));
                }
            }
        }

        /// <summary>
        /// Gets or sets number of white spaces.
        /// </summary>
        public ulong NumberOfWhiteSpaces
        {
            get => _numberOfWhiteSpaces;
            set
            {
                if (_numberOfWhiteSpaces != value)
                {
                    _numberOfHyphen = value;
                    NotifyPropertyChanged(nameof(NumberOfWhiteSpaces));
                }
            }
        }

        /// <summary>
        /// Gets or sets a text value of close button.
        /// </summary>
        public string CloseButtonContent
        {
            get => _closeButtonContent;
            set
            {
                if (_closeButtonContent != value)
                {
                    _closeButtonContent = value;
                    NotifyPropertyChanged(nameof(CloseButtonContent));
                }
            }
        }

        /// <summary>
        /// Gets or sets close app command.
        /// </summary>
        public RelayCommand<object> CloseAppCommand { get; set; }

        /// <summary>
        /// Called by Set accessor of each property that needs to notify it's value has changed.
        /// </summary>
        /// <param name="propertyName">The name of the property it's value changed.</param>
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Determines whether the Close App command can be executed.
        /// </summary>
        /// <param name="parameter">The parameter for the command.</param>
        /// <returns>True if the command can be executed; otherwise, false.</returns>
        private bool CanExecuteCloseAppCommand(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Executes the Close App command, shutting down the application.
        /// </summary>
        /// <param name="parameter">The parameter for the command.</param>
        private void ExecuteCloseAppCommand(object parameter)
        {
            try
            {
                // Shuts down the application.
                Log.Fatal($"Execute close application.");
                Application.Current.Shutdown();
            }
            catch (Exception ex)
            {
                // Logs any unhandled exceptions.
                Log.Error($"An unhandled exception has occurred in {nameof(ExecuteCloseAppCommand)} and the message is: {ex.Message}");
            }
        }
    }
}
