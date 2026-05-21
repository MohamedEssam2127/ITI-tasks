import { Routes  } from '@angular/router';
import { authGuard } from './auth-guard';

export const routes: Routes = [
  {
    path: '',
    redirectTo: 'home',
    pathMatch: 'full'
  },
  {
    path: 'home',
    canActivate: [authGuard],
    loadComponent: () => import('./pages/home-dashboard/home-dashboard').then(m => m.HomeDashboard)
  },
  {
    path:'signin',
    loadComponent: () => import('./pages/signin/signin').then(m => m.Signin)
  },
  {
    path:'signup',
    loadComponent: () => import('./pages/signup/signup').then(m => m.Signup)
  },
  {
    path:'add',
    canActivate: [authGuard],
    loadComponent: () => import('./components/task-input/task-input').then(m => m.TaskInput)
  },
  {
    path:'tasks',
    canActivate: [authGuard],
    loadComponent: () => import('./components/task-list/task-list').then(m => m.TaskList)
  },
   {
    path:'**',
    loadComponent: () => import('./pages/not-found/not-found').then(m => m.NotFound)
  }
];
