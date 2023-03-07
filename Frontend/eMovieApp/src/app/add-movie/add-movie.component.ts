import {Component, OnInit} from '@angular/core';
import { Router } from '@angular/router';
import {MoviesServiceService} from "../services/movies-service.service";

@Component({
  selector: 'app-add-movie',
  templateUrl: './add-movie.component.html',
  styleUrls: ['./add-movie.component.css']
})
export class AddMovieComponent implements OnInit{
  movieTitle: string = '';
  imageUrl: string = '';

  constructor(private moviesService: MoviesServiceService, private router: Router) { }

  ngOnInit(): void {

  }

  saveChanges(){
    if(this.movieTitle && this.imageUrl)
    {

    }
    this.router.navigate(['/'])
  }
}
