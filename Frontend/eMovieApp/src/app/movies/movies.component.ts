import {Component, OnInit} from '@angular/core';
import {Movies} from "../models/movie";
import {MoviesServiceService} from "../services/movies-service.service";

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrls: ['./movies.component.css']
})
export class MoviesComponent implements OnInit {
  movies: Movies[] = [];
  watchedMovies: Movies[] = [];
  toWatchMovies: Movies[] = [];
  constructor(private moviesService: MoviesServiceService) { }
  ngOnInit(): void {
    this.getMovies();
  }

  getMovies(): void {
    this.moviesService.getMovies().subscribe(x => {
      this.movies = x;
    });
  }

  updateMovie(movie: Movies): void {
    this.moviesService.updateMovie(movie).subscribe(x=> this.getMovies());
  }

  ngDoCheck(): void {
    if(this.movies.length && !this.watchedMovies.length) {
      this.toWatchMovies = this.movies.filter((x) => !x.isFav && !x.isWatched);
      this.watchedMovies = this.movies.filter((x) => x.isWatched);
    }
  }

  onFavClick(movie: Movies) {
    movie.isFav = !movie.isFav;

    this.updateMovie(movie);
  }

  onWatchedClick(movie: Movies) {
    movie.isWatched = !movie.isWatched;

    this.updateMovie(movie);
  }
}
