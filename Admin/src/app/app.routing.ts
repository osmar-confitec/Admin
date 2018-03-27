import { PageNotFoundComponent } from "./page-not-found/page-not-found.component";
import { Routes, RouterModule  } from '@angular/router';
import { ModuleWithProviders } from "@angular/core";
import { AppComponent } from "./app.component";
import { HomeComponent } from "./home/home.component";

const APP_ROUTES : Routes = [
    {path:''  ,   component: HomeComponent  },
    {path:'**'  , component: PageNotFoundComponent  }
]; 
export const routing:ModuleWithProviders = RouterModule.forRoot(APP_ROUTES);