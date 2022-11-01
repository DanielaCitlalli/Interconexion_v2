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

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { SegundoFormularioComponent } from './components/tarjeta/segundo-formulario/segundo-formulario.component';

@NgModule({
  declarations: [
    AppComponent,
    TarjetaComponent,
    TarjetaCreditoComponent,
    ListaTarjetaCreditoComponent,
    FooterComponent,
    SegundoFormularioComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    ToastrModule.forRoot(),
    BrowserAnimationsModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
