import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { HomeComponent } from './home/home.component';
import { routing } from './app.routing';
import { PipesModule } from './shared-modules/pipes/pipes.module';
import { DirectivesModule } from './shared-modules/directives/directives.module';


@NgModule({
  declarations: [
    AppComponent,
    PageNotFoundComponent,
    HomeComponent
   
  ],
  imports: [
    BrowserModule,
    routing,
    PipesModule,
    DirectivesModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
