import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TarjetaComponent } from './components/tarjeta/tarjeta.component';
import { TarjetaCreditoComponent } from './components/tarjeta/tarjeta-credito/tarjeta-credito.component';
import { ListaTarjetaCreditoComponent } from './components/tarjeta/lista-tarjeta-credito/lista-tarjeta-credito.component';
import { FooterComponent } from './components/footer/footer.component';
import { MatAutocompleteModule} from '@angular/material/autocomplete';
import { MatInputModule} from '@angular/material/input';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { SegundoFormularioComponent } from './components/tarjeta/segundo-formulario/segundo-formulario.component';
import { MatProgressBarModule} from '@angular/material/progress-bar';
import { TercerFormularioComponent } from './components/tarjeta/tercer-formulario/tercer-formulario.component';
import { MatFormFieldModule} from '@angular/material/form-field';
import {MatIconModule} from '@angular/material/icon';
import {MatButtonModule} from '@angular/material/button';


@NgModule({
  declarations: [
    AppComponent,
    TarjetaComponent,
    TarjetaCreditoComponent,
    ListaTarjetaCreditoComponent,
    FooterComponent,
    SegundoFormularioComponent,
    TercerFormularioComponent,
    
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    ToastrModule.forRoot(),
    BrowserAnimationsModule,
    FormsModule,
    MatAutocompleteModule,
    MatProgressBarModule,
    MatFormFieldModule,
    MatInputModule,
    MatIconModule,
    MatButtonModule

  
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
