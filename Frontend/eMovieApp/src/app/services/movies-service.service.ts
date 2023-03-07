import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from "@angular/common/http";
import {Observable} from "rxjs";
import { Movies } from '../models/movie';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'ápplication/json'
  })
}
@Injectable({
  providedIn: 'root'
})
export class MoviesServiceService {
  private baseApiUrl = 'http://localhost:3000/movies';
  constructor(private httpClient: HttpClient) { }

  getMovies(): Observable<Movies[]> {
    return this.httpClient.get<Movies[]>(this.baseApiUrl);
  }

  updateMovie(movie: Movies): Observable<Movies> {
    const url = `${this.baseApiUrl}/${movie.id}`
    return this.httpClient.put<Movies>(url, movie, httpOptions);
  }
}
