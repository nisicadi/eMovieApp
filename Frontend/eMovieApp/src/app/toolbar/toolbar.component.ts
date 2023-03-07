import { Component } from '@angular/core';
import {Route, Router} from "@angular/router";

@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.css']
})
export class ToolbarComponent {
  constructor(private router: Router) { }
  routes = this.router.config.map((route: Route) => route?.path || 'Home')
  pageTitle = 'Home';

  changeRoute(route: string) {
    this.pageTitle = route;
    const goTo = route === 'Home' ? '/' : route;
    this.router.navigate([goTo]);
  }
}
