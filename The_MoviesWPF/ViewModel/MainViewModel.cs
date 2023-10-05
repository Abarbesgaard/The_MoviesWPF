using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using The_MoviesWPF.Commands;

namespace The_MoviesWPF.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ICommand addMovieCommand {  get; set; } 
        private MovieViewModel newMovie;
        public MovieViewModel NewMovie
        {
            get { return newMovie; }
            set
            {
                newMovie = value;
                OnPropertyChanged("newMovie");
            }
        }
        public MainViewModel()
        {
            addMovieCommand = new AddMovieCommand();
            NewMovie = new MovieViewModel();
            NewMovie.Title = "Titanic";
            NewMovie.Duration = 0;
            NewMovie.Genre = "DokuDrama";

        }

        public void AddMovie()
        {
            newMovie.Add();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
