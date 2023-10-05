using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using The_MoviesWPF.ViewModel;

namespace The_MoviesWPF.Commands
{
    public class AddMovieCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            string messageBoxText = string.Empty;
            string messageBoxCaption = string.Empty;
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxResult messageBoxResult;

            if (parameter is MainViewModel mvm)
            {
                try
                {
                    if (mvm.NewMovie.Title.IsNullOrEmpty())
                        throw new Exception("Hov hov do. TITEL");

                    if (mvm.NewMovie.Genre.IsNullOrEmpty())
                        throw new Exception("Hov hov do. Genre");

                    if (mvm.NewMovie.Duration <= 0)
                        throw new Exception("Hov hov do. Duration");
                }
                catch (Exception ex) 
                {
                    messageBoxText = ex.Message;
                    messageBoxCaption = ex.StackTrace;
                    messageBoxResult = MessageBox.Show( messageBoxText, messageBoxCaption,button);
                    return;
                }

                mvm.AddMovie();

            }
        }
    }
}
