import { Component, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { CirrTa03Depeticion } from 'src/app/models/CirrTa03Depeticion.model';

@Component({
  selector: 'app-tarjeta',
  templateUrl: './tarjeta.component.html',
  styleUrls: ['./tarjeta.component.css']
})
export class TarjetaComponent implements OnInit, OnChanges {

  registroEnviar: any;
  cambioSexoDisponible: boolean = false;


  constructor() { }

  ngOnInit(): void {
    console.log(this.cambioSexoDisponible);
    
  }

  ngOnChanges(changes: SimpleChanges): void {
    console.log(changes);
  }

  //Recibe el valor que se emita por Output en tarjeta-credito
  mostrarRegistroDevuleto(event: any){
    // if(event !== true){
    //   this.registroEnviar = event;
    //   console.log(this.registroEnviar , 'componente Padre');
    // }
    // else{
    //   //Si es igual true, habilita el segundo formulario
    //   this.cambioSexoDisponible = event;
    // }

    this.registroEnviar = event.registro;
    this.cambioSexoDisponible = event.habilitarForm;
    console.log(this.registroEnviar , this.cambioSexoDisponible);
    
  }

}