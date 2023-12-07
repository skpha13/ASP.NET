import { Routes } from '@angular/router';
import {PostComponent} from "../Components/post/post.component";
import {LandingPageComponent} from "../Components/landing-page/landing-page.component";

export const routes: Routes = [
  {
    path: '',
    component: LandingPageComponent
  },
  {
    path: 'posts',
    component: PostComponent
  }
];
