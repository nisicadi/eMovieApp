import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MoviesComponent} from "./movies/movies.component";
import {AddMovieComponent} from "./add-movie/add-movie.component";
import {RouterModule, Routes} from "@angular/router";

const routes: Routes = [
  {path: '', component: MoviesComponent},
  {path: 'add-movie', component: AddMovieComponent},
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
