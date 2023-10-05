using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_MoviesWPF.Model;

namespace The_MoviesWPF.ViewModel
{
    public class MovieViewModel 
    {
        public Movie _movie;
        public MovieRepository _movieRepository = new MovieRepository();

        public string Title { get; set; }

        public int Duration { get; set; }
        
        
        public string Genre { get; set; }
        public void Add()
        {
            _movie = new Movie() { Title = Title, Duration = Duration, Genre = Genre };
            
            _movieRepository.Add(_movie);
        }

    }
}
