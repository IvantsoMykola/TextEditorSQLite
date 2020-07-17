using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using TextEditorSQLite.Helpers;
using TextEditorSQLite.Models;

namespace TextEditorSQLite.ViewModels
{
    class MainWindowViewModel : Observable
    {
        private const string NEW_FILE_NAME = "NewFile";

        public ObservableCollection<TextFile> CurrentFiles { get; set; } = new ObservableCollection<TextFile>();

        private ICommand newFileCommand;
        private ICommand openFileCommand;
        private ICommand saveFileCommand;
        private ICommand deleteFileCommand;

        public ICommand NewFileCommand => newFileCommand ?? (newFileCommand = new RelayCommand(CreateNewTextFile));
        public ICommand OpenFileCommand => openFileCommand ?? (newFileCommand = new RelayCommand(OpenTextFile));
        public ICommand SaveFileCommand => saveFileCommand ?? (saveFileCommand = new RelayCommand(SaveTextFile));
        public ICommand DeleteFileCommand => deleteFileCommand ?? (deleteFileCommand = new RelayCommand(DeleteTextFile));

        
        private void CreateNewTextFile()
        {
            var newFilesCount = CurrentFiles.Count(textFile => textFile.Title.StartsWith(NEW_FILE_NAME));
            string fileName = newFilesCount > 0 ? NEW_FILE_NAME + "(" + newFilesCount + ")" : NEW_FILE_NAME;
            CurrentFiles.Add(new TextFile() {Title = fileName });
        }

        private void OpenTextFile()
        {
            throw new NotImplementedException();
        }

        private void SaveTextFile()
        {
            throw new NotImplementedException();
        }

        private void DeleteTextFile()
        {
            throw new NotImplementedException();
        }

        public MainWindowViewModel()
        {
        }
    }
}
